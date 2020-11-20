using newGDD.Interfaces;
using System.Windows.Forms;

namespace newGDD.Vista.Personaje
{
    public partial class VPersonaje : Form
    {
        private IDocumentoDeJuego documento;
        private IPersonaje[] personajes;
        public VPersonaje()
        {
            InitializeComponent();
        }

        public VPersonaje(IDocumentoDeJuego documento)
        {
            this.documento = documento;
            this.personajes = this.documento.Personajes;

            foreach(var personaje in this.personajes)
            {
                // crear itemPersonaje por cada personaje
            }
        }
    }
}
