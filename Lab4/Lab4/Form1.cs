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

namespace Lab4
{
    public partial class Form1 : Form
    {
        private bool[,] queen_Array = new bool[8, 8];    //Store location of queens on a 8x8 array -- (true with queen or false without queen)
        private int queen_num;                           //counts number of queens


        Font specified_font = new Font("Arial", 30, FontStyle.Bold);      //Skinner's specified font, size, and style
    
        public Form1()
        {
            InitializeComponent();
        }

        //clear the board!
        private void Clear_Click(object sender, EventArgs e)
        {
            Array.Clear(queen_Array, 0, queen_Array.Length);    //clear queen location array
            queen_num = 0;                                      //reset queen counter to zero
            this.Invalidate();                                  //invalidate!
        }

        int xy_origin = 100;

        //function checks to see if move is valid on the 8x8 board array
        private bool hint_guide(int x, int y)
        {
            //return false if the move is invalid so you know if you should make the box red
            //return true if the move is valid

            //check rows (x)
            for (int ii = 0; ii < 8; ii++)
            {
                //since you're checking x rows y remains constant
                if (queen_Array[ii, y])
                {
                    return false;
                }
            }

            //check columns columns (y)
            for (int ii = 0; ii < 8; ii++)
            {
                //since you're checking y columns x remains constant
                if (queen_Array[x, ii])
                {
                    return false;
                }

            }

            //checking diagnols!

            //check upper left diagnol
            for (int jj = y, diagX1 = x; diagX1 < 8 && jj < 8; jj++, diagX1++)
            {
                if (queen_Array[diagX1, jj])
                {
                    return false;
                }

            }

            //check upper right diagonal
            for (int jj = y, diagX2 = x; diagX2 >= 0 && jj < 8; jj++, diagX2--)
            {
                if (queen_Array[diagX2, jj])
                {
                    return false;
                }
            }

            //check lower left diagonal
            for (int jj = y, diagX3 = x; jj >= 0 && diagX3 < 8; jj--, diagX3++)
            {
                if (queen_Array[diagX3, jj])
                {
                    return false;
                }
            }

            //check lower right diagonal
            for (int jj = y, diagX4 = x; diagX4 >= 0 && jj >= 0; jj--, diagX4--)
            {
                if (queen_Array[diagX4, jj])
                {
                    return false;
                }
            }

            return true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("You have " + queen_num + " queens on the board.", Font, Brushes.Black, 200, 50);   //must display the num of queens on board

            //now make the board 8x8
            for (int ii = 0; ii < 8; ii++)      //row
            {
                for (int jj = 0; jj < 8; jj++)  //column
                {
                    int row = ii*50;
                    int column = jj*50;

                    int row_center = xy_origin + row;
                    int column_center = xy_origin + column;
                    //is hintbox checked? color false squares red
                    if (this.Hint_checkbox.Checked && !hint_guide(ii, jj))
                    {
                      
                        g.FillRectangle(Brushes.Red, row_center, column_center, 50, 50);
                        g.DrawRectangle(Pens.Black, row_center, column_center, 50, 50);
                    }

                    //else if the of rows and column are odd, draw black boxes
                    else if ((ii + jj) % 2 == 1)
                    {
                        
                        g.FillRectangle(Brushes.Black, row_center, column_center, 50, 50);
                        g.DrawRectangle(Pens.Black, row_center, column_center, 50, 50);
                    }

                    //otherwise, color the boxes white
                    else
                    {
                        g.FillRectangle(Brushes.White, row_center, column_center, 50, 50);
                        g.DrawRectangle(Pens.Black, xy_origin +row, column_center, 50, 50);
                    }

                    //if the indexed array is true, draw the red boxes onto to the board
                    if (queen_Array[ii, jj])
                    {
                        Rectangle Q_box = new Rectangle(row_center, column_center, 50, 50);

                        //Draw black Q if the square is colored white
                        //or hint box is checked
                        //make sure there's not a Q already there
                        if ((ii + jj) % 2 == 0 || this.Hint_checkbox.Checked && !hint_guide(ii, jj))
                        {
                            g.DrawString("Q", specified_font, Brushes.Black, Q_box);

                        }
                        //otherwsie draw white Q (on a black box)
                        else
                        {
                            g.DrawString("Q", specified_font, Brushes.White, Q_box);
                        }
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            /*check if click is within grid
            note that x and y are not not <= 500 because when you subtract it by 100 and divide by 50, it gives 
            the box an index of 8 which is technically outside queen array range*/
            if (((x >= xy_origin) && (y >= xy_origin)) && ((x < 500) && (y < 500)))
            {
                x = x - xy_origin;    //create 100 for x origin
                y = y - xy_origin;    //create 100 for y origin

                //if the left mouse button is clicked
                if (e.Button == MouseButtons.Left)
                {

                    //if the spot is valid, place a Queen down and increase queen_num
                    //diving by 50,gives us indices of the board 
                    if (hint_guide((x / 50), (y / 50))) //if true
                    {
                        queen_Array[(x / 50), (y / 50)] = true; //mark as true
                        queen_num++;    //increment queen counter

                        this.Invalidate();  //dont forget to invalidate

                        //congrats! you made it to 8 queens
                        if (queen_num == 8)
                        {
                            MessageBox.Show("You did it!");
                        }
                    }

                    //play the beep otherwise because you tried to make an invalid move
                    else
                    {
                        System.Media.SystemSounds.Beep.Play();

                    }
                }

                //if right mousebutton was clicked
                else if (e.Button == MouseButtons.Right)
                {
                    //if there is a queen in the spot already, remove it and decrement queen_num
                    if (queen_Array[(x / 50), (y / 50)])
                    {
                        queen_Array[(x / 50), (y / 50)] = false;    //mark queen array index false
                        queen_num--;                                //decrement number of queens
                        this.Invalidate();                          //invalidate
                    }

                    //play the beep otherwise because you tried to make an invalid move
                    else
                    {
                        System.Media.SystemSounds.Beep.Play();

                    }

                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}