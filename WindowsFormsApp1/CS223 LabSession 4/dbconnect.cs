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

namespace CS223_LabSession_4
{
    public partial class dbconnect : Form
    {
        public dbconnect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = " Data Source =AMAN\\SQLEXPRESS; Initial Catalog = HILCOE; Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                MessageBox.Show("Connection Established!");
                con.Close();
            }
            catch (SqlException )
            {
                MessageBox.Show("Connection Failed!");
            }

        }
    }
}


