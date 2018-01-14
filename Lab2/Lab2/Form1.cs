using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {

        //initialize array list to store coordinates
        private ArrayList coordinates = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        //paint event handler
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            const int WIDTH = 20;
            const int HEIGHT = 20;
            Graphics g = e.Graphics;

            //for ealoop to create multiple dots on form and print coordinates on right hand side of dots
            foreach (Point p in this.coordinates)
            {
                //create string for the coordinate in format (x,y)
                string coordinate = String.Format("{0}, {1}", p.X, p.Y);
                
                //fill circle              
                g.FillEllipse(Brushes.Black, p.X - WIDTH / 2, p.Y - WIDTH / 2, WIDTH, HEIGHT);
               
                //add coordinate to righthand side of each dot
                g.DrawString(coordinate, Font, Brushes.Black, p.X + (WIDTH / 2) + 4, p.Y - 6);
            }
        }

        //Mouse click event handler
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //left click creates new point (x,y)
            if (e.Button == MouseButtons.Left)
            {

                Point p = new Point(e.X, e.Y);
                this.coordinates.Add(p);
                this.Invalidate();

            }

            //right click clears all points
            if (e.Button == MouseButtons.Right)
            {
                this.coordinates.Clear();
                this.Invalidate();
            }
        }

        //handler for button click event, clears form
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }

        //handler for clear option on tool strip menu, clears form when clicked
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }

    }
}