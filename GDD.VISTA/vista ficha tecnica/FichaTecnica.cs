using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GDD.CONTROL;

namespace GDD.VISTA.vista_ficha_tecnica
{
    public partial class FichaTecnica :Form
    {
        CFichaTecnica cFichaTecnica;
        public FichaTecnica()
        {
            InitializeComponent();
            cFichaTecnica = new CFichaTecnica();

        }

        private void btnCrearFicha_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("userprofile") + "/Desktop/" + txtNombreJuego.Text + ".pdf";
            cFichaTecnica.CrearFicha(obtenerDatos(), path);
        }

        private List<string[]> obtenerDatos()
        {
            string ambiente = txtAmbiente.Text;
            string creadores = txtCreadores.Text;
            string nombreJuego = txtNombreJuego.Text;
            string publicoDirigido = cbxPublico.Text;
            string estilo = "";
            if ( rbtn3D.Checked ) estilo = "3D";
            if ( rbtn2D.Checked ) estilo = "2D";
            if ( rbtnPixelArt.Checked ) estilo = "PixelArt";
            if ( rbtnRealista.Checked ) estilo = "Realista";

            string[] genero = new string[6];
            if ( chbxPlataformas.Checked ) genero[0] = "Plataformas";
            if ( chbxDeportes.Checked ) genero[1] = "Deportes";
            if ( chbxCarreras.Checked ) genero[2] = "Carreras";
            if ( chbxLucha.Checked ) genero[3] = "Lucha";
            if ( chbxEstrategia.Checked ) genero[4] = "Estrategia";
            if ( chbxArcade.Checked ) genero[5] = "Arcade";

            string[] sonido = new string[4];
            if ( chbxRetro.Checked ) sonido[0] = "Retro";
            if ( chbxRealista.Checked ) sonido[1] = "Realista";
            if ( chbxElectronico.Checked ) sonido[2] = "Electronico";
            if ( chbxBanda.Checked ) sonido[3] = "Banda";

            string[] _ = { nombreJuego, ambiente, estilo, publicoDirigido, creadores };
            List<string[]> datos = new List<string[]>();
            datos.Add(_);
            datos.Add(sonido);
            datos.Add(genero);

            return datos;
        }
    }
}
