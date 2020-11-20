using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Interfaces
{
    public interface IDocumentoDeJuego
    { 
        Modelo.Personaje[] Personajes { get; set; }
        Modelo.FichaTecnica FichaTecnica { get; set; }
        string Nombre { get; set; }
        string Path { get; set; }
        string FechaCreacion { get; set; }
        string Creadores { get; set; }
        string UrlImagen { get; set; }
    }
}
