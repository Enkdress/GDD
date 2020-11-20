using newGDD.Lib;
using newGDD.Vista.Componentes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace newGDD.Controlador
{
    public class Dashboard
    {
        public Dashboard()
        {
            
        }

        public Panel AgregarItemDocumento(Panel panel)
        {
            Panel pnlDocumentos = panel;
            try
            {
                pnlDocumentos.Controls.Clear();
                var documentos = Fichero.RetornarDocumentos();
                List<ItemDocumento> items = new List<ItemDocumento>();
                foreach (var doc in documentos)
                {
                    ItemDocumento newPj = new ItemDocumento(doc.Creadores, doc.FechaCreacion, doc.Nombre, doc.UrlImagen);
                    newPj.Location = new System.Drawing.Point((documentos.IndexOf(doc) * (newPj.Width + 20)), 0);
                    items.Add(newPj);
                }

                pnlDocumentos.Controls.AddRange(items.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e, "Error");
            }

            return pnlDocumentos;
        }
    }
}
