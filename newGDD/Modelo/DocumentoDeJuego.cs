using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Modelo
{
    [Serializable]
    public class DocumentoDeJuego
    {
        private string nombre;
        private List<Personaje> Personajes;
        private Guion Guion;
        private FichaTecnica FichaTecnica;
    }
}
