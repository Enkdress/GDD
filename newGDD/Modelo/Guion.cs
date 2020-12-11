using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Modelo
{
    [Serializable]
    public class Guion
    {
        private string _text;
        public string Text { get => this._text; set => this._text = value; }
    }
}
