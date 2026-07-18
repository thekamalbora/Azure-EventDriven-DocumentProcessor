using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Employee.Functions.Data;

public class ApplicationDbContextFactory
    : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=tcp:docflow-sql-kamal.database.windows.net,1433;Initial Catalog=DocFlowDb;User ID=sqladmin;Password=Kamal&95bora;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}