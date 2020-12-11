using System;
using System.Windows.Forms;

namespace newGDD.Vista.Guion
{
    public partial class VGuion : Form
    {
        public VGuion(string path)
        {
            InitializeComponent();
        }

        private void BuscarTexto() {
            MessageBox.Show("Buscar  "+ richTextBox1.Text);
        }

        private void GuardarGuion()
        {
            MessageBox.Show("Guardar Guion   " + richTextBox1.Text);
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
