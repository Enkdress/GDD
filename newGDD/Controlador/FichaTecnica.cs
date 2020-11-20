using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Controlador
{
    public class FichaTecnica
    {
        private Modelo.FichaTecnica mFicha;
        public FichaTecnica()
        {
            mFicha = new Modelo.FichaTecnica();
        }
        public FichaTecnica(string path)
        {
            mFicha = new Modelo.FichaTecnica();
            mFicha.PdfPath = path;
        }
        public void CrearFicha(List<string[]> datos, string path)
        {
            int i = 0;
            foreach (string[] arr in datos)
            {
                if (i == 0)
                {
                    mFicha.Nombre = arr[0];
                    mFicha.Ambientacion = arr[1];
                    mFicha.Estilo = arr[2];
                    mFicha.Publico = arr[3];
                    mFicha.Creadores = arr[4];
                }
                else if (i == 1)
                {
                    mFicha.Genero = arr;
                }
                else
                {
                    mFicha.Sonidos = arr;
                }



                i++;
            }
            mFicha.GuardarPDF(path);
        }

    }
}
