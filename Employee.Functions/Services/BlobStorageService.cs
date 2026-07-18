using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace Employee.Functions.Services;

public class BlobStorageService
{
    private readonly BlobContainerClient _container;

    public BlobStorageService(IConfiguration configuration)
    {
        var client = new BlobServiceClient(configuration["BlobConnection"]);

        _container = client.GetBlobContainerClient(configuration["BlobContainerName"]);
    }

    public async Task<Stream> DownloadAsync(string blobName)
    {
        var blob = _container.GetBlobClient(blobName);

        if (!await blob.ExistsAsync())
            throw new FileNotFoundException(blobName);

        var response = await blob.DownloadStreamingAsync();

        return response.Value.Content;
    }
}