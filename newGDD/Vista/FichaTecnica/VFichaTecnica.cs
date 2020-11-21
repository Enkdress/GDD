using System;
using System.Collections.Generic;
using System.Windows.Forms;
using newGDD.Interfaces;

namespace newGDD.Vista.FichaTecnica
{
    public partial class VFichaTecnica : Form
    {
        private Controlador.FichaTecnica cFichaTecnica;
        private List<string[]> fichaCargada;
        private string pathDocument;

        public VFichaTecnica(string path)
        {
            pathDocument = path;
            InitializeComponent();
            cFichaTecnica = new Controlador.FichaTecnica(path);
            fichaCargada = cFichaTecnica.cargarFicha();
            if (fichaCargada.Count != 0) {
                txtNombre.Text = fichaCargada[0][0];
                txtCreadores.Text = fichaCargada[0][1];
                txtAmbientacion.Text = fichaCargada[0][2];
            }
        }

        private void tlpGuardarPDF_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string folderDefault = pathDocument.Split("/")[0] + "/" + pathDocument.Split("/")[1] + "/" + pathDocument.Split("/")[2] + "/";
            string path = folderDefault + txtNombre.Text + ".pdf";
            string estilo = "";
            if (rd3d.Checked) estilo = "3D";
            if (rd2d.Checked) estilo = "2D";
            if (rdPixelart.Checked) estilo = "PixelArt";
            if (rdRealista.Checked) estilo = "Realista";

            string[] genero = new string[6];
            if (chbxPlataformas.Checked) genero[0] = "Plataformas";
            if (chbxDeportes.Checked) genero[1] = "Deportes";
            if (chbxCarreras.Checked) genero[2] = "Carreras";
            if (chbxLucha.Checked) genero[3] = "Lucha";
            if (chbxEstrategia.Checked) genero[4] = "Estrategia";
            if (chbxArcade.Checked) genero[5] = "Arcade";

            string[] sonido = new string[4];
            if (chxRetiro.Checked) sonido[0] = "Retro";
            if (chxRealista.Checked) sonido[1] = "Realista";
            if (chxElectronico.Checked) sonido[2] = "Electronico";
            if (chxBanda.Checked) sonido[3] = "Banda";

            cFichaTecnica.CrearFicha(
                txtAmbientacion.Text,
                txtCreadores.Text,
                txtNombre.Text,
                txtPublico.Text,
                estilo,
                genero,
                sonido, 
                path);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string estilo = "";
            if (rd3d.Checked) estilo = "3D";
            if (rd2d.Checked) estilo = "2D";
            if (rdPixelart.Checked) estilo = "PixelArt";
            if (rdRealista.Checked) estilo = "Realista";

            string[] genero = new string[6];
            if (chbxPlataformas.Checked) genero[0] = "Plataformas";
            if (chbxDeportes.Checked) genero[1] = "Deportes";
            if (chbxCarreras.Checked) genero[2] = "Carreras";
            if (chbxLucha.Checked) genero[3] = "Lucha";
            if (chbxEstrategia.Checked) genero[4] = "Estrategia";
            if (chbxArcade.Checked) genero[5] = "Arcade";

            string[] sonido = new string[4];
            if (chxRetiro.Checked) sonido[0] = "Retro";
            if (chxRealista.Checked) sonido[1] = "Realista";
            if (chxElectronico.Checked) sonido[2] = "Electronico";
            if (chxBanda.Checked) sonido[3] = "Banda";

            cFichaTecnica.GuardarFicha(
                txtAmbientacion.Text,
                txtCreadores.Text,
                txtNombre.Text,
                txtPublico.Text,
                estilo,
                genero,
                sonido,
                pathDocument);
        }
    }
}
