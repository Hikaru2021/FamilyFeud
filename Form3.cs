﻿using System;
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
        int point1;
        int point2;
        int point3;
        int point4;
        int point5;
        int point6;
        int point7;
        int point8;
        int point9;
        int point10;
        int team1Score = 0;
        int team2Score = 0;
        int flagInterchange = 1;

        public Form3(string top1, string top2, string top3, string top4, string top5, string top6, string top7, string top8, string top9, string top10, int point1, int point2, int point3, int point4, int point5, int point6, int point7, int point8, int point9, int point10)
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
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
            this.point6 = point6;
            this.point7 = point7;
            this.point8 = point8;
            this.point9 = point9;
            this.point10 = point10;
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = top2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = top3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = top4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = top5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = top6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = top7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = top8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = top9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = top10;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point1;
            }
            else
            {
                team2Score += this.point1;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);

            if (e.Button == MouseButtons.Right)
                button3.Text = top1;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point2;
            }
            else
            {
                team2Score += this.point2;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button4.Text = top2;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point3;
            }
            else
            {
                team2Score += this.point3;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button5.Text = top3;
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point4;
            }
            else
            {
                team2Score += this.point4;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button6.Text = top4;
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point5;
            }
            else
            {
                team2Score += this.point5;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button7.Text = top5;
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point6;
            }
            else
            {
                team2Score += this.point6;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button12.Text = top6;
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point7;
            }
            else
            {
                team2Score += this.point7;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button11.Text = top7;
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point8;
            }
            else
            {
                team2Score += this.point8;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button10.Text = top8;
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point9;
            }
            else
            {
                team2Score += this.point9;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button9.Text = top9;
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                team1Score += this.point10;
            }
            else
            {
                team2Score += this.point10;
            }
            button1.Text = Convert.ToString(team1Score);
            button2.Text = Convert.ToString(team2Score);
            if (e.Button == MouseButtons.Right)
                button8.Text = top10;
        }

    }
}