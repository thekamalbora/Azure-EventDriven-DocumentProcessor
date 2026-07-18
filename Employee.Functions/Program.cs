using Employee.Functions.Data;
using Employee.Functions.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()

    .ConfigureServices((context, services) =>
    {
        var configuration = context.Configuration;

        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();


        services.AddDbContext<ApplicationDbContext>(
            options =>
            options.UseSqlServer(
                configuration["SqlConnection"]));


        services.AddSingleton<BlobStorageService>();
        services.AddSingleton<PdfReaderService>();
        services.AddScoped<ResumeRepository>();
        services.AddSingleton<DocumentProcessingService>();
    })

    .Build();


host.Run();