using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    





namespace loginTest
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'production_4linkDataSet2.Bracket_Tools' table. You can move, or remove it, as needed.
            this.bracket_ToolsTableAdapter.Fill(this.production_4linkDataSet2.Bracket_Tools);
            // TODO: This line of code loads data into the 'production_4linkDataSet2.Bracket_Machine' table. You can move, or remove it, as needed.
            this.bracket_MachineTableAdapter.Fill(this.production_4linkDataSet2.Bracket_Machine);
            // TODO: This line of code loads data into the 'production_4linkDataSet2.A1AC_Machine' table. You can move, or remove it, as needed.
            this.a1AC_MachineTableAdapter.Fill(this.production_4linkDataSet2.A1AC_Machine);
            // TODO: This line of code loads data into the 'production_4linkDataSet2.A1AC_TooL_List' table. You can move, or remove it, as needed.
            this.a1AC_TooL_ListTableAdapter.Fill(this.production_4linkDataSet2.A1AC_TooL_List);
            // TODO: This line of code loads data into the 'production_4linkDataSet2.Tech_Name' table. You can move, or remove it, as needed.
            this.tech_NameTableAdapter.Fill(this.production_4linkDataSet2.Tech_Name);
            // TODO: This line of code loads data into the 'production_4linkDataSet.Fault_List' table. You can move, or remove it, as needed.
            this.fault_ListTableAdapter.Fill(this.production_4linkDataSet.Fault_List);
            // TODO: This line of code loads data into the 'production_4linkDataSet.Tool_List_4Link' table. You can move, or remove it, as needed.
            this.tool_List_4LinkTableAdapter.Fill(this.production_4linkDataSet.Tool_List_4Link);
            // TODO: This line of code loads data into the 'production_4linkDataSet.Machine_List' table. You can move, or remove it, as needed.
            this.machine_ListTableAdapter.Fill(this.production_4linkDataSet.Machine_List);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = comboBox2.Text;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = comboBox5.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = comboBox7.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox6.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = comboBox8.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = comboBox3.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = comboBox9.Text;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            //string Query = ("INSERT INTO dbo_records (Product,Tool,Fault,Setup,Down) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+ "','" +textBox4.Text+ "','"+textBox5.Text+"');");
            {

                string constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Letiva\Documents\Data12.mdf;Integrated Security=True;Connect Timeout=30");
                SqlConnection conDataBase = new SqlConnection(constring);
                SqlCommand cmdDataBase = new SqlCommand("INSERT INTO production_data (Product,Tool,Fault,Setup,Down,Shift,Date) VALUES(@Product,@Tool,@Fault,@Setup,@Down,@Shift,@Date)", conDataBase);
                cmdDataBase.Parameters.AddWithValue("@Product", textBox1.Text);
                cmdDataBase.Parameters.AddWithValue("@Tool", textBox2.Text);
                cmdDataBase.Parameters.AddWithValue("@Fault", textBox3.Text);
                cmdDataBase.Parameters.AddWithValue("@Setup", textBox4.Text);
                cmdDataBase.Parameters.AddWithValue("@Down", textBox5.Text);
                cmdDataBase.Parameters.AddWithValue("@Shift", textBox6.Text);
                cmdDataBase.Parameters.AddWithValue("@Date", textBox7.Text);
                conDataBase.Open();
                cmdDataBase.ExecuteNonQuery();
                MessageBox.Show("Report inserted into Database");
                conDataBase.Close(); 

            }


            //SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            //SqlDataReader myReader;
            //try {
               // conDataBase.Open();
               // myReader = cmdDataBase.ExecuteReader();
               // MessageBox.Show("Saved");
               // while (myReader.Read()) {

               // }
            //} catch (Exception ex)
            //{
             //   MessageBox.Show(ex.Message);
           // }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            View ss = new View();
            ss.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox6.Text = comboBox10.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox7.Text = dateTimePicker1.Text;
        }
    }
}

