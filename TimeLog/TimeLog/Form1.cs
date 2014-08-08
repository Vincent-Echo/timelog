using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Provider = SQLOLEDB; Server=10.57.2.96\SQLEXPRESS; Database=HadzapiDtb; Integrated Security=SSPI
            SqlConnection conn = new SqlConnection("Server=10.57.2.96\\SQLEXPRESS; Database=HadzapiDtb; Integrated Security=SSPI");
            //SqlConnection conn = new SqlConnection("Data Source=10.57.2.96\\SQLEXPRESS, Database=HadzapiDtb");
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT top 5 * FROM dbo.Projects_Monitored";
            command.CommandTimeout = 15;
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(String.Format("{0}", reader[1]));
            }
            conn.Close();

        }

    }
}
