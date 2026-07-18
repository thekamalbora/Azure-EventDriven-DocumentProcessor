using Employee.Functions.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Functions.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }


    public DbSet<ResumeDocument> Resumes { get; set; }
}