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
            string team1Name = textBox1.Text; // team 1 name
            string team2Name = textBox2.Text; // team 2 name
            string question = textBox3.Text; // question

            // ANSWERS
            string textBox4Value = textBox4.Text; // 1
            string textBox5Value = textBox5.Text; // 2
            string textBox6Value = textBox6.Text; // 3
            string textBox7Value = textBox7.Text; // 4
            string textBox8Value = textBox8.Text; // 5
            string textBox9Value = textBox9.Text; // 6
            string textBox10Value = textBox10.Text; // 7
            string textBox11Value = textBox11.Text; // 8
            string textBox12Value = textBox12.Text; // 9
            string textBox13Value = textBox13.Text; // 10 

            // Points
            int? textBox14Value = string.IsNullOrEmpty(textBox14.Text) ? 0 : (int?)Convert.ToInt32(textBox14.Text);
            int? textBox15Value = string.IsNullOrEmpty(textBox15.Text) ? 0 : (int?)Convert.ToInt32(textBox15.Text);
            int? textBox16Value = string.IsNullOrEmpty(textBox16.Text) ? 0 : (int?)Convert.ToInt32(textBox16.Text);
            int? textBox17Value = string.IsNullOrEmpty(textBox17.Text) ? 0 : (int?)Convert.ToInt32(textBox17.Text);
            int? textBox18Value = string.IsNullOrEmpty(textBox18.Text) ? 0 : (int?)Convert.ToInt32(textBox18.Text);
            int? textBox19Value = string.IsNullOrEmpty(textBox19.Text) ? 0 : (int?)Convert.ToInt32(textBox19.Text);
            int? textBox20Value = string.IsNullOrEmpty(textBox20.Text) ? 0 : (int?)Convert.ToInt32(textBox20.Text);
            int? textBox21Value = string.IsNullOrEmpty(textBox21.Text) ? 0 : (int?)Convert.ToInt32(textBox21.Text);
            int? textBox22Value = string.IsNullOrEmpty(textBox22.Text) ? 0 : (int?)Convert.ToInt32(textBox22.Text);
            int? textBox23Value = string.IsNullOrEmpty(textBox23.Text) ? 0 : (int?)Convert.ToInt32(textBox23.Text);

            Form3 form3 = new Form3(textBox4Value, textBox5Value, textBox6Value, textBox7Value, textBox8Value, textBox9Value, textBox10Value, textBox11Value, textBox12Value, textBox13Value, textBox14Value, textBox15Value, textBox16Value, textBox17Value, textBox18Value, textBox19Value, textBox20Value, textBox21Value, textBox22Value, textBox23Value);

            form3.Show();
            this.Close();
            form3.richTextBox2.Text = team1Name;
            form3.richTextBox3.Text = team2Name;
            form3.richTextBox1.Text = question;
        }
    }
}
