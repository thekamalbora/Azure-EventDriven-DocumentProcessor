using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
string connectionString = configuration["StorageConnection"];
string containerName = configuration["ContainerName"];

BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);

await containerClient.CreateIfNotExistsAsync();
string filePath = "Resume.pdf";
BlobClient blobClient = containerClient.GetBlobClient("Resume.pdf");
using FileStream uploadFileStream = File.OpenRead(filePath);
await blobClient.UploadAsync(uploadFileStream, overwrite: true);
Console.WriteLine("File Uploaded Successfully.");