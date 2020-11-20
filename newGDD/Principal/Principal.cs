using newGDD.Lib;
using newGDD.Vista.Componentes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace newGDD.Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            try
            {
                pnlDocumentos.Controls.Clear();
                  var documentos = Fichero.RetornarDocumentos();
                List<ItemDocumento> items = new List<ItemDocumento>();
                foreach(var doc in documentos)
                {
                    ItemDocumento newPj = new ItemDocumento(doc);
                    newPj.Location = new System.Drawing.Point((documentos.IndexOf(doc) * (newPj.Height + 20)), 0);
                    items.Add(newPj);
                }

                pnlDocumentos.Controls.AddRange(items.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e, "Error");
                throw;
            }
        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
