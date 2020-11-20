using System;
using System.Collections.Generic;
using System.Text;
using newGDD.Lib;

namespace newGDD.Modelo
{
    [Serializable]
    public class FichaTecnica : Interfaces.IFichaTecnica
    {
        private string _nombreJuego;
        private string[] _genero;
        private string _ambientacion;
        private string _publico;
        private string _estilo;
        private string[] _sonido;
        private string _creadores;
        private string _pdfPath;

        public string Nombre { get => this._nombreJuego; set => this._nombreJuego = value; }
        public string[] Genero { get => this._genero; set => this._genero = value; }
        public string Ambientacion { get => this._ambientacion; set => this._ambientacion = value; }
        public string Estilo { get => this._estilo; set => this._estilo = value; }
        public string Publico { get => this._publico; set => this._publico = value; }
        public string[] Sonidos { get => this._sonido; set => this._sonido = value; }
        public string Creadores { get => this._creadores; set => this._creadores = value; }
        public string PdfPath { get => this._pdfPath; set => this._pdfPath = value; }

        public void GuardarPDF(string n)
        {
            ArchivoPDF archivoPDF = new ArchivoPDF(n);
            try
            {
                archivoPDF.addTitle(_nombreJuego);
                archivoPDF.addParrafo("Ambientacion:" + _ambientacion + "\nPublico:" + _publico + "\nEstilo:" + _estilo + "\nCreadores:" + _creadores);
                archivoPDF.addParrafos(_genero);
                //archivoPDF.addParrafos(_sonido);
            }
            catch (Exception)
            {

            }
            finally
            {
                archivoPDF.Cerrar();
            }
        }
    }
}
