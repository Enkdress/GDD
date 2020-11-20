using System;
using System.Collections.Generic;
using newGDD.Modelo;

namespace newGDD.Interfaces
{
    public interface IDocumentoDeJuego
    { 
        List<Personaje> Personajes { get; set; }
        FichaTecnica FichaTecnica { get; set; }
        Guion Guion { get; set; }
        string Nombre { get; set; }
        string Path { get; set; }
        string FechaCreacion { get; set; }
        string Creadores { get; set; }
        string UrlImagen { get; set; }
    }
}
