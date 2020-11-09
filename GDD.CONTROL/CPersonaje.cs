using GDD.MODELO;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GDD.CONTROL
{
    public class CPersonaje
    {
        IFormatter formatter;

        public CPersonaje()
        {
            formatter = new BinaryFormatter();
        }

        public void GuardadPersonaje(string n, string parti, string arque)
        {
            // Obtengo los personajes actuales
            List<MPersonaje> personajes = ObtenerPersonaje();

            // Obtengo la informacion del nuevo personaje
            MPersonaje per = new MPersonaje(n, parti, arque);

            // Agrego el nuevo personaje a la lista
            personajes.Add(per);

            using (Stream fs = new FileStream("./per.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, personajes);
            }

        }
        public void ModificarPersonaje(string n, string parti, string arque, int idx)
        {
            // Obtengo la lista de los personajes
            List<MPersonaje> personajes = ObtenerPersonaje();

            // Obtengo la informacion del personaje personaje modificado
            MPersonaje per = new MPersonaje(n, parti, arque);

            // Modifico el personaje que se editó
            personajes[idx] = per;

            using (Stream fs = new FileStream("./per.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, personajes);
            }
        }
        public void EliminarPersonaje(int idx)
        {
            // Obtengo la lista de los personajes
            List<MPersonaje> personajes = ObtenerPersonaje();

            // Modifico el personaje que se editó
            personajes.RemoveAt(idx);

            using (Stream fs = new FileStream("./per.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, personajes);
            }
        }
        public List<MPersonaje> ObtenerPersonaje()
        {

            List<MPersonaje> pjs = new List<MPersonaje>();
            using (Stream fs = new FileStream("./per.dat", FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    pjs = (List<MPersonaje>)formatter.Deserialize(fs);
                    foreach (var pj in pjs)
                    {
                        Console.WriteLine(pj.Nombre);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al serializar. Archivo vacío");
                }
            }
            return pjs;
        }
    }
}
