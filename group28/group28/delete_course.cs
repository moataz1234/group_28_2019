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
    public partial class delete_course : Form
    {
        private OleDbConnection connection= new OleDbConnection();
       // private OleDbCommand cmd;
       // private OleDbDataAdapter dapter;
        public delete_course()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mtzat\Desktop\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string SqlStr = string.Format("delete from Course where Number='" + textB_num + "'");
            //try
            //{
            //    conn.Open();
            //    OleDbCommand cmd = new OleDbCommand();
            //    cmd = conn.CreateCommand();
            //    cmd.CommandText = SqlStr;
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            //try
            //{
            //    connection.Open();
            //    OleDbCommand command = new OleDbCommand();
            //    command.Connection = connection;
            //   // string query = "DELETE FROM Course WHERE Number=" + textB_num.Text + "";
            //    command.CommandText = "DELETE FROM Course WHERE Number=" + textB_num.Text + "";
            //    //cmd.CommandType = CommandType.Text;
            //    //cmd.CommandText = "delete from Course where Number=" + textB_num + "";
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Deleted Successful!");
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error " + ex);
            //    connection.Close();
            //}









            //string sql= "delete from Course where Number='" + textB_num + "'";
            //cmd = new OleDbCommand(sql, connection);
            //try
            //{
            //    connection.Open();
            //    dapter = new OleDbDataAdapter(cmd);
            //    dapter.DeleteCommand = connection.CreateCommand();
            //    dapter.DeleteCommand.CommandText = sql;
            //    if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //    {
            //        if (cmd.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Successfully deleted");
            //        }
            //    }
            //    connection.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    connection.Close();
            //}
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void delete_course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database23DataSet.Course);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                label1.Text = "connected";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
