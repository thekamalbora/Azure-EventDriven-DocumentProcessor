using UglyToad.PdfPig;
using System.IO;
namespace Employee.Functions.Services;

public class PdfReaderService
{
    public string Read(Stream stream)
    {
        using var document = PdfDocument.Open(stream);

        var text = "";

        foreach (var page in document.GetPages())
        {
            text += page.Text;
        }

        return text;
    }
}