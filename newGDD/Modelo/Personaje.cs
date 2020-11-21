using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Modelo
{
    [Serializable]
    public class Personaje : Interfaces.IPersonaje
    {
        private string _nombre;
        private string _participacion;
        private string _arquetipo;
        private string _especie;
        private string _altura;
        private string _contextura;
        private string _resumen;

        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public string Participation { get => this._participacion; set => this._participacion = value; }
        public string Arquetipo { get => this._arquetipo; set => this._arquetipo = value; }
        public string Especie { get => this._especie; set => this._especie = value; }
        public string Altura { get => this._altura; set => this._altura = value; }
        public string Contextura { get => this._contextura; set => this._contextura = value; }
        public string Resumen { get => this._resumen; set => this._resumen = value; }

    }
}
