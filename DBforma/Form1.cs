using System;
using System.Data;
using System.Data.SqlClient;



namespace DBforma
{
    public partial class Form1 : Form
    {

        string a;
        public SqlConnection cnn;
        public string connectionString = @"Data Source=ERNESTAS\SQLEXPRESS;Initial Catalog=test; User ID=testas; Password=Aa123456789";

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            cnn = new SqlConnection(connectionString);
            a = "a";
            try
            {
                cnn.Open();
                MessageBox.Show("duomenys irasyti","Zinute");
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Neprisijungta " + e, "DB", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            try
            {

                string query;
                query = "INSERT INTO dbo.TTTT (nn,pv,t,ad) VALUES (@vardas,@pavarde,@tel,@adresas)";
                SqlCommand insertSQL = new SqlCommand(query, cnn);
                insertSQL.Parameters.Add("@vardas", SqlDbType.NVarChar).Value = vardas.Text;
                insertSQL.Parameters.Add("@pavarde", SqlDbType.NVarChar).Value = pavarde.Text;
                insertSQL.Parameters.Add("@tel", SqlDbType.NVarChar).Value = tel.Text;
                insertSQL.Parameters.Add("@adresas", SqlDbType.NVarChar).Value = adresas.Text;
                insertSQL.Connection.Open();
                insertSQL.ExecuteNonQuery();
                cnn.Close();
            }

            catch
            {
                MessageBox.Show("Klaida " + e, "DB", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }


        }

        private void vardas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString)) {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM TTTT WHERE nn='"+ srcnm.Text + "' AND pv ='"+srcpv.Text+"'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridas.DataSource = dtbl;

            }
                

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Delete FROM TTTT WHERE id='" + id.Text + "'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridas.DataSource = dtbl;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM TTTT", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridas.DataSource = dtbl;

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("UPDATE TTTT SET ad='"+swad.Text+"' WHERE id = '"+swid.Text+"'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridas.DataSource = dtbl;

            }


        }
    }
}

