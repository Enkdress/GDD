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
            if (response == DialogResult.No)
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
            } else if (response == DialogResult.Yes)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + @"\Recursos\CON_Copyright");
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
            var response = MessageBox.Show("¿El recurso que vas a añadir tiene derechos de autor?", "Añadir recurso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (response == DialogResult.No)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + @"\Recursos\SIN_Copyright");
                    OpenFileDialog saveDialog = new OpenFileDialog();
                    saveDialog.ShowDialog();
                    if (saveDialog.FileName != "")
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/C copy /b \"" + saveDialog.FileName + "\" \"" + Directory.GetCurrentDirectory() + @"\" + this.ubicacionDocumento.Split("/")[1] + @"\" + this.ubicacionDocumento.Split("/")[2] + @"\Recursos\SIN_Copyright\" + "\"";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("No seleccionaste ningun archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Ya existe la carpeta");
                }
            }
            else if (response == DialogResult.Yes)
            {
                try
                {
                    Directory.CreateDirectory(this.ubicacionDocumento + @"\Recursos\CON_Copyright");
                    OpenFileDialog saveDialog = new OpenFileDialog();
                    saveDialog.ShowDialog();
                    if (saveDialog.FileName != "")
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/C copy /b \"" + saveDialog.FileName + "\" \"" + Directory.GetCurrentDirectory() + @"\" + this.ubicacionDocumento.Split("/")[1] + @"\" + this.ubicacionDocumento.Split("/")[2] + @"\Recursos\CON_Copyright\" + "\"";
                        MessageBox.Show("/C copy /b \"" + saveDialog.FileName + "\" \"" + Directory.GetCurrentDirectory() + @"\" + this.ubicacionDocumento.Split("/")[1] + @"\" + this.ubicacionDocumento.Split("/")[2] + @"\Recursos\CON_Copyright\" + "\"");
                        process.StartInfo = startInfo;
                        process.Start();
                    } 
                    else
                    {
                        MessageBox.Show("No seleccionaste ningun archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Ya existe la carpeta");
                }
            }
        }
    }
}
