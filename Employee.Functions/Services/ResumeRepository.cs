using Employee.Functions.Data;
using Employee.Functions.Models;

namespace Employee.Functions.Services;

public class ResumeRepository
{
    private readonly ApplicationDbContext _context;


    public ResumeRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task SaveAsync(
        ResumeDocument resume)
    {
        _context.Resumes.Add(resume);

        await _context.SaveChangesAsync();
    }
}