using System;
using System.Collections.Generic;
using System.Text;
using newGDD.Lib;

namespace newGDD.Controlador
{
    
    public class Guion
    {
        private string docPath;
        private Modelo.DocumentoDeJuego documento;
        private Modelo.Guion mGuion;
        public Guion(string path)
        {

            mGuion = new Modelo.Guion();
            docPath = path;
        }

        public void GuardarGuion(string textGuion)
        {
            documento = (Modelo.DocumentoDeJuego)Fichero.LeerArchivo(this.docPath);
            mGuion.Text = textGuion;
            documento.Guion = mGuion;
            Fichero.ModificarArchivo(docPath, this.documento);
        }

        public string cargarGuion()
        {
            documento = (Modelo.DocumentoDeJuego)Fichero.LeerArchivo(this.docPath);
            string datos =  "";
            if (documento.Guion != null)
            {
                datos = documento.Guion.Text; 
            }
            return datos;
        }
    }
}
