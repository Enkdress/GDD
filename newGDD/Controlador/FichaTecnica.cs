using System;
using System.Collections.Generic;
using System.Text;
using newGDD.Lib;

namespace newGDD.Controlador
{
    public class FichaTecnica
    {
        private string docPath;
        private Modelo.FichaTecnica mFicha;
        private Modelo.DocumentoDeJuego documento;

        public FichaTecnica()
        {
            mFicha = new Modelo.FichaTecnica();
        }
        public FichaTecnica(string path)
        {
            mFicha = new Modelo.FichaTecnica();
            mFicha.PdfPath = path;
        }
        
        public void CrearFicha(
                string ambientacion,
                string creadores,
                string nombre,
                string publico,
                string estilo,
                string [] genero,
                string [] sonido,
                string path)
        {
            mFicha.Nombre = nombre;
            mFicha.Ambientacion = ambientacion;
            mFicha.Estilo = estilo;
            mFicha.Publico = publico;
            mFicha.Creadores = creadores;
            mFicha.Genero = genero;
            mFicha.Sonidos = sonido;

            mFicha.GuardarPDF(path);    
        }

        public void GuardarFicha(
               string ambientacion,
               string creadores,
               string nombre,
               string publico,
               string estilo,
               string[] genero,
               string[] sonido,
               string path)
        {
            Modelo.FichaTecnica ficha = new Modelo.FichaTecnica();
            ficha.Ambientacion = ambientacion;
            ficha.Creadores =  creadores;
            ficha.Nombre = nombre;
            ficha.Publico = publico;
            ficha.Estilo = estilo;
            ficha.Genero = genero;
            ficha.Sonidos = sonido;
            ficha.PdfPath = path;
        }

    }
}
