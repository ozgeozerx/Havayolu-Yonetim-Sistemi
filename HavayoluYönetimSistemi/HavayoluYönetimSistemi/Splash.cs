﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavayoluYönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startpoint =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgress.Value = startpoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
                    
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
