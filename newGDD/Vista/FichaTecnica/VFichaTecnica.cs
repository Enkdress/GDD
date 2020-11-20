using System;
using System.Windows.Forms;
using newGDD.Interfaces;

namespace newGDD.Vista.FichaTecnica
{
    public partial class VFichaTecnica : Form
    {
        private Controlador.FichaTecnica cFichaTecnica;

        public VFichaTecnica(IDocumentoDeJuego documento)
        {
            InitializeComponent();
            cFichaTecnica = new Controlador.FichaTecnica();
            // inicializar el valor de los campos del formulario con los que están en el archivo
            txtNombre.Text = documento.FichaTecnica.Nombre;
            txtCreadores.Text = documento.FichaTecnica.Creadores;
            txtAmbientacion.Text = documento.FichaTecnica.Ambientacion;

        }

        public VFichaTecnica()
        {
            InitializeComponent();
            cFichaTecnica = new Controlador.FichaTecnica();
        }

        private void guardar(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            MessageBox.Show(fbd.SelectedPath);
            Lib.ArchivoPDF pdf = new Lib.ArchivoPDF(fbd.SelectedPath);
        }

        private void tlpGuardarPDF_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //cFichaTecnica.CrearFicha(obtenerDatos(), pdfpath);
        }

        //private List<string[]> obtenerDatos()
        //{
        //    string ambiente = txtAmbiente.Text;
        //    //string creadores = txtCreadores.Text;
        //    //string nombreJuego = txtNombreJuego.Text;
        //    //string publicoDirigido = cbxPublico.Text;
        //    //string estilo = "";
        //    //if (rbtn3D.Checked) estilo = "3D";
        //    //if (rbtn2D.Checked) estilo = "2D";
        //    //if (rbtnPixelArt.Checked) estilo = "PixelArt";
        //    //if (rbtnRealista.Checked) estilo = "Realista";

        //    //string[] genero = new string[6];
        //    //if (chbxPlataformas.Checked) genero[0] = "Plataformas";
        //    //if (chbxDeportes.Checked) genero[1] = "Deportes";
        //    //if (chbxCarreras.Checked) genero[2] = "Carreras";
        //    //if (chbxLucha.Checked) genero[3] = "Lucha";
        //    //if (chbxEstrategia.Checked) genero[4] = "Estrategia";
        //    //if (chbxArcade.Checked) genero[5] = "Arcade";

        //    //string[] sonido = new string[4];
        //    //if (chbxRetro.Checked) sonido[0] = "Retro";
        //    //if (chbxRealista.Checked) sonido[1] = "Realista";
        //    //if (chbxElectronico.Checked) sonido[2] = "Electronico";
        //    //if (chbxBanda.Checked) sonido[3] = "Banda";

        //    //string[] _ = { nombreJuego, ambiente, estilo, publicoDirigido, creadores };
        //    //List<string[]> datos = new List<string[]>();
        //    //datos.Add(_);
        //    //datos.Add(sonido);
        //    //datos.Add(genero);

        //    return datos;
        //}
    }
}
