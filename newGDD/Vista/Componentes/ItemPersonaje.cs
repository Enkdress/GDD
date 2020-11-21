using System.Windows.Forms;

namespace newGDD.Vista.Componentes
{
    public partial class ItemPersonaje : UserControl
    {
        public ItemPersonaje(
            string nombre, 
            string altura, 
            string arquetipo, 
            string contextura,
            string especie,
            string participacion,
            string resumen)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblAltura.Text = altura;
            lblArquetipo.Text = arquetipo;
            lblContextura.Text = contextura;
            lblEspecie.Text = especie;
            lblParticipacion.Text = participacion;
            txtResumen.Text = resumen;
        }
    }
}
