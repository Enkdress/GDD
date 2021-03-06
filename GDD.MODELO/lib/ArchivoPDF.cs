﻿using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

/// <summary>
/// @author carlos ortigoza, sergio correa
/// </summary>

namespace GDD.MODELO
{
    public class ArchivoPDF
    {
        private Document documento;
        private PdfWriter escribir;
        private PdfDocument pdf;
        public ArchivoPDF(string n)
        {
            escribir = new PdfWriter(n);
            pdf = new PdfDocument(escribir);
            documento = new Document(pdf);
            pdf.AddNewPage();
        }

        public void addTitle(string titulo) {
            Paragraph PDFtitulo = new Paragraph(titulo)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(22);
            documento.Add(PDFtitulo);
        }
        
        public void addParrafo(string parrafo)
        {
            pdf.AddNewPage();
            Paragraph PDFParrafo = new Paragraph(parrafo)
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(20);
            documento.Add(PDFParrafo);
        }

        public void addParrafos(string[] parrafos) {
            pdf.SetTagged();
            foreach (var parrafo in parrafos) {
                documento.Add(new Paragraph(parrafo));
            }
        }
        public void Cerrar()
        {
            documento.Close();
        }
    }
}
