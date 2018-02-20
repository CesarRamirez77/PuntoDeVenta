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
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-KFD5R0EP//SQLEXPRESS;Initial Catalog=PuntoDeVenta;Integrated Security = True;");
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

        public void Logear(String pUsuario, String pContraseña)
        {
            try
            {

                con.Open();
                SqlCommand Cmd = new SqlCommand("Select Usuario from Usuarios where Usuario = @Usuario AND Contraseña =@Contraseña", con);

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
            Logear(txtUser.Text, txtContra.Text);
        }
    }
        
    }

