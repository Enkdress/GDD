using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GDD.MODELO
{
    [Serializable]
    public class MPersonaje
    {
        private string _nombre;
        private string _participacion;
        private string _arquetipo;
        private string _path = "./per.dat";

        public string Nombre
        {
            get => _nombre;
        }

        public MPersonaje(string n, string participacion, string arquetipo)
        {
            this._nombre = n;
            this._participacion = participacion;
            this._arquetipo = arquetipo;
        }
        public void Guardar()
        {

        }
        public void Modificar(string param, string valor, string nombrePj)
        {

        }
        public void Eliminar(string valor, string nombrePj)
        {

        }
        public void Mostrar()
        {

        }
    }
}
