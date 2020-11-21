using System;
using System.Windows.Forms;


namespace newGDD.Vista.Dashboard
{
    public partial class CrearDocumento : Form
    {
        private Controlador.DocumentoDeJuego documento;
        public CrearDocumento()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            documento = new Controlador.DocumentoDeJuego(textBox1.Text);
            
            string ubicacionDocumento = "./Documentos/" + documento.Documento.Nombre + "/data.dat";
            Lib.Fichero.ModificarArchivo(ubicacionDocumento, documento.Documento);
        }
    }
}
