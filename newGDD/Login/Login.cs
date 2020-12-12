using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using newGDD.Lib;

namespace newGDD.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string credentials = txtUsuario.Text.Trim() + txtContra.Text.Trim();
            try
            {
                using (Stream fs = new FileStream("./credentials.dat", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    try
                    {
                        IFormatter formatter = new BinaryFormatter();
                        string encrypted = (string)formatter.Deserialize(fs);
                        string decrypted = CifradoCesar.Decipher(encrypted, 3);
                        if (credentials.Equals(decrypted))
                        {
                            this.Hide();
                            new Principal.Principal(this).Show();
                        } else
                        {
                            MessageBox.Show("Los datos no coinciden", "Fallo al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}