<div align="center">

   # 🚀 Azure Event-Driven Document Processor

> **Production-Grade Serverless Document Processing Pipeline** built
> with **.NET 8, Azure Functions, Azure Blob Storage, Azure Service Bus,
> and Azure SQL Database**

<p>

![.NET](https://img.shields.io/badge/.NET-8-512BD4?style=for-the-badge&logo=dotnet)
![Azure Functions](https://img.shields.io/badge/Azure-Functions-0062AD?style=for-the-badge&logo=azurefunctions)
![Azure Blob](https://img.shields.io/badge/Azure-BlobStorage-0078D4?style=for-the-badge&logo=microsoftazure)
![Azure Service Bus](https://img.shields.io/badge/Azure-ServiceBus-0089D6?style=for-the-badge)
![Azure SQL](https://img.shields.io/badge/Azure-SQL-CC2927?style=for-the-badge)

</p>

## 🌟 Overview

This project demonstrates how enterprise applications process uploaded
PDF resumes **asynchronously** using an **event-driven architecture**.
Instead of blocking the client while processing documents, the
application uploads the file to Azure Blob Storage, publishes an event
to Azure Service Bus, and lets Azure Functions process the document in
the background.

</div>

## 🏗️ Architecture

``` text
Client
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
   ├── Download PDF
   ├── Extract Text (PdfPig)
   ├── Persist to Azure SQL
   └── Log to Application Insights
```

## ✨ Features

-   Upload PDF resumes to Azure Blob Storage
-   Asynchronous processing using Azure Service Bus
-   Azure Function Service Bus Trigger
-   PDF parsing with PdfPig
-   Store extracted data in Azure SQL Database
-   Dependency Injection
-   Structured logging
-   Cloud-native serverless architecture
-   Production-ready folder structure

## 🛠️ Technology Stack

| Category | Technologies |
|------------|--------------------------------------------|
| Language | C# |
| Framework | .NET 8 |
| Cloud | Microsoft Azure |
| Compute | Azure Functions |
| Storage | Azure Blob Storage |
| Messaging | Azure Service Bus |
| Database | Azure SQL Database |
| ORM | Entity Framework Core |
| PDF | PdfPig |
| Logging | Application Insights |
| IDE | Visual Studio 2022 |

## 📊 Azure Services Used

| Azure Service | Purpose |
|----------------|----------------------------|
| Blob Storage | Store PDF documents |
| Service Bus | Reliable asynchronous messaging |
| Azure Functions | Serverless processing |
| Azure SQL | Persist extracted data |
| Application Insights | Monitoring & Logging |


## 📂 Solution Structure

``` text
Azure-EventDriven-DocumentProcessor
│
├── AzureBlobDemo/
├── AzureServiceBusDemo/
├── Employee.Functions/
│   ├── Services/
│   ├── Models/
│   ├── Data/
│   └── ResumeProcessor/
└── README.md
```

## 🚀 Production Engineering Highlights

-   Event-Driven Architecture
-   Queue-Based Decoupling
-   Async Processing
-   Serverless Computing
-   Dependency Injection
-   Scalable Cloud Design
-   Configuration Management
-   Secure Secret Handling
-   Monitoring with Application Insights

## 🔐 Security

-   Secrets are **not committed** to Git.
-   `local.settings.json` is ignored.
-   Supports Azure Key Vault integration.
-   Uses environment variables for sensitive configuration.

## 📈 Observability

-   Application Insights
-   Azure Function Logs
-   Queue Processing Logs
-   Failure Tracking
-   Execution Metrics


## 📸 Project Walkthrough

## 📁 Azure Blob Storage

<img width="958" height="442" alt="image" src="https://github.com/user-attachments/assets/6f8233b8-3f1a-45c7-bf83-8783cb4177da" />

---

## 📨 Azure Service Bus Queue

<img width="959" height="535" alt="image" src="https://github.com/user-attachments/assets/0eefdf7f-5fdf-436d-93a1-6c8e21190655" />

---

## ⚙ Azure Function Execution

<img width="959" height="445" alt="image" src="https://github.com/user-attachments/assets/bbd58460-8c4e-4a91-b032-57adeed32da2" />

---

## 🗄 Azure SQL Database

<img width="959" height="441" alt="image" src="https://github.com/user-attachments/assets/d4ac0906-498c-4ce3-a093-cd2fc7672205" />

---

## 📈 Application Logs

<img width="959" height="445" alt="image" src="https://github.com/user-attachments/assets/bbd58460-8c4e-4a91-b032-57adeed32da2" />



## ⚙️ Local Setup

``` bash
git clone https://github.com/thekamalbora/Azure-EventDriven-DocumentProcessor.git
```

Update `local.settings.json` with:

-   Azure Blob Storage Connection String
-   Azure Service Bus Connection String
-   Azure SQL Connection String

Run:

1.  AzureBlobDemo
2.  AzureServiceBusDemo
3.  Employee.Functions

## 🛣️ Roadmap

-   ✅ Blob Storage
-   ✅ Azure Service Bus
-   ✅ Azure Functions
-   ✅ Azure SQL
-   ✅ PDF Parsing
-   ⏳ Azure OpenAI Resume Analysis
-   ⏳ GitHub Actions CI/CD
-   ⏳ Docker
-   ⏳ Azure Key Vault
-   ⏳ OpenTelemetry

## 💡 Engineering Learnings

-   Event-driven system design
-   Azure messaging patterns
-   Serverless architecture
-   Reliable background processing
-   Cloud-native application development

## 👨‍💻 Author

**Kamal Singh Bora**

Senior Software Engineer \| .NET \| Azure \| Microservices

-   LinkedIn: https://www.linkedin.com/in/thekamalbora/
-   GitHub: https://github.com/thekamalbora
-   Portfolio : https://www.thekamalbora.in

------------------------------------------------------------------------

⭐ If you found this project useful, please consider giving it a star.
