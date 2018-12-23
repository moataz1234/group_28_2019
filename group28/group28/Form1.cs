﻿using System;
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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mtzat\Desktop\Database23.mdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            ManagerZone man = new ManagerZone();
            StudentZone stu = new StudentZone();
            LecturerZone lec = new LecturerZone();
            string user = string.Format(username_text.Text);
            string pass = string.Format(password_text.Text);
            if (user == "" || pass == "") {
                MessageBox.Show("you must enter username and pass to login");
            }
            //string id = string.Format("select ID from student,lecturer,Manager where ");
            else if (user[0] == 's')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from student where username='" + username_text.Text + "'and password = '" + password_text.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    this.Hide();
                    stu.Show();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    MessageBox.Show("Incorrect");
                }
                connection.Close();
            }
           else if (user[0] == 'm')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Manager where username='" + username_text.Text + "'and password = '" + password_text.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    this.Hide();
                    man.Show();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    MessageBox.Show("Incorrect");
                }
                connection.Close();
            }
            else if (user[0] == 'l')
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from lecturer where username='" + username_text.Text + "'and password = '" + password_text.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    this.Hide();
                    lec.Show();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    MessageBox.Show("Incorrect");
                }
                connection.Close();
            }
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

        private void manzone_Click(object sender, EventArgs e)
        {
            ManagerZone mann = new ManagerZone();
            mann.Show();
        }

        private void leczone_Click(object sender, EventArgs e)
        {
            LecturerZone lecc = new LecturerZone();
            lecc.Show();
        }
        public string Get_id(string id)
        {
            return id;
        }
    }
}
