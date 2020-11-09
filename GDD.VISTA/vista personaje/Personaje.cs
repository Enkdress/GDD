using GDD.CONTROL;
using System.Windows.Forms;

namespace GDD.VISTA.vista_pasajero
{
    public partial class Personaje : Form
    {
        public Personaje()
        {
            InitializeComponent();
            // read the document where the personajes will be saved
            // then creat a PersonajeItem for all of them
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            CPersonaje pj = new CPersonaje();
            pj.GuardadPersonaje();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            CPersonaje pj = new CPersonaje();
            pj.MostrarPersonaje();
        }
    }
}
