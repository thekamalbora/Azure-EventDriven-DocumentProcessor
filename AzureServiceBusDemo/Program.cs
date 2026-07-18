using System.Text.Json;
using Azure.Messaging.ServiceBus;
using AzureServiceBusDemo.Models;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration["ServiceBusConnection"];
string queueName = configuration["QueueName"];

await using var client = new ServiceBusClient(connectionString);

ServiceBusSender sender = client.CreateSender(queueName);

var resumeMessage = new ResumeMessage
{
    EmployeeId = 101,
    EmployeeName = "Kamal Singh Bora",
    BlobName = "Resume.pdf"
};

string json = JsonSerializer.Serialize(resumeMessage);

await sender.SendMessageAsync(new ServiceBusMessage(json));

Console.WriteLine("Message Sent Successfully.");