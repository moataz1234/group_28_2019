using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace group28
{
    public partial class manager_send_message : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public manager_send_message()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mtzat\Desktop\Database23.mdb;
Persist Security Info=False;";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
//            try
//            {
//              //  OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mtzat\Desktop\Database23.mdb;
////Persist Security Info=False;");
//                connection.Open();
//                OleDbCommand command = new OleDbCommand();
//                command.Connection = connection;
//                command.CommandText = "INSERT INTO [messages] (sender_id,reciever_id,Text) VALUES ('"+textB_byid.Text+ "','" + textB_toid.Text + "','" + richTextB_text.Text + "')";
//                command.ExecuteNonQuery();
//                MessageBox.Show("Data saved!");
//                connection.Close();
//            }
//            catch(Exception ex){
//                MessageBox.Show("Error " + ex);
//            }
        }

        private void manager_send_message_Load(object sender, EventArgs e)
        {

        }
    }
}
