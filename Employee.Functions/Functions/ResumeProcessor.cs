using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using Employee.Functions.Services;
using System;
namespace Employee.Functions.Functions
{
    public class ResumeProcessor
    {
        private readonly ILogger<ResumeProcessor> _logger;
        private readonly DocumentProcessingService _documentProcessor;
        public ResumeProcessor(
         ILogger<ResumeProcessor> logger,
         DocumentProcessingService documentProcessor)
        {
            _logger = logger;
            _documentProcessor = documentProcessor;
        }

        [Function(nameof(ResumeProcessor))]
        public async Task Run([ServiceBusTrigger("employee-upload", Connection = "ServiceBusConnection")] ServiceBusReceivedMessage message)
        {
            var body = message.Body.ToString();

            var model =
                JsonSerializer.Deserialize<ResumeMessage>(body);

            if (model == null)
            {
                _logger.LogError("Invalid Message");
                return;
            }

            await _documentProcessor.ProcessAsync(model);
        }
    }
}