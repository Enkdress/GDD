using System.Windows.Forms;

namespace newGDD.Vista.Personaje
{
    public partial class VPersonaje : Form
    {
        private Controlador.Personaje controlPersonaje;
        public VPersonaje(string path)
        {
            InitializeComponent();
            controlPersonaje = new Controlador.Personaje(path);
            pnlPersonajesItem = controlPersonaje.AgregarItemPersonaje(pnlPersonajesItem);
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            string participacion = "";
            if (rbtnPrimario.Checked) participacion = rbtnPrimario.Text;
            if (rbtnSecundario.Checked) participacion = rbtnSecundario.Text;
            if (rbtnTerciario.Checked) participacion = rbtnTerciario.Text;

            controlPersonaje.GuardarPersonaje(
                txtNombre.Text, 
                txtContextura.Text, 
                txtEspecie.Text, 
                txtResumen.Text, 
                txtAltura.Text, 
                txtArquetipo.Text, 
                participacion);

            pnlPersonajesItem = controlPersonaje.ActualizarPersonajes(pnlPersonajesItem);
        }

        private void VPersonaje_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
