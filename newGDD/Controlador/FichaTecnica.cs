using newGDD.Lib;
using System.Collections.Generic;

namespace newGDD.Controlador
{
    public class FichaTecnica
    {
        private string docPath;
        private Modelo.DocumentoDeJuego documento;
        private Modelo.FichaTecnica mFicha;

        public FichaTecnica(string path)
        {
            mFicha = new Modelo.FichaTecnica();
            docPath = path;
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
            documento = (Modelo.DocumentoDeJuego)Fichero.LeerArchivo(this.docPath);
            mFicha.Ambientacion = ambientacion;
            mFicha.Creadores = creadores;
            mFicha.Nombre = nombre;
            mFicha.Publico = publico;
            mFicha.Estilo = estilo;
            mFicha.Genero = genero;
            mFicha.Sonidos = sonido;
            mFicha.PdfPath = path;

            documento.FichaTecnica = mFicha;
            Fichero.ModificarArchivo(docPath, this.documento);
        }

        public List<string[]> cargarFicha() {
            documento = (Modelo.DocumentoDeJuego)Fichero.LeerArchivo(this.docPath);
            List<string[]> datos = new List<string[]>();
            if (documento.FichaTecnica != null) {
                mFicha = documento.FichaTecnica;
                string[] _ = {
                    documento.FichaTecnica.Nombre,
                    documento.FichaTecnica.Creadores,
                    documento.FichaTecnica.Ambientacion,
                    documento.FichaTecnica.Estilo,
                    documento.FichaTecnica.PdfPath,
                    documento.FichaTecnica.Publico

                };
                datos.Add(_);
                datos.Add(documento.FichaTecnica.Genero);
                datos.Add(documento.FichaTecnica.Sonidos);
            }
            
            return datos;
        }
    }
}
