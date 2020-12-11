using System;
using System.Windows.Forms;

namespace newGDD.Vista.Guion
{
    public partial class VGuion : Form
    {
        private Controlador.Guion cGuion;
        public VGuion(string path)
        {
            InitializeComponent();
            cGuion = new Controlador.Guion(path);
            String guionText = cGuion.cargarGuion();
            if ( guionText != "") {
                richTextBox1.Text = cGuion.cargarGuion();
            }
        }

        private void BuscarTexto() {
            MessageBox.Show("Buscar  "+ richTextBox1.Text);
        }

        private void GuardarGuion()
        {
            cGuion.GuardarGuion(richTextBox1.Text);
            MessageBox.Show("Guion Guardado");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tlpGuardarGuion") {
                this.GuardarGuion();
            } else if (e.ClickedItem.Name == "tlpBuscarTexto") {
                this.BuscarTexto();
            }
        }
    }
}
