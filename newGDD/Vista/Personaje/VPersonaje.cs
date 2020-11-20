using newGDD.Controlador;
using System.Collections.Generic;
using System.Windows.Forms;

namespace newGDD.Vista.Personaje
{
    public partial class VPersonaje : Form
    {
        private DocumentoDeJuego documento;
        private List<Controlador.Personaje> personajes;
        public VPersonaje()
        {
            InitializeComponent();
        }

        public VPersonaje(DocumentoDeJuego documento)
        {
            this.documento = documento;

            foreach(var personaje in this.personajes)
            {
                // crear itemPersonaje por cada personaje
            }
        }
    }
}
