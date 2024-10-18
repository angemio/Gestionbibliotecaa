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
using System.Configuration;

namespace Gestionbibliotecaa
{
    
    public partial class Form1 : Form
    {
        string connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Clear();
            }
        }

        private void txtContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Clear();
                txtContraseña.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DASHF15\\SQLEXPRESS01 ; database=biblioteca;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

           
            cmd.CommandText = "select * from loginTable where usuario ='" + txtUsuario.Text + "' and pass ='" + txtContraseña.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
