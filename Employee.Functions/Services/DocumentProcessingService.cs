using Microsoft.Extensions.Logging;

namespace Employee.Functions.Services;

public class DocumentProcessingService
{
    private readonly BlobStorageService _blobStorage;
    private readonly PdfReaderService _pdfReader;
    private readonly ILogger<DocumentProcessingService> _logger;

    public DocumentProcessingService(
        BlobStorageService blobStorage,
        PdfReaderService pdfReader,
        ILogger<DocumentProcessingService> logger)
    {
        _blobStorage = blobStorage;
        _pdfReader = pdfReader;
        _logger = logger;
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

        // Future
        // Save SQL
        // Call Azure OpenAI
        // Send Email
    }
}