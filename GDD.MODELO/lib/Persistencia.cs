using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GDD.MODELO.lib
{
    public class Persistencia
    {
        private string _carpeta;
        private string _nombreArchivo;
        private StreamReader entrada;
        private StreamWriter salida;

        public Persistencia(string car, string na)
        {
            this._carpeta = car;
            this._nombreArchivo = na;
        }

        public void AbrirEscritura()
        {
            try
            {
                salida = new StreamWriter(_carpeta + _nombreArchivo);
            }
            catch (Exception)
            {
                Console.WriteLine("Error al abrir el archivo");
            }
        }
        public void CerrarEscritura()
        {
            try
            {
                salida.Close();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void AbrirLectura()
        {
            try
            {
                entrada = new StreamReader(_carpeta + _nombreArchivo);
            }
            catch (Exception)
            {
                Console.WriteLine("Error al abrir el archivo");
            }
        }

        public void CerrarLectura()
        {
            try
            {
                entrada.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Guardar(Object x)
        {
            try
            {
                salida.Write(x);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al guardar: "+ e);
            }
        }

        public Object Cargar()
        {
            Object result = null;

            try
            {
                result = entrada.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al cargar: " + e);
            }

            return result;
        }

        public bool Existe()
        {
            try
            {
                entrada = new StreamReader(_carpeta + _nombreArchivo);
                entrada.Close();
                return true;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("El archivo ya existe: " + e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Cierre el archivo: " + e);
            }

            return false;
        }
    }
}
