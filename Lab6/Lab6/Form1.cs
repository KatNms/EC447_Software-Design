using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{

    public partial class Form1 : Form
    {
        private SettingDlg sdlg = new SettingDlg();
        private Point startPoint;
        private Point endPoint;
        private ArrayList objects = new ArrayList();    //stores graphic objects drawn in the array
        private bool mouseFirst = true;                 //keeps track of the first click


        public Form1()
        {
            InitializeComponent();
            //Set initial index to 0
            this.PenColor.SelectedIndex = 0;
            this.FillColor.SelectedIndex = 0;
            this.PenWidth.SelectedIndex = 0;
            this.outline.Checked = true;
        }
        //Clear the objects drawn on panel2
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.objects.Clear();
            this.panel2.Invalidate();
            //base.Update();
        }
        //Undo most recent object 
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.objects.Count > 0) //Check to make sure an object was drawn
            {
                this.objects.RemoveAt(this.objects.Count - 1);
            }
            this.panel2.Invalidate();
        }
        //Exit 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        //when setting button is clicked open new dialog
        private void Settings_Click(object sender, EventArgs e)
        {
          
            sdlg.ShowDialog();
        }

        //The panel2 is where everything is drawn and panel2 paint handler
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            //When any of the shapes are selected draw it
            foreach (MyObject myObject in this.objects)
            {
                myObject.draw(graphics);
            }
        }
        //Panel2 mouse handler
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
           
            //if it is the first mouse click it is the start location and make it false
            if (this.mouseFirst)
            {
                this.startPoint = e.Location;
                this.mouseFirst = false;
                return;
            }
            //Reset the mouseFirst upon the second click
            this.endPoint = e.Location;
            this.mouseFirst = true;
            Brush brush = null;     //Brush Color
            Brush brush2 = null;    //Fill Color
            Pen pen = null;         //Pen



            //Seting the Pen Color
            switch (this.sdlg.PenColor.SelectedIndex)
            {
                case 0:
                    brush = Brushes.Black;
                    break;
                case 1:
                    brush = Brushes.Red;
                    break;
                case 2:
                    brush = Brushes.Blue;
                    break;
                case 3:
                    brush = Brushes.Green;
                    break;
            }

            //If either Line or Outline box is checked, you need to make the pen the correct color and width
            //parse the selected item for into an int and store in pen
            if (this.sdlg.outline.Checked || this.lineButton.Checked)
            {
                pen = new Pen(brush, (float)int.Parse((string)this.sdlg.PenWidth.SelectedItem));
            }
            //Set Fill Color if fill option is checked
            if (this.sdlg.fill.Checked)
            {
                switch (this.sdlg.FillColor.SelectedIndex)
                {
                    case 0:
                        brush2 = Brushes.White;
                        break;
                    case 1:
                        brush2 = Brushes.Black;
                        break;
                    case 2:
                        brush2 = Brushes.Red;
                        break;
                    case 3:
                        brush2 = Brushes.Blue;
                        break;
                    case 4:
                        brush2 = Brushes.Green;
                        break;
                }
            }

            //if line button is checked
            if (this.lineButton.Checked)
            {
                this.objects.Add(new MyLine(this.startPoint, this.endPoint, pen));
            }
            //If fill is checked 
            if (brush2 != null || pen != null)
            {
                //Draw Rectangle
                if (this.rectangleButton.Checked)
                {
                    this.objects.Add(new MyRectangle(this.startPoint, this.endPoint, pen, brush2));
                }
                //Draw Ellipse
                if (this.ellipseButton.Checked)
                {
                    this.objects.Add(new MyEllipse(this.startPoint, this.endPoint, pen, brush2));
                }
            }
            else
            {
                MessageBox.Show("Uh oh! Make sure either fill and/or outline are checked.");
            }

            this.panel2.Invalidate();
            base.Update();
        }
    }

    //base class MyObject
    public class MyObject
    {
        public virtual void draw(Graphics g)
        {
            
        }
    }
    //Line class
    public class MyLine : MyObject
    {
        private Point start;
        private Point end;
        private Pen pen;
        public MyLine(Point start, Point end, Pen pen)
        {
            this.start = start;
            this.end = end;
            this.pen = pen;
        }
        public override void draw(Graphics g)
        {
            g.DrawLine(this.pen, this.start, this.end);
        }
    }
    //Rectangle class
    public class MyRectangle : MyObject
    {
        private Point start;
        private Point end;
        private Pen pen;
        private Brush brush;
        public MyRectangle(Point start, Point end, Pen pen, Brush brush)
        {
            this.start = start;
            this.end = end;
            this.pen = pen;
            this.brush = brush;
        }
        public override void draw(Graphics g)
        {
            int width = Math.Abs(this.end.X - this.start.X);
            int height = Math.Abs(this.end.Y - this.start.Y);
            int x = Math.Min(this.start.X, this.end.X);
            int y = Math.Min(this.start.Y, this.end.Y);
            if (this.brush != null)
            {
                g.FillRectangle(this.brush, x, y, width, height);
            }
            if (this.pen != null)
            {
                g.DrawRectangle(this.pen, x, y, width, height);
            }
        }
    }
    //Ellipse Class
    public class MyEllipse : MyObject
    {
        private Point start;
        private Point end;
        private Pen pen;
        private Brush brush;
        public MyEllipse(Point start, Point end, Pen pen, Brush brush)
        {
            this.start = start;
            this.end = end;
            this.pen = pen;
            this.brush = brush;
        }
        public override void draw(Graphics g)
        {
            int width = Math.Abs(this.end.X - this.start.X);
            int height = Math.Abs(this.end.Y - this.start.Y);
            int x = Math.Min(this.start.X, this.end.X);
            int y = Math.Min(this.start.Y, this.end.Y);
            if (this.brush != null)
            {
                g.FillEllipse(this.brush, x, y, width, height);
            }
            if (this.pen != null)
            {
                g.DrawEllipse(this.pen, x, y, width, height);
            }
        }
    }
}
