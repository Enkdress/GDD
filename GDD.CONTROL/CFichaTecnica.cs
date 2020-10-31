using System;
using System.Collections.Generic;
using System.Text;
using GDD.MODELO;

namespace GDD.CONTROL
{
    class CFichaTecnica
    {
        public void CrearFicha(List<string[]> datos, string path)
        {
            foreach(string[] arr in datos)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
