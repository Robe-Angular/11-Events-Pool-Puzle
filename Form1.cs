﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Events_Pool_Puzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Airplane);
            this.Load += new EventHandler(Motorcycle);
            
        }

        void Towtruck(object sender, EventArgs e)
        {
            Console.Write("is comming ");
        }

        void Motorcycle(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Bicycle);
        }

        void Bicycle(object sender, EventArgs e)
        {
            Console.WriteLine("to get you!");
        }
        void Airplane(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Dumptruck);
            button1.Click += new EventHandler(Towtruck);
        }

        void Dumptruck(object sender, EventArgs e)
        {
            Console.Write("Fingers ");
        }
    }
}
