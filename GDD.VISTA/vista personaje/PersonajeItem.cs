using System.Windows.Forms;

namespace GDD.VISTA.vista_pasajero
{
    public partial class PersonajeItem : UserControl
    {

        public PersonajeItem(string n, string parti, string arque)
        {
            InitializeComponent();
            lblNombre.Text = n;
            lblParticipacion.Text = parti;
            lblArquetipo.Text = arque;
        }
    }
}
