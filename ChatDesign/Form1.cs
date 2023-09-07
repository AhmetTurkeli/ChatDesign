﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatDesign
{
    public partial class Form1 : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Normal;
            flowLayoutPanel1.AutoScroll = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
                move = true;
                mouse_x = e.X;
                mouse_y = e.Y;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox messageBox = new MessageBox();
            messageBox.username = bunifuTextBox1.Text;
            flowLayoutPanel1.Controls.Add(messageBox);
        }

        private void bunifuPictureBox4_Click_1(object sender, EventArgs e)
        {
            MessageBox2 messageBox2 = new MessageBox2();
            messageBox2.username = bunifuTextBox1.Text;
            flowLayoutPanel1.Controls.Add(messageBox2);
        }



        //#5CB8FF açıkmavi
        //#005477 koyumavi
    }
}
