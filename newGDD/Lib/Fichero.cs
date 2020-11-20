using newGDD.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace newGDD.Lib
{
    public static class Fichero
    {
        static IFormatter formatter = new BinaryFormatter();

        // 
        // Resumen: 
        //    Lee un archivo que se encuentra en una ruta
        //
        // Parámetros: 
        //    path:
        //      string de la ruta donde se encuentra el archivo a leer
        //
        // Devuelve:
        //    Una lista con los objetos que se encuentran en el archivo
        //
        public static List<T> LeerArchivo<T>(string path)
        {
            List<T> objects = new List<T>();
            using (Stream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                try
                {
                    objects = (List<T>)formatter.Deserialize(fs);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al serializar. Archivo vacío");
                }
            }
            return objects;
        }

        public static List<DocumentoDeJuego> RetornarDocumentos()
        {
            List<DocumentoDeJuego> gdds = new List<DocumentoDeJuego>();
            try
            {
                var files = Directory.GetFiles("./Documentos", "*.dat*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    using (Stream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        try
                        {
                            gdds.Add((DocumentoDeJuego)formatter.Deserialize(fs));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error al serializar. Archivo vacío");
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException notFound)
            {
                Console.WriteLine(notFound.Message);
                Directory.CreateDirectory("./Documentos");
            }
            
            return gdds;
        }

        // ./Documentos/nombregdd/data.dat
        // Resumen: 
        //    Modifica un archivo que se encuentra en una ruta
        //
        // Parámetros: 
        //    path:
        //      string de la ruta donde se encuentra el archivo a leer
        //    objects:
        //      lista con el archivo a sobre escribir
        //
        public static void  ModificarArchivo(string path, object item )
        {
            try
            {
                if (Directory.Exists(path.Split("/")[0] + "/" + path.Split("/")[1] + "/" + path.Split("/")[2]))
                {
                    using (Stream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        formatter.Serialize(fs, item);
                    }
                } else
                {
                    Directory.CreateDirectory(path.Split("/")[0] + "/" + path.Split("/")[1] + "/" + path.Split("/")[2]);
                    using (Stream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        formatter.Serialize(fs, item);
                    }
                }
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }
        }
    }
}
