using System;
using System.Collections.Generic;
using System.Windows.Forms;
using newGDD.Lib;
using newGDD.Vista.Componentes;

namespace newGDD.Controlador
{
    public class Personaje
    {
        private string docPath;
        private Modelo.DocumentoDeJuego documento;
        private List<Modelo.Personaje> _personajes;
        public List<Modelo.Personaje> Personajes { get => this._personajes; set => this._personajes = value; }

        public Personaje(string docPath)
        {
            this.docPath = docPath;
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
    }
}
