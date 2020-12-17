using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbms
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }

        private void display_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.rollno;
            label10.Text = Form1.maths;
            label11.Text = Form1.sci;
            label12.Text = Form1.eng;
            label14.Text = Form1.hindi;
            label15.Text = Form1.socialsci;
            label16.Text = Form1.lang;
           label9.Text = Form1.name;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
