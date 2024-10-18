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
    public partial class AñadirLibros : Form
    {
        public AñadirLibros()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AñadirLibros_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "" && txtAutor.Text != "" && txtAutor.Text != "" && txtEditorial.Text != "" && txtGenero.Text != "" && txtPubl.Text != "")
            {



                String bTitulo = txtTitulo.Text;
                String bIsbn = txtISBN.Text;
                String bAutor = txtAutor.Text;
                String bEditorial = txtEditorial.Text;
                String bGenero = txtGenero.Text;
                String bFechaPub = txtPubl.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DASHF15\\SQLEXPRESS01; database = biblioteca;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook(bTitulo,bIsbn,bAutor,bEditorial,bGenero,bFechaPub) values ('" + bTitulo + "','" + bIsbn + "','" + bAutor + "','" + bEditorial + "','" + bGenero + "','" + bFechaPub + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Datos Guardados.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitulo.Clear();
                txtISBN.Clear();
                txtEditorial.Clear();
                txtGenero.Clear();
                txtPubl.Clear();
                txtAutor.Clear();

            }
            else
            {
                MessageBox.Show("No se permite datos sin llenar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro? Esto borrara tus datos sin guardar", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
