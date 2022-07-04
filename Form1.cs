using System.Data;
using System.Data.SqlClient;

namespace MSSQL_Database_info_fetch
{
    public partial class Form1 : Form
    {

        string dbconnection = "Server=localhost;Database=books;Trusted_Connection=true"; // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(dbconnection);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT author,book,release FROM book", con); // Database info retrieved

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            foreach (DataRow row in dtable.Rows)
            {
                listBox1.Items.Add(row["author"].ToString() + " " + row["book"].ToString() + " " + row["release"].ToString());
            }

        }
    }
}