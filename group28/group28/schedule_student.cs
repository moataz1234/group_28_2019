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
    public partial class schedule_student : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter sda;
        //private OleDbCommandBuilder scb;
        DataTable dt;

        public schedule_student()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mtzat\Desktop\Database23.mdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////get id the current student 
            
            ////view to student his own schedule
                sda = new OleDbDataAdapter("SELECT Name,day,Hour,lec_id FROM Course,student,student_course WHERE student.ID = student_course.StudentID AND Course.Number=student_course.Course_Number", connection);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            
        }
    }
}
