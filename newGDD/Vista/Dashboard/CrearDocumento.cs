using newGDD.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace newGDD.Vista.Dashboard
{
    public partial class CrearDocumento : Form
    {
        private Controlador.DocumentoDeJuego documento;
        public CrearDocumento()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            documento = new Controlador.DocumentoDeJuego(textBox1.Text);
            
            string ubicacionDocumento = "./Documentos/" + documento.Documento.Nombre + "/data.dat";
            Lib.Fichero.ModificarArchivo(ubicacionDocumento, documento.Documento);
            //textBox1
            //button1
            // ./Documentos/`nombre`/data.dat
            // Controlador: pasarle los atributos {nombre}{personajes}{ficha}
            // Controlador: retornar un objeto del modelo DocumentoDeJuego
            // Fichero: pasarle ese objeto y serializarlo en el archivo
        }
    }
}
