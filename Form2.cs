using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FamilyFeud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string team1Name = textBox1.Text; //team 1 name
            string team2Name = textBox2.Text; //team 2 name
            string question = textBox3.Text; //question

            //ANSWERS
            string textBox4Value = textBox4.Text; //1
            string textBox5Value = textBox5.Text; //2
            string textBox6Value = textBox6.Text; //3
            string textBox7Value = textBox7.Text; //4
            string textBox8Value = textBox8.Text; //5
            string textBox9Value = textBox9.Text; //6
            string textBox10Value = textBox10.Text; //7
            string textBox11Value = textBox11.Text; //8
            string textBox12Value = textBox12.Text; //9
            string textBox13Value = textBox13.Text; //10 

            Form3 form3 = new Form3(team1Name, team2Name, question, textBox4Value, textBox5Value, textBox6Value, textBox7Value, textBox8Value, textBox9Value, textBox10Value, textBox11Value, textBox12Value, textBox13Value);
            form3.Show();
        }
    }
}
