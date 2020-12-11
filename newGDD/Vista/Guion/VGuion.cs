using System.Windows.Forms;

namespace newGDD.Vista.Guion
{
    public partial class VGuion : Form
    {
        public VGuion(string path)
        {
            InitializeComponent();
        }

        private void tlpBuscarTexto_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            MessageBox.Show("Buscar");
        }

        private void tlpGuardarGuion_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Guardar Guion");
        }
    }
}
