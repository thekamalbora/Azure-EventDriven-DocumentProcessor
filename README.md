# 🚀 Azure-EventDriven-DocumentProcessor


> Event-Driven Document Processing Pipeline built with Azure Blob Storage, Azure Service Bus, Azure Functions, and .NET 8.

![.NET](https://img.shields.io/badge/.NET-8-purple)
![Azure Functions](https://img.shields.io/badge/Azure-Functions-blue)
![Azure Blob Storage](https://img.shields.io/badge/Azure-BlobStorage-blue)
![Azure Service Bus](https://img.shields.io/badge/Azure-ServiceBus-blue)
![License](https://img.shields.io/badge/License-MIT-green)

---

# 📖 Overview

Azure-EventDriven-DocumentProcessor is a production-style event-driven document processing system demonstrating how Azure services work together.

Instead of processing uploaded documents synchronously, the system stores files in Azure Blob Storage, publishes metadata to Azure Service Bus, and lets Azure Functions process documents asynchronously.

This architecture improves scalability, reliability, and responsiveness.

---

# 🏗 Architecture

```

                Upload Resume.pdf
                        │
                        ▼
        Azure Blob Storage
                        │
                        ▼
        Azure Service Bus Queue
                        │
                        ▼
       Azure Function Trigger
                        │
                        ▼
          PDF Text Extraction
                        │
                        ▼
          Future Enhancements
      SQL Server • Azure OpenAI

```

---

# ✨ Features

✅ Upload files to Azure Blob Storage

✅ Send metadata using Azure Service Bus

✅ Azure Function Service Bus Trigger

✅ Automatic PDF Processing

✅ Dependency Injection

✅ Structured Logging

✅ Event-Driven Architecture

✅ Clean Service Layer

---

# 🛠 Tech Stack

| Technology | Purpose |
|------------|----------|
| .NET 8 | Backend |
| Azure Functions | Serverless Processing |
| Azure Blob Storage | File Storage |
| Azure Service Bus | Messaging |
| PdfPig | PDF Parsing |
| Dependency Injection | Clean Architecture |
| Azure Storage SDK | Blob Integration |

---

# 📂 Solution Structure

```

EmployeeDocumentProcessor

├── AzureBlobDemo
│ └── Upload PDF to Blob Storage
│
├── AzureServiceBusDemo
│ └── Publish Message to Queue
│
├── Employee.Functions
│ ├── ResumeProcessor
│ ├── BlobStorageService
│ ├── PdfReaderService
│ ├── DocumentProcessingService
│ └── Models
│
└── README.md

```

---

# 🔄 Workflow

1. Upload Resume.pdf

↓

2. Store file in Azure Blob Storage

↓

3. Publish metadata to Azure Service Bus

↓

4. Azure Function is triggered automatically

↓

5. Download PDF from Blob Storage

↓

6. Extract text using PdfPig

↓

7. Ready for AI processing / Database storage

