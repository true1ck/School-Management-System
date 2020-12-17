using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace Dbms
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
            string a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "Insert into STUDENT(FNAME,LNAME,ROLLNO,DIVISION,STANDARD,DOB,ADDHAR_NO)values('" + textBox2.Text + "','" + textBox8.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            oda = new OracleDataAdapter("Select* from STUDENT ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "Insert into STUDENT(FULL_NAME,ROLLNO,DIVISION,STANDARD,DOB,ADDHAR_NO,lname)values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            oda = new OracleDataAdapter("Select* from STUDENT ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            Form1.name = textBox2.Text;
            Form1.fname = textBox2.Text;
            Form1.lname = textBox8.Text;
            Form1.div = textBox4.Text;
            Form1.std = textBox5.Text;
            Form1.dob = textBox6.Text;
            Form1.addharno = textBox7.Text;
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "select * from STUDENT where ROLLNO='" + textBox1.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "delete from STUDENT where ROLLNO='" + textBox3.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "Insert into RESULT1(STUID,MATHS,SCI,ENG,SS,HINDI,LANG)values('" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
           
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            oda = new OracleDataAdapter("Select* from RESULT1 ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
            Form1.name = textBox2.Text;
            Form1.rollno = textBox11.Text;
            Form1.maths = textBox12.Text;
            Form1.sci = textBox13.Text;
            Form1.eng = textBox14.Text;
            Form1.hindi = textBox15.Text;
            Form1.socialsci = textBox16.Text;
            Form1.lang = textBox17.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "delete from RESULT1 where STUID='" + textBox11.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "select * from RESULT1 where STUID='" + textBox1.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "select stuid,full_name,maths,sci,eng,ss,hindi,lang from result1 inner join student on result1.stuid=student.rollno where stuid='" + textBox11.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox1.Text;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "update ATTENDENCE set ATTEND='" + textBox10.Text + "' where STUID='" + textBox9.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATED");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "Insert into ATTENDENCE(STUID,ATTEND)values('" + textBox9.Text + "','" + textBox10.Text + "')";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            oda = new OracleDataAdapter("Select* from RESULT1 ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            //string query = "select * from RESULT1 where STUID='" + textBox11.Text + "'";
            string query = "select stuid,full_name,maths,sci,eng,ss,hind from result1 inner join student on result1.stuid=student.rollno where stuid='" + textBox11.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "select * from ATTENDENCE where STUID='" + textBox9.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView3.DataSource = dt;

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "Insert into ATTENDENCE1(STUID,MONTH,CONDUCTED,ATTENDED,percentage)values('" + textBox9.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox10.Text + "')";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            oda = new OracleDataAdapter("Select* from ATTENDENCE1 ", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data source=XE;User ID=system;Password=ck");
            con.Open();
            string query = "update ATTENDENCE set ATTEND='" + textBox10.Text + "' where STUID='" + textBox9.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(query, con);

            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATED");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            textBox11.Text = textBox1.Text;
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(textBox12.Text) + double.Parse(textBox13.Text) + double.Parse(textBox14.Text) + double.Parse(textBox15.Text) + double.Parse(textBox16.Text) + double.Parse(textBox17.Text);
            double b = (a/600) * 100; 
            textBox18.Text=b.ToString();
            label26.Text = b.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double c = double.Parse(textBox20.Text);
            double d = double.Parse(textBox21.Text);
            double z = (d / c) * 100;
            textBox10.Text = z.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            new disinfo().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new display().Show();
          
        }

    }
}
