﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group28
{
    public partial class Add_student : Form
    {
        public Add_student()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database23DataSet);

        }

        private void Add_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database23DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database23DataSet.student);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            database23DataSet.student.AddstudentRow(textBox_ID.Text, textBox_fn.Text, textBox_ln.Text, textBox_un.Text, textBox_pw.Text, textBox_mail.Text, dateTimePicker1.Value, comboBox1.Text, comboBox2.Text);
            studentTableAdapter.Update(database23DataSet);
            studentBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(database23DataSet);

            MessageBox.Show("Success!");
        }
    }
}