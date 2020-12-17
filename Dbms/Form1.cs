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
    public partial class Form1 : Form
    {
        public static string name = "";
        public static string rollno = "";
        public static string maths = "";
        public static string sci = "";
        public static string eng = "";
        public static string hindi = "";
        public static string socialsci = "";
        public static string lang = "";
        public static string fname = "";
        public static string lname = "";
        public static string div = "";
        public static string std = "";
        public static string dob = "";
        public static string addharno = "";
        public Form1()
        {
            
            InitializeComponent();

            label5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String Uname = "Admin", Upass = "School", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                new reg().Show();
                this.Hide();


            }
            else
            {
                label5.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
