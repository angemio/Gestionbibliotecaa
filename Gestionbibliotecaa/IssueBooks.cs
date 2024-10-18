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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bTitulo from NewBook",con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }


        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (txtID.Text!="")
            {
                String eid = txtID.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where stid= '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //---------------------------------------------------------------------------------------

                //Codigo para contar cuantos libros se le han prestado a este estudiante por su ID
                cmd.CommandText = "select count(std_id) from IRBook where std_id= '" + eid + "'and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //---------------------------------------------------------------------------------------






                if (DS.Tables[0].Rows.Count !=0)
                {
                    txtNombre.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtApellido.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtTelefono.Text = DS.Tables[0].Rows[0][5].ToString();

                }
                else
                {
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtEmail.Clear();
                    txtTelefono.Clear();
                    MessageBox.Show("ID Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text!="")
            {
                if (comboBoxBooks.SelectedIndex != -1&& count<=2)
                {
                    Int64 stid = Int64.Parse(txtID.Text);
                    String sname = txtNombre.Text;
                    String sapellido = txtApellido.Text;
                    String semail = txtEmail.Text;
                    Int64 stelefono = Int64.Parse(txtTelefono.Text);
                    String titulo = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker1.Text;

                    String eid = txtID.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = cmd.CommandText = "insert into IRBook (std_id,std_nombre,std_apellido,std_email,std_telefono,book_name,book_issue_date) values('" + stid + "','" + sname + "','" + sapellido + "','" + semail + "','" + stelefono + "','" + titulo + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Libro prestado.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                 
                else

                {
                    MessageBox.Show("Selecciona un libro, o usted ha alcanzado el limite de libros", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            else
            {
                MessageBox.Show("Introduce un ID valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                txtTelefono.Clear();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres salir?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
             this.Close();
            }
        }
    }
}
