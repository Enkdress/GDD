using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Controlador
{
    public class DocumentoDeJuego
    {
        private Modelo.DocumentoDeJuego documento;
        public Modelo.DocumentoDeJuego Documento { get => this.documento; }

        public DocumentoDeJuego(string n)
        {
            documento = new Modelo.DocumentoDeJuego
            {
                Nombre = n
            };
        }

    }
}
