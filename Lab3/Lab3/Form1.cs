﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left) 
            {
                //creates and adds coordinates to array list

                PointValues p = new PointValues(e.X, e.Y, false); 
                this.coordinates.Add(p);
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right) 
            {
                
                int total = coordinates.Count;
                int index = total - 1;
                for (int i = index; i >= 0; i--)
                {
                    PointValues p = (PointValues)coordinates[i];
                    if ((Math.Abs(e.X - p.X) < 10) && (Math.Abs(e.Y - p.Y) < 10))
                    {
                        //if circle is black
                        if (p.red_black == false) 
                        {
                            p.red_black = true; //will turn red with right click
                            
                            this.Invalidate();
                        }
                        //if red circle
                        else if (p.red_black == true) 
                        {
                            coordinates.RemoveAt(i); //remove coordinates from array list via right click
                 
                            this.Invalidate();
                        }
                    }
                }

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            const int WIDTH = 20;
            const int HEIGHT = 20;
            Graphics g = e.Graphics;
            foreach (PointValues p in this.coordinates)
            {
                if (p.red_black)
                {
                    //fill red 
                    g.FillEllipse(Brushes.Red, p.X - WIDTH / 2, p.Y - WIDTH / 2, WIDTH, HEIGHT); 
                }
                if (!p.red_black)
                {
                    //fill black if no circle
                    g.FillEllipse(Brushes.Black, p.X - WIDTH / 2, p.Y - WIDTH / 2, WIDTH, HEIGHT); 
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear(); //clear if button is pushed
            this.Invalidate();
        }

        private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear(); //clear if clear button on menu is clicked
            this.Invalidate();
        }
    }

    public class PointValues //class to help distinguish circles, locations & colors
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool red_black { get; set; }
        public PointValues(int x_coord, int y_coord, bool color)
        {
            X = x_coord;
            Y = y_coord;
            red_black = color;
        }
    }
}