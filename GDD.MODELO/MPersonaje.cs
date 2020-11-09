using System;

namespace GDD.MODELO
{
    [Serializable]
    public class MPersonaje
    {
        private string _nombre;
        private string _participacion;
        private string _arquetipo;

        public string Nombre
        {
            get => _nombre;
        }
        public string Participacion
        {
            get => _participacion;
        }
        public string Arquetipo
        {
            get => _arquetipo;
        }

        public MPersonaje(string n, string participacion, string arquetipo)
        {
            this._nombre = n;
            this._participacion = participacion;
            this._arquetipo = arquetipo;
        }
    }
}
