using System;
using System.Collections.Generic;
using System.Text;
using GDD.MODELO;

namespace GDD.CONTROL
{
    public class CFichaTecnica
    {
        MFichaTecnica ficha;
        public CFichaTecnica() {
            ficha = new MFichaTecnica();
        }
        public void CrearFicha(List<string[]> datos, string path)
        {
            int i = 0;
            foreach (string[] arr in datos) {
                i = 0;
                if ( i == 0 )
                {
                    // nombreJuego, ambiente, estilo, publicoDirigido, creadores
                    ficha.NombreJuego = arr[0];
                    ficha.Ambientacion = arr[1];
                    ficha.Estilo = arr[2];
                    ficha.Publico = arr[3];
                    ficha.Creadores = arr[4];
                } else if (i == 1)
                {
                    ficha.Genero = arr;
                } else
                {
                    ficha.Sonido = arr;
                }

                ficha.GuardarPDF(path);

                i++;
            }
        }
    }
}
