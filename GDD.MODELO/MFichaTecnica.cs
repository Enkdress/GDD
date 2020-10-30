using System;
using System.Collections.Generic;
using System.Text;

namespace GDD.MODELO
{
    class MFichaTecnica
    {
        private String _genero;
        private String _ambientacion;
        private String _publico;
        private String _estilo;
        private String _sonido;

        #region getter y setter
        public String Genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }
        public String Ambientacion
        {
            get { return this._ambientacion; }
            set { this._ambientacion = value; }
        }
        public String Publico
        {
            get { return this._publico; }
            set { this._publico = value; }
        }
        public String Estilo
        {
            get { return this._estilo; }
            set { this._estilo = value; }
        }
        public String Sonido
        {
            get { return this._sonido; }
            set { this._sonido = value; }
        }
        #endregion

        public void GuardarPDF()
        {

        }
    }
}
