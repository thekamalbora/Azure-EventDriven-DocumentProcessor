using Employee.Functions.Models;
using Microsoft.Extensions.Logging;

namespace Employee.Functions.Services;

public class DocumentProcessingService
{
    private readonly BlobStorageService _blobStorage;
    private readonly PdfReaderService _pdfReader;
    private readonly ILogger<DocumentProcessingService> _logger;
    private readonly ResumeRepository _repository;
    public DocumentProcessingService(
        BlobStorageService blobStorage,
        PdfReaderService pdfReader,
        ILogger<DocumentProcessingService> logger,
        ResumeRepository repository)
    {
        _blobStorage = blobStorage;
        _pdfReader = pdfReader;
        _logger = logger;
        _repository = repository;
    }

    public async Task ProcessAsync(ResumeMessage model)
    {
        await using Stream pdfStream =
            await _blobStorage.DownloadAsync(model.BlobName);

        string text = _pdfReader.Read(pdfStream);

        _logger.LogInformation("Resume Parsed Successfully");

        _logger.LogInformation("Employee : {Employee}",
            model.EmployeeName);

        _logger.LogInformation("Characters : {Length}",
            text.Length);

        _logger.LogInformation(
            text.Substring(0, Math.Min(300, text.Length)));

        await _repository.SaveAsync(
        new ResumeDocument
        {
            EmployeeId = model.EmployeeId,
            EmployeeName = model.EmployeeName,
            BlobName = model.BlobName,
            ResumeText = text,
            CreatedDate = DateTime.UtcNow
        });
        _logger.LogInformation("Resume saved successfully in SQL Database");
        // Future
        // Save SQL
        // Call Azure OpenAI
        // Send Email
    }
}