﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinThreadExam
{
    public partial class Form1 : Form
    {
        const int MAXVALUE = 1000000;       //응답없음 뜸
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(Progress));
            th.Start();
            th.Join();
        }

        void Progress()
        {
            prgSample.Minimum = 0;
            prgSample.Maximum = MAXVALUE;
            for (int i = 0; i <= MAXVALUE; i++)
            {
                prgSample.Value = i;
            }
        }
    }
}
