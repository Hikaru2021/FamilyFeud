using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FamilyFeud
{
    public partial class Form3 : Form
    {
        string top1;
        string top2;
        string top3;
        string top4;
        string top5;
        string top6;
        string top7;
        string top8;
        string top9;
        string top10;
        int team1Score = 0;
        int team2Score = 0;
        int flagInterchange = 1;

        public Form3(string top1, string top2, string top3, string top4, string top5, string top6, string top7, string top8, string top9, string top10)
        {
            this.top1 = top1;
            this.top2 = top2;
            this.top3 = top3;
            this.top4 = top4;
            this.top5 = top5;
            this.top6 = top6;
            this.top7 = top7;
            this.top8 = top8;
            this.top9 = top9;
            this.top10 = top10;

            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void CheckKeyPress()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = top1;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 10;
                flagInterchange++;
            }
            else
            {
                team2Score += 10;
                flagInterchange++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = top2;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 9;
                flagInterchange++;
            }
            else
            {
                team2Score += 9;
                flagInterchange++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = top3;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 8;
                flagInterchange++;
            }
            else
            {
                team2Score += 8;
                flagInterchange++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = top4;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 8;
                flagInterchange++;
            }
            else
            {
                team2Score += 8;
                flagInterchange++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = top5;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 7;
                flagInterchange++;
            }
            else
            {
                team2Score += 7;
                flagInterchange++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = top6;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 6;
                flagInterchange++;
            }
            else
            {
                team2Score += 6;
                flagInterchange++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = top7;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 5;
                flagInterchange++;
            }
            else
            {
                team2Score += 5;
                flagInterchange++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = top8;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 4;
                flagInterchange++;
            }
            else
            {
                team2Score += 4;
                flagInterchange++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = top9;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 3;
                flagInterchange++;
            }
            else
            {
                team2Score += 3;
                flagInterchange++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = top10;
            if (flagInterchange % 2 == 0)
            {
                team1Score += 2;
                flagInterchange++;
            }
            else
            {
                team2Score += 2;
                flagInterchange++;
            }
        }
    }
}