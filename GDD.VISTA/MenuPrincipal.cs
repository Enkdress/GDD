using GDD.VISTA.vista_ficha_tecnica;
using System;
using System.Windows.Forms;

namespace GDD.VISTA
{
    public partial class MenuPrincipal :Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirFichaTecnicaForm_Click(object sender, EventArgs e)
        {
            FichaTecnica sf = new FichaTecnica();
            sf.Show();
        }
    }
}
