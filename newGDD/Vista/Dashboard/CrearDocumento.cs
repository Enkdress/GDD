using System;
using System.Windows.Forms;
using newGDD.Vista.Personaje;
using newGDD.Vista.FichaTecnica;
using newGDD.Vista.Guion;


namespace newGDD.Vista.Dashboard
{
    public partial class CrearDocumento : Form
    {
        private Controlador.DocumentoDeJuego documento;
        private string ubicacionDocumento;
        public CrearDocumento()
        {
            InitializeComponent();
            
        }

        private void nombreDocumento_Load(object sender, EventArgs e) {
            documento = new Controlador.DocumentoDeJuego(textBox1.Text);
            ubicacionDocumento = "./Documentos/" + documento.Documento.Nombre + "/data.dat";
            Lib.Fichero.ModificarArchivo(ubicacionDocumento, documento.Documento);
        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            VFichaTecnica fichaVista = new VFichaTecnica(this.ubicacionDocumento);
            fichaVista.Show();
        }

        private void btnPersonajes_Click(object sender, EventArgs e)
        {
            VPersonaje personajeVista = new VPersonaje(this.ubicacionDocumento);
            personajeVista.Show();
        }

        private void btnGuion_Click(object sender, EventArgs e)
        {
            VGuion guionVista = new VGuion(this.ubicacionDocumento);
            guionVista.Show();
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
