using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GDD.MODELO
{
    class MPersonaje
    {
        private string _nombre;
        private string _participacion;
        private string _arquetipo;
        private string _path = Environment.GetEnvironmentVariable("userprofile") + "/Desktop/personajes.txt";
        public MPersonaje(string n, string participacion, string arquetipo)
        {
            this._nombre = n;
            this._participacion = participacion;
            this._arquetipo = arquetipo;
        }
        public StreamWriter LeerArchivo() => File.CreateText(_path);
        public void Guardar()
        {
            StreamWriter sw = LeerArchivo();
            sw.WriteLine(_nombre + "-" + _participacion + "-" + _arquetipo + "\n");
            sw.Close();
        }
        public void Modificar(string param, string valor, string nombrePj)
        {
            StreamReader sr = new StreamReader(_path);
            while (sr.ReadLine() != null)
            {
                string[] attr = sr.ReadLine().Split("-");
                if (attr[0] == nombrePj)
                {
                    if (param == "nombre")
                    {
                        attr[0] = valor;
                    }
                    else if (param == "participacion")
                    {
                        attr[1] = valor;
                    }
                    else if (param == "arquetipo")
                    {
                        attr[2] = valor;
                    }
                }
                
            }
        }
        public void Eliminar()
        {

        }
        public void Mostrar()
        {

        }
    }
}
