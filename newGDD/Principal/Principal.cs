using newGDD.Controlador;
using newGDD.Vista.Dashboard;
using System;
using System.Windows.Forms;

namespace newGDD.Principal
{
    public partial class Principal : Form
    {
        private Form vistaLogin;
        public Principal(Form vistaLogin)
        {
            InitializeComponent();
            Dashboard ds = new Dashboard();
            pnlDocumentos = ds.AgregarItemDocumento(pnlDocumentos);
            this.vistaLogin = vistaLogin;
        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            CrearDocumento cd = new CrearDocumento();
            cd.Show();
        }

        private void pnlDocumentos_Enter(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            pnlDocumentos = ds.AgregarItemDocumento(pnlDocumentos);
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.vistaLogin.Close();
        }
    }
}
