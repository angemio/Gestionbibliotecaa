using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionbibliotecaa
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar salida?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txtTelefono.Clear(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtID.Text != "" && txtApellido.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {



                Int64 id = Int64.Parse(txtID.Text);
                String nombre = txtNombre.Text;
                String apellido = txtApellido.Text;
                String email = txtEmail.Text;
                Int64 telefono = Int64.Parse(txtTelefono.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database = biblioteca;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into NewStudent (stid,snombre,sapellido,email,telefono) values ('" + id + "', '" + nombre + "', '" + apellido + "', '" + email + "', '" + telefono + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Datos Guardados.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor llene los campos vacios.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
