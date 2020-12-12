using System.Windows.Forms;

namespace newGDD.Vista.Personaje
{
    public partial class VPersonaje : Form
    {
        private Controlador.Personaje controlPersonaje;
        public VPersonaje(string path)
        {
            InitializeComponent();
            controlPersonaje = new Controlador.Personaje(path, this);
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
            limpiarCampos();
            pnlPersonajesItem = controlPersonaje.ActualizarPersonajes(pnlPersonajesItem);
        }


        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            string participacion = "";
            if (rbtnPrimario.Checked) participacion = rbtnPrimario.Text;
            if (rbtnSecundario.Checked) participacion = rbtnSecundario.Text;
            if (rbtnTerciario.Checked) participacion = rbtnTerciario.Text;

            controlPersonaje.ModificarPersonaje(
                txtNombre.Text,
                txtContextura.Text,
                txtEspecie.Text,
                txtResumen.Text,
                txtAltura.Text,
                txtArquetipo.Text,
                participacion);
            limpiarCampos();
            pnlPersonajesItem = controlPersonaje.ActualizarPersonajes(pnlPersonajesItem);
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            controlPersonaje.EliminarPersonaje();
            limpiarCampos();
            pnlPersonajesItem = controlPersonaje.ActualizarPersonajes(pnlPersonajesItem);
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtContextura.Text = "";
            txtEspecie.Text = "";
            txtResumen.Text = "";
            txtAltura.Text = "";
            txtArquetipo.Text = "";
            rbtnPrimario.Checked = false;
            rbtnSecundario.Checked = false;
            rbtnTerciario.Checked = false;

        }

    }
}
