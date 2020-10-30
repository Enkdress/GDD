using System;
using System.IO;
using System.Diagnostics;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

/// <summary>
/// @author carlos ortigoza, sergio correa
/// </summary>

namespace GDD.MODELO
{
    public class ArchivoPDF
    {
        private  String nombre;
        private  Document documento;
        private  PdfDocument pdfDoc;

        public ArchivoPDF(String n) {
            nombre = n;
            documento = new Document(pdfDoc);
        }
        public FileInfo Abrir(string destino) {
            FileInfo file = new FileInfo(destino);
            file.Delete();
            var fileStream = file.Create();
            fileStream.Close();
            return file;//return path para escribir el pdf
        }
        public void addParrafo(string titulo, string[] parrafo, FileInfo file) {
            PdfDocument pdfdoc = new PdfDocument(new PdfWriter(file));
            Document document = new Document(pdfdoc);
            foreach (var para in parrafo) {
                document.Add(new Paragraph(para));
            }
        }
        public void Cerrar() {
            documento.Close();
        }

        public void Mostrar(string ruta) {
            Process.Start(ruta);
        }
    }
}
