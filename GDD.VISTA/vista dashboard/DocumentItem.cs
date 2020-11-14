using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GDD.VISTA.DashboardItem
{
    public partial class DocumentItem : UserControl
    {
        public DocumentItem()
        {
            InitializeComponent();
        }

        public DocumentItem(string nc, string fc, string nd, string imagen)
        {
            lblCreador.Text = nc;
            lblFechaCreacion.Text = fc;
            lblNombreDocumento.Text = nd;
            imageBox.Image = Image.FromFile(@imagen);
        }
    }
}
