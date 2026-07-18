namespace Employee.Functions.Models
{
    public class ResumeDocument
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = "";

        public string BlobName { get; set; } = "";

        public string ResumeText { get; set; } = "";

        public DateTime CreatedDate { get; set; }
    }
}
