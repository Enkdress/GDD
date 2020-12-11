using System;
using System.Drawing;
using System.Windows.Forms;
using newGDD.Controlador;
using newGDD.Vista.Personaje;
using newGDD.Vista.FichaTecnica;
using newGDD.Vista.Guion;
using System.IO;

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

        private void lnkRecursos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string FolderDefault = Directory.GetCurrentDirectory() + @"\"+ this.documentPath.Split("/")[1] + @"\" + this.documentPath.Split("/")[2];
            System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", FolderDefault);
        }

        private void btnGuion_Click(object sender, EventArgs e)
        {
            VGuion guionVista = new VGuion(this.documentPath);
            guionVista.Show();
        }
    }
}
