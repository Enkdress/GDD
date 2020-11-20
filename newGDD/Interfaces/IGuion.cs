using System;
using System.Collections.Generic;
using System.Text;

namespace newGDD.Interfaces
{
    public interface IGuion
    {
        string imagen { get; set; }
        string sonido { get; set; }
        IDictionary<int, string> interaccion { get; set; }
    }
}
