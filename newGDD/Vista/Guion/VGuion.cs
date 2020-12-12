using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            string palabra = "hola";
            string remplazar = "aqui cambios";
            remplazarPalabra(richTextBox1, palabra, remplazar);
            buscarPalabra(richTextBox1, "hola");
        }

        private void GuardarGuion()
        {
            cGuion.GuardarGuion(richTextBox1.Text);
            MessageBox.Show("Guion Guardado");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Name);
            if (e.ClickedItem.Name == "tlpGuardarGuion") {
                this.GuardarGuion();
            } else if (e.ClickedItem.Name == "tlpBuscarTexto") {
                this.BuscarTexto();
            }
        }

        public void remplazarPalabra(RichTextBox richTextBox1, string palabra, string remplaza)
        {
            int i = 0;
            int n = 0;
            int a = remplaza.Length - palabra.Length;
            foreach (Match m in Regex.Matches(richTextBox1.Text, palabra))
            {
                richTextBox1.Select(m.Index + i, palabra.Length);
                i += a;
                richTextBox1.SelectedText = remplaza;
                n++;
            }
            MessageBox.Show("Se remplazo " + n + " coincidencias!");
        }

        public void buscarPalabra(RichTextBox myRtb, string palabra) 
        {
            int i = 0;
            int n = 0;
            int a = 0;
            foreach (Match m in Regex.Matches(myRtb.Text, palabra))
            {
                myRtb.Select(m.Index + i, palabra.Length);
                i += a;
                n++;
            }
            MessageBox.Show("Encontrado " + n + " coincidencias!");
        }
    }
}