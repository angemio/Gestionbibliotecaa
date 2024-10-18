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
using System.Xml.Linq;

namespace Gestionbibliotecaa
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se borraran los datos. Confirmar?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String btitulo = txtTitulo.Text;
                String bautor = txtAutor.Text;
                String beditorial = txtEditorial.Text;
                String bpub = txtFecha.Text;
                String bisbn = txtISBN.Text;
                String bgenero = txtGenero.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText =  "delete from NewBook where bid="+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource=ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
              //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bid= " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtTitulo.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAutor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtISBN.Text = ds.Tables[0].Rows[0][3].ToString();
            txtEditorial.Text = ds.Tables[0].Rows[0][4].ToString();
            txtGenero.Text = ds.Tables[0].Rows[0][5].ToString();
            txtFecha.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;   
        }

        private void txtTituloLib_TextChanged(object sender, EventArgs e)
        {
            if(txtTituloLib.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bTitulo LIKE '" +txtTituloLib.Text+ " %' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTituloLib.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se actualizaran los datos. Confirmar?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
             String btitulo = txtTitulo.Text;
             String bautor = txtAutor.Text;
             String beditorial = txtEditorial.Text;
             String bpub = txtFecha.Text;
             String bisbn = txtISBN.Text;
             String bgenero = txtGenero.Text;
             
             SqlConnection con = new SqlConnection();
             con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database= biblioteca;integrated security=True";
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = con;

             cmd.CommandText = "update NewBook set bTitulo = '" + btitulo + "' , bIsbn = '" + bautor + "',bEditorial = '" + beditorial + "',bGenero = '" + bgenero + "',bFechaPub = '" + bpub + "'where bid=" + rowid + "";
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);

            }
        }
        
    }
}
