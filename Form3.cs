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
        string team1;
        string team2;
        string question;
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

        public Form3(string team1, string team2, string question, string top1, string top2, string top3, string top4, string top5, string top6, string top7, string top8, string top9, string top10)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.question = question;
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
            if(flagInterchange % 2 == 0)
            {
                team1Score+=
            }
        }
    }
}