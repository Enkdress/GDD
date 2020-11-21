using System;
using System.Drawing;
using System.Windows.Forms;
using newGDD.Controlador;
using newGDD.Vista.Personaje;
using newGDD.Vista.FichaTecnica;

namespace newGDD.Vista.Componentes
{
    public partial class ItemDocumento : UserControl
    {
        private string documentPath;

        public ItemDocumento()
        {
            InitializeComponent();
        }

        public ItemDocumento(string nc, string fc, string nd, string imagen)
        {
            InitializeComponent();
            //lblCreadores.Text = nc;
            //lblFechaCreacion.Text = fc;
            lblNombreDoc.Text = nd;
            //imgDoc.Image = Image.FromFile(@imagen);
            this.documentPath = "./Documentos/"+nd+"/data.dat";
        }

        private void btnFichaTecnica_Click(object sender, System.EventArgs e)
        {
            VFichaTecnica fichaVista = new VFichaTecnica(this.documentPath);
            fichaVista.Show();
        }

        private void btnPersonajes_Click(object sender, System.EventArgs e)
        {
            VPersonaje personajeVista = new VPersonaje(this.documentPath);
            personajeVista.Show();
        }
    }
}
