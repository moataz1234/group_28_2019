using System;
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
    public partial class StudentZone : Form
    {
        public StudentZone()
        {
            InitializeComponent();
        }

        public Search_lecturer s1 = new Search_lecturer();


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            s1.Show();            
        }
    }
}
