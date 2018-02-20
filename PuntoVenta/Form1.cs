using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoVenta
{
    
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-KFD5R0EP;Initial Catalog=PuntoDeVenta; Persist Security Info=True;User ID=Administrador;Password=123");
        public Form1()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Loguear(String pUsuario, String pContraseña)
        {
            try
            {

                con.Open();
                SqlCommand Cmd = new SqlCommand("Select Usuarios from Login where Usuarios =@Usuario AND  Contraseña= @Contraseña", con);

                Cmd.Parameters.AddWithValue("Usuario", pUsuario);
                Cmd.Parameters.AddWithValue("Contraseña", pContraseña);
                SqlDataAdapter SDA = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                SDA.Fill(DT);

                if (DT.Rows.Count == 1)
                {
                    MessageBox.Show("Sesion Iniciada", "Inicio de Sesion", MessageBoxButtons.OK);
                    this.Hide();
                    Ventas Mn = new Ventas();
                    Mn.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos", "Error en Inicio de Sesion", MessageBoxButtons.OK);
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Ha ocurrido este error: " + Error.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            Loguear(txtUser.Text, txtContra.Text);
        }
      }
    }
        
    

