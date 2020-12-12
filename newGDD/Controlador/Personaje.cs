using System;
using System.Collections.Generic;
using System.Windows.Forms;
using newGDD.Lib;
using newGDD.Vista.Componentes;
using newGDD.Vista.Personaje;

namespace newGDD.Controlador
{
    public class Personaje
    {
        private string docPath;
        private Modelo.DocumentoDeJuego documento;
        private VPersonaje vistaPersonajes;
        private int pjSeleccionado;
        private List<Modelo.Personaje> _personajes;
        public List<Modelo.Personaje> Personajes { get => this._personajes; set => this._personajes = value; }

        public Personaje(string docPath, VPersonaje vistaPersonajes)
        {
            this.docPath = docPath;
            this.vistaPersonajes = vistaPersonajes;
        }

        public FlowLayoutPanel AgregarItemPersonaje(FlowLayoutPanel panel)
        {
            FlowLayoutPanel pnlItemPersonaje = panel;
            try
            {
                pnlItemPersonaje.Controls.Clear();
                documento = (Modelo.DocumentoDeJuego)Fichero.LeerArchivo(this.docPath);
                List<ItemPersonaje> items = new List<ItemPersonaje>();
                this._personajes = documento.Personajes == null ? new List<Modelo.Personaje>() : documento.Personajes;
                if (documento.Personajes != null)
                {
                    foreach (var personaje in documento.Personajes)
                    {
                        ItemPersonaje newPj = new ItemPersonaje(
                            personaje.Nombre,
                            personaje.Altura,
                            personaje.Arquetipo,
                            personaje.Contextura,
                            personaje.Especie,
                            personaje.Participation,
                            personaje.Resumen);

                        newPj.Controls.Find("btnSeleccionar", true)[0].Click += new EventHandler(SeleccionarPersonaje);
                        items.Add(newPj);
                    }

                    pnlItemPersonaje.Controls.AddRange(items.ToArray());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e, "Error");
            }

            return pnlItemPersonaje;
        }

        public FlowLayoutPanel ActualizarPersonajes(FlowLayoutPanel panel)
        {
            Fichero.ModificarArchivo(docPath, this.documento);
            return AgregarItemPersonaje(panel);
        }

        public void GuardarPersonaje(
            string nombre, 
            string contextura, 
            string especie, 
            string resumen, 
            string altura, 
            string arquetipo, 
            string participacion)
        {
            Modelo.Personaje personaje = new Modelo.Personaje();
            personaje.Nombre = nombre;
            personaje.Contextura = contextura;
            personaje.Especie = especie;
            personaje.Resumen = resumen;
            personaje.Altura = altura;
            personaje.Arquetipo = arquetipo;
            personaje.Participation = participacion;

            this._personajes.Add(personaje);
            documento.Personajes = this._personajes;
        }

        public void ModificarPersonaje(
            string nombre,
            string contextura,
            string especie,
            string resumen,
            string altura,
            string arquetipo,
            string participacion)
        {
            Modelo.Personaje personaje = new Modelo.Personaje();
            personaje.Nombre = nombre;
            personaje.Contextura = contextura;
            personaje.Especie = especie;
            personaje.Resumen = resumen;
            personaje.Altura = altura;
            personaje.Arquetipo = arquetipo;
            personaje.Participation = participacion;

            this._personajes[pjSeleccionado] = personaje;
            documento.Personajes = this._personajes;
        }

        public void EliminarPersonaje()
        {
            this._personajes.RemoveAt(pjSeleccionado);
            documento.Personajes = this._personajes;
        }

        public void SeleccionarPersonaje(object sender, EventArgs e)
        {
            var btnSeleccionar = (Button)sender;
            var personaje = (ItemPersonaje)btnSeleccionar.Parent;
            var personajesPanel = this.vistaPersonajes.Controls.Find("pnlPersonajesItem", true)[0];
            this.pjSeleccionado = personajesPanel.Controls.IndexOf(personaje);
            this.vistaPersonajes.txtNombre.Text = personaje.lblNombre.Text;
            this.vistaPersonajes.txtResumen.Text = personaje.txtResumen.Text;
            this.vistaPersonajes.txtEspecie.Text = personaje.lblEspecie.Text;
            this.vistaPersonajes.txtContextura.Text = personaje.lblContextura.Text;
            this.vistaPersonajes.txtArquetipo.Text = personaje.lblArquetipo.Text;
            this.vistaPersonajes.txtAltura.Text = personaje.lblAltura.Text;
            switch (personaje.lblParticipacion.Text)
            {
                case "Primario":
                    this.vistaPersonajes.rbtnPrimario.Checked = true;
                    break;
                case "Secundario":
                    this.vistaPersonajes.rbtnSecundario.Checked = true;
                    break;
                case "Terciario":
                    this.vistaPersonajes.rbtnTerciario.Checked = true;
                    break;
            }
        }
    }
}
