using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace newGDD.Vista.Recursos
{
    public partial class VRecurso : Form
    {
        private string ubicacionDocumento;
        public VRecurso(string ubicacionDocumento)
        {
            InitializeComponent();
            this.ubicacionDocumento = ubicacionDocumento;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("¿El recurso que deseas abrir tiene copyright?", "Abrir recurso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + @"\Recursos\SIN_Copyright");
                    string FolderDefault = Directory.GetCurrentDirectory() + @"\" + this.ubicacionDocumento.Split("/")[1] + @"\" + this.ubicacionDocumento.Split("/")[2]+@"\Recursos\SIN_Copyright\";
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", FolderDefault);
                } catch (Exception)
                {
                    Console.WriteLine("Ya existe la carpeta");
                }
            } else if (response == DialogResult.No)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + @"\Recursos\SIN_Copyright");
                    string FolderDefault = Directory.GetCurrentDirectory() + @"\" + this.ubicacionDocumento.Split("/")[1] + @"\" + this.ubicacionDocumento.Split("/")[2] + @"\Recursos\CON_Copyright\";
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", FolderDefault);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ya existe la carpeta");
                }
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("¿El recurso que deseas abrir tiene copyright?", "Abrir recurso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + "/Recursos/CON_Copyright");
                    string FolderDefault = this.ubicacionDocumento + "/Recursos/CON_Copyright";
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", FolderDefault);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ya existe la carpeta");
                }
            }
            else if (response == DialogResult.No)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + "/Recursos/SIN_Copyright");
                    string FolderDefault = this.ubicacionDocumento + "/Recursos/SIN_Copyright";
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", FolderDefault);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ya existe la carpeta");
                }
            }
        }
    }
}
