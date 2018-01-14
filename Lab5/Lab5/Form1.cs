using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool click;
        int count_input;
        int starting_input;

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Font title_font = new Font("Arial MT", 24, FontStyle.Bold);
            e.Graphics.DrawString("Find Numeric Palindrones", title_font, Brushes.Black, 130, 30);
            title_font.Dispose();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int is_valid_start;
            int is_valid_count;


            listBox1.Items.Clear();     //clear previous items

            if (Int32.TryParse(textBox1.Text, out is_valid_start) == true && Int32.TryParse(textBox2.Text, out is_valid_count) == true)
            {

                count_input = Convert.ToInt32(textBox2.Text);
                starting_input = Convert.ToInt32(textBox1.Text);

                click = true;
                make_palindrone();
                
            }
            else
            {
                label1.Text = "Please enter a positive integer within range.";
            }
            
            

        }


        private void make_palindrone()
        {

            bool check = (starting_input >= 0) && (starting_input <= 1000000000) && (count_input >= 1) && (count_input <= 100);
            

            if (click)  //if the generate button was clicked
            {
                /*check if input values meet conditions:
                 * 1. inputs can be parsed, therefore they are valid intergers
                 * 2. input is within 0-1 billion or 1-100
                 */
                if (check == false)
                {
                    label1.Text = "Please enter a positive integer within range.";

                }

                else
                {
                    label1.Text = "";
                    for (int ii = 0; ii < count_input; ii++)
                    {
                        //suggested class method
                        string initial_input = starting_input.ToString();
                        char[] palindrone_array = initial_input.ToCharArray();
                        Array.Reverse(palindrone_array);
                        string is_reversed = new string(palindrone_array);

                        //make palindromes starting from input integer in textBox1 and add them to listBox1
                        //test for a palindrome by converting the number to a string, reversing the string and comparing to the original
                        if (initial_input == is_reversed)
                        {
                            //if it is a palindrome, add it to the list box
                            listBox1.Items.Add(initial_input);
                        }
                        else
                        {
                            --ii;
                        }

                        ++starting_input;

                    }


                }

            }
        }


        //need the following functions to exist but they dont do anything
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
