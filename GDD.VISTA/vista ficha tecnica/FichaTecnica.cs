using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GDD.CONTROL;

namespace GDD.VISTA.vista_ficha_tecnica
{
    public partial class FichaTecnica :Form
    {
        public FichaTecnica()
        {
            InitializeComponent();
        }

        private void btnCrearFicha_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("userprofile") + "/Desktop";
            
        }

        private List<string[]> obtenerDatos()
        {
            string ambiente = txtAmbiente.Text;
            string creadores = txtCreadores.Text;
            string nombreJuego = txtNombreJuego.Text;
            string publicoDirigido = cbxPublico.Text;
            string creador = txtCreadores.Text;

            string estilo = "";
            if ( rbtn3D.Checked ) estilo = "3D";
            else if ( rbtn2D.Checked ) estilo = "2D";
            else if ( rbtnPixelArt.Checked ) estilo = "PixelArt";
            else if ( rbtnRealista.Checked ) estilo = "Realista";

            string[] genero = { };
            if ( chbxPlataformas.Checked ) genero.Append<string>("Plataformas");
            else if ( chbxDeportes.Checked ) genero.Append<string>("Deportes");
            else if ( chbxCarreras.Checked ) genero.Append<string>("Carreras");
            else if ( chbxLucha.Checked ) genero.Append<string>("Lucha");
            else if ( chbxEstrategia.Checked ) genero.Append<string>("Estrategia");
            else if ( chbxArcade.Checked ) genero.Append<string>("Arcade");

            string[] sonido = { };
            if ( chbxRetro.Checked ) sonido.Append<string>("Retro");
            else if ( chbxRealista.Checked ) sonido.Append<string>("Realista");
            else if ( chbxElectronico.Checked ) sonido.Append<string>("Electronico");
            else if ( chbxBanda.Checked ) sonido.Append<string>("Banda");

            string[] _ = { ambiente, creadores, nombreJuego, estilo, publicoDirigido, creador };
            List<string[]> datos = new List<string[]>();
            datos.Add(_);
            datos.Add(sonido);
            datos.Add(genero);

            return datos;
        }
    }
}
