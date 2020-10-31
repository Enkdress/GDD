using System;
using System.Collections.Generic;
using System.Text;
using GDD.MODELO;

namespace GDD.CONTROL
{
    public class CFichaTecnica
    {

        public CFichaTecnica() { }
        public void CrearFicha(List<string[]> datos, string path)
        {
            foreach (string[] arr in datos) {
                if (arr.Length > 0) {
                    Console.Write(arr[0]);
                }
                else {
                    Console.WriteLine("two array pending");
                }
            }
        }
    }
}
