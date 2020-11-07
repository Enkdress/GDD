using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;

/// <summary>
/// @author carlos ortigoza, sergio correa
/// </summary>

namespace GDD.MODELO
{
    public class ArchivoPDF
    {
        private String path;
        public ArchivoPDF(string n, String title)
        {
            path = n;
            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            try
            {
                pdf.AddNewPage();
                Paragraph header = new Paragraph(title)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20);

                document.Add(header);
            }
            catch (Exception)
            {
                //normal only pass
            }
            finally
            {
                document.Close();
            }
        }
    }
}
