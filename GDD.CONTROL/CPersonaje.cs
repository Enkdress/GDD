using GDD.MODELO;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace GDD.CONTROL
{
    public class CPersonaje
    {
        IFormatter formatter;

        public CPersonaje()
        {
            formatter = new BinaryFormatter();
        }

        public void GuardadPersonaje()
        {
            // Obtengo los personajes actuales
            MPersonaje[] personajes = (MPersonaje[])MostrarPersonaje();

            // Obtengo la informacion del nuevo personaje
            MPersonaje per = new MPersonaje("pj1", "part", "arqe");

            // Agrego el nuevo personaje a la lista
            personajes[personajes.Length - 1] = per;

            using (Stream fs = new FileStream("./per.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, personajes);
            }

        }
        public void ModificarPersonaje()
        {
            
        }
        public void EliminarPersonaje()
        {

        }
        public MPersonaje[] MostrarPersonaje()
        {
            
            MPersonaje[] pjs = null;
            using (Stream fs = new FileStream("./per.dat", FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    pjs = (MPersonaje[])formatter.Deserialize(fs);
                    foreach (var pj in pjs)
                    {
                        Console.WriteLine(pj.Nombre);
                    }
                }
                catch (Exception)
                {
                    pjs = new MPersonaje[1];
                    Console.WriteLine("Error al serializar. Archivo vacío");
                }
            }
            return pjs;
        }
    }
}
