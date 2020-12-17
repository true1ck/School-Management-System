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
    public partial class disinfo : Form
    {
        public disinfo()
        {
            InitializeComponent();
        }

        private void disinfo_Load(object sender, EventArgs e)
        {
            label8.Text = Form1.fname;
            label11.Text = Form1.lname;
            label12.Text = Form1.rollno;
            label13.Text = Form1.div;
            label14.Text = Form1.std;
            label15.Text = Form1.dob;
            label16.Text = Form1.addharno;
            
        }
    }
}
