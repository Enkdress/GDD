using GDD.CONTROL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GDD.VISTA.vista_pasajero
{
    public partial class Personaje : Form
    {
        private CPersonaje personajeController;
        private string nombre;
        private string participacion;
        private string arquetipo;
        private int pjSeleccionado;

        public Personaje()
        {
            InitializeComponent();
            personajeController = new CPersonaje();
            addNewItem();
        }

        private void addNewItem()
        {
            var pjs = personajeController.ObtenerPersonaje();
            List<PersonajeItem> itemPj = new List<PersonajeItem>();
            pnlPersonajes.Controls.Clear();
            if (itemPj != null)
            {
                foreach (var pj in pjs)
                {
                    PersonajeItem newPj = new PersonajeItem(pj.Nombre, pj.Participacion, pj.Arquetipo);
                    newPj.Location = new System.Drawing.Point((pjs.IndexOf(pj) * (newPj.Width + 20)), 0);
                    newPj.Click += new EventHandler(ModificarPersonaje);
                    itemPj.Add(newPj);
                }
                pnlPersonajes.Controls.AddRange(itemPj.ToArray());
            }
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            getFormValues();
            personajeController.GuardadPersonaje(nombre, participacion, arquetipo);
            addNewItem();
            clearForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            getFormValues();
            personajeController.ModificarPersonaje(nombre, participacion, arquetipo, pjSeleccionado);
            addNewItem();
            clearForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            personajeController.EliminarPersonaje(pjSeleccionado);
            addNewItem();
            clearForm();
        }

        private void ModificarPersonaje(object sender, EventArgs e)
        {
            // cambiar los valores de los inputs
            int pjIndex = pnlPersonajes.Controls.IndexOf((PersonajeItem)sender);
            pjSeleccionado = pjIndex;

            var pjs = personajeController.ObtenerPersonaje();
            var pjSelected = pjs[pjIndex];
            txtNombre.Text = pjSelected.Nombre;
            cbxArquetipo.Text = pjSelected.Arquetipo;
            if (pjSelected.Participacion == "Primario") rbtnPrimary.Checked = true;
            if (pjSelected.Participacion == "Secundario") rbtnSecondary.Checked = true;
            if (pjSelected.Participacion == "Terceario") rbtnTernary.Checked = true;
        }

        private void getFormValues()
        {
            nombre = txtNombre.Text;
            if (rbtnPrimary.Checked) participacion = rbtnPrimary.Text;
            if (rbtnSecondary.Checked) participacion = rbtnSecondary.Text;
            if (rbtnTernary.Checked) participacion = rbtnTernary.Text;
            arquetipo = cbxArquetipo.Text;
        }

        private void clearForm()
        {
            txtNombre.Text = "";
            rbtnPrimary.Checked = true;
            cbxArquetipo.Text = "";
        }
    }
}
