using newGDD.Interfaces;
using System;
using System.Collections.Generic;

namespace newGDD.Modelo
{
    [Serializable]
    public class DocumentoDeJuego : IDocumentoDeJuego
    {
        private string _nombre;
        private string _path;
        private string _fechaCreacion;
        private string _urlImagen;
        private string _creadores;
        private List<Personaje> _personajes;
        private Guion _guion;
        private FichaTecnica _fichaTecnica;

        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public string Path { get => this._path; set => this._path = value; }
        public string FechaCreacion { get => this._fechaCreacion; set => this._fechaCreacion = value; }
        public string Creadores { get => this._creadores; set => this._creadores = value; }
        public string UrlImagen { get => this._urlImagen; set => this._urlImagen = value; }
        public List<Personaje> Personajes { get => this._personajes; set => this._personajes = value; }
        public FichaTecnica FichaTecnica { get => this._fichaTecnica; set => this._fichaTecnica = value; }
        public Guion Guion { get => this._guion; set => this._guion = value; }
    }
}
