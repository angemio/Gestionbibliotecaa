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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestionbibliotecaa
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01;database = biblioteca;integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01;database = biblioteca;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where stid LIKE '" + txtSearchID.Text + "%' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01;database = biblioteca;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }

        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01;database = biblioteca;integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where stuid = "+bid+"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtID.Text = DS.Tables[0].Rows[0][1].ToString();
            txtNombre.Text = DS.Tables[0].Rows[0][2].ToString();
            txtApellido.Text = DS.Tables[0].Rows[0][3].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][4].ToString();
            txtTelefono.Text = DS.Tables[0].Rows[0][5].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 stid = Int64.Parse(txtID.Text);
            String snombre = txtNombre.Text;
            String sapellido = txtApellido.Text;
            String email = txtEmail.Text;
            Int64 telefono = Int64.Parse(txtTelefono.Text);

            if (MessageBox.Show("Los datos seran actualizados. Confirmar?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01;database = biblioteca;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set stid ='" + stid + "',snombre = '" + snombre + "',sapellido ='" + sapellido + "',email= '" + email + "',telefono= '" + telefono + "' where stuid = " + rowid + " ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Los datos seran eliminados. Confirmar?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01;database = biblioteca;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where stuid= "+rowid+"";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Datos sin guardar seran perdidos.","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK) 
            this.Close();
        }
    }
}
