using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Interfaces
{
    public interface IFichaTecnica
    {
        string Nombre { get; set; }
        string[] Genero { get; set; }
        string Ambientacion { get; set; }
        string Estilo { get; set; }
        string Publico { get; set; }
        string[] Sonidos { get; set; }
        string Creadores { get; set; }
        string PdfPath { get; set; }

        void GuardarPDF(string n);
    }
}
