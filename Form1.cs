using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics3
{
    // author B N Ward
    // Date 14 Jan 2008
    // Drawing graphics on a form

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;             	// get a graphics object
            Pen myPen = new Pen(Color.Red, 10);  	// create a new red pen
            Font myfont = new Font("Times New Roman", 16);

            Point[] shape = new Point[6];        	// create an array of points
            shape[0] = new Point(200, 100);         // put 3 points into the array
            shape[1] = new Point(250, 150);
            shape[2] = new Point(200, 200);
            shape[3] = new Point(150, 200);
            shape[4] = new Point(100, 150);
            shape[5] = new Point(150, 100);

            g.DrawPolygon(myPen, shape);             // draw shape using red`pen
            g.FillPolygon(Brushes.Red, shape);   // fill shape using a yellow brush 
            g.DrawString("Dylan's Hexagon", myfont, Brushes.Blue, 100, 210);
        }


    }
}