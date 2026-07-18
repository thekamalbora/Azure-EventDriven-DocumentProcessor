<div align="center">

# 🚀 Azure Event-Driven Document Processor

### Production-Grade Serverless Document Processing Pipeline built with Azure & .NET 8

<p>

![.NET](https://img.shields.io/badge/.NET-8-512BD4?style=for-the-badge&logo=dotnet)
![Azure Functions](https://img.shields.io/badge/Azure-Functions-0062AD?style=for-the-badge&logo=azurefunctions)
![Azure Blob](https://img.shields.io/badge/Azure-BlobStorage-0078D4?style=for-the-badge&logo=microsoftazure)
![Azure Service Bus](https://img.shields.io/badge/Azure-ServiceBus-0089D6?style=for-the-badge)
![Azure SQL](https://img.shields.io/badge/Azure-SQL-CC2927?style=for-the-badge)

</p>

---

**An enterprise-style event-driven system that automatically processes PDF resumes using Azure Blob Storage, Azure Service Bus, Azure Functions and Azure SQL Database.**

</div>

---

# ✨ Why this project?

Traditional applications process uploaded files synchronously, increasing response time and reducing scalability.

This project demonstrates how enterprise applications solve the problem using **Event-Driven Architecture**.

```

Upload Resume

↓

Azure Blob Storage

↓

Azure Service Bus

↓

Azure Function Trigger

↓

PDF Parsing

↓

Azure SQL Database

```

The upload request returns immediately while processing happens asynchronously in the background.

---

# 🏗 Solution Architecture

<p align="center">

<img width="959" height="464" alt="image" src="https://github.com/user-attachments/assets/1f167532-6b26-4f8b-b82d-096e124fcd67" />


</p>

---

# ⚡ Key Features

- 📄 Upload PDF documents to Azure Blob Storage
- ⚡ Asynchronous processing using Azure Service Bus
- ☁️ Azure Function Service Bus Trigger
- 📚 Automatic PDF Text Extraction
- 🗄 Persist extracted data into Azure SQL Database
- 📈 Application Insights Logging
- 🧩 Dependency Injection
- 🏛 Clean Service Layer
- 🚀 Serverless Architecture
- 🔥 Production Deployment on Microsoft Azure

---

# 🔄 End-to-End Workflow

```text
                    Upload Resume.pdf
                            │
                            ▼
                Azure Blob Storage
                            │
                            ▼
               Azure Service Bus Queue
                            │
                            ▼
                 Azure Function App
                            │
             Download PDF from Blob
                            │
                            ▼
                 Extract Text (PdfPig)
                            │
                            ▼
                 Azure SQL Database
                            │
                            ▼
                Resume Successfully Stored
```

---

# 📸 Project Walkthrough

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

---

# 🛠 Technology Stack

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

---

# 📂 Solution Structure

```

Azure-EventDriven-DocumentProcessor

│

├── AzureBlobDemo

├── AzureServiceBusDemo

├── Employee.Functions

│ ├── Services

│ ├── Models

│ ├── Data

│ └── ResumeProcessor

│

└── README.md

```

---

# 🚀 Local Setup

```bash
git clone https://github.com/YOUR_USERNAME/Azure-EventDriven-DocumentProcessor.git
```

Configure

```
local.settings.json
```

Update

- Blob Storage Connection String
- Service Bus Connection String
- Azure SQL Connection String

Run

```bash
Employee.Functions

↓

AzureBlobDemo

↓

AzureServiceBusDemo
```

---

# 📊 Azure Services Used

| Azure Service | Purpose |
|----------------|----------------------------|
| Blob Storage | Store PDF documents |
| Service Bus | Reliable asynchronous messaging |
| Azure Functions | Serverless processing |
| Azure SQL | Persist extracted data |
| Application Insights | Monitoring & Logging |

---

# 🚀 Future Enhancements

- 🤖 Azure OpenAI Resume Analyzer
- 🔍 Skill Extraction using GPT
- 📊 Resume Dashboard
- 🐳 Docker Support
- 🔐 Azure Key Vault
- ⚙ GitHub Actions CI/CD
- 📩 Email Notification
- 🌐 ASP.NET Core Web API

---

# 💡 Architecture Highlights

✔ Event-Driven Architecture

✔ Serverless Computing

✔ Asynchronous Processing

✔ Dependency Injection

✔ Repository Pattern

✔ Cloud-Native Design

✔ Scalable Azure Services

---

# 👨‍💻 Author

### Kamal Singh Bora

**Senior Software Engineer | .NET | Azure | Microservices**

💼 LinkedIn

⭐ If you like this project, consider giving it a star.
