using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Interfaces
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        string Participation { get; set; }
        string Arquetipo { get; set; }
        string Especie { get; set; }
        string Altura { get; set; }
        string Contextura { get; set; }
        string Resumen { get; set; }
    }
}
