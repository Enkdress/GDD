using System;
using System.Collections.Generic;
using System.Text;

namespace GDD.MODELO
{
    public class MFichaTecnica
    {
        private string _nombreJuego;
        private string[] _genero;
        private string _ambientacion;
        private string _publico;
        private string _estilo;
        private string[] _sonido;
        private string _creadores;

        #region getter y setter
        public string NombreJuego
        {
            get { return this._nombreJuego; }
            set { this._nombreJuego = value; }
        }
        public string[] Genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }
        public string Ambientacion
        {
            get { return this._ambientacion; }
            set { this._ambientacion = value; }
        }
        public string Publico
        {
            get { return this._publico; }
            set { this._publico = value; }
        }
        public string Estilo
        {
            get { return this._estilo; }
            set { this._estilo = value; }
        }
        public string[] Sonido
        {
            get { return this._sonido; }
            set { this._sonido = value; }
        }
        public string Creadores
        {
            get { return this._creadores; }
            set { this._creadores = value; }
        }
        #endregion

        public void GuardarPDF(string n)
        {
            ArchivoPDF archivoPDF = new ArchivoPDF(n, _nombreJuego);
        }
    }
}
