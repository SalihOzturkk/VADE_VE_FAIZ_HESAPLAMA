﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._10._21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //int i;
        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double tutar = Form1.miktar / Form1.taksitsayisi;
            for (int i = 1; i <= Form1.taksitsayisi; i++)
            {
                DateTime taksittarihi = DateTime.Now.AddMonths(i);//burada ay olarak aldık
                switch (taksittarihi.DayOfWeek)//burada gün olarak aldık
                {
                    case DayOfWeek.Saturday:
                        taksittarihi = taksittarihi.AddDays(2);
                        break;

                    case DayOfWeek.Sunday:
                        taksittarihi = taksittarihi.AddDays(1);
                        break;
                }
                listBox1.Items.Add(taksittarihi.ToLongDateString()+
                    "\t-->  "+tutar.ToString("C2") );
                label1.Text = "Toplamda " + listBox1.Items.Count +
                    " ay taksitlendirilmiştir.";
            }
            
        }
    }
}
