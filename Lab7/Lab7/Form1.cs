using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private string key;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //browse file button, opens file dialoge
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                /*set the string in textbox to whatever filename you choose 
                in the open dialoge*/
            }

        }

        private bool get_Key()
        {
            //obtain whatever key entered
            if(textBox2.Text == "")
            {
                //check if nothing is entered in the key text box
                MessageBox.Show("Enter a key please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            key = textBox2.Text; //set key to whatever was typed into the key textbox
            return true;
        }

        //decrypt button
        private void button3_Click(object sender, EventArgs e)
        {

            /*Decryption instructions
             * This same algorithm is used to decrypt the file.
             * Two consequitive XOR operations cancel each other
             */

            if (!get_Key())
            {
                return;
            }
            string text1 = textBox1.Text;

            if (!text1.EndsWith(".enc"))
            {
                //check if file is not encoded
                MessageBox.Show("This is not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string text2 = text1.Substring(0, text1.Length - 3);
            //permission to overwrite file
            if (File.Exists(text2) && MessageBox.Show("Output file exists. Do you want to overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //load the cursor
            Cursor = Cursors.WaitCursor;
            Form1.encrypt_Data(text1, text2, key);
            Cursor = Cursors.Default;
        }

        //encrypt button
        private void button2_Click(object sender, EventArgs e)
        {
            //event for when you click the encyrpt button

            if (!get_Key())
            {
                //if get_key wasnt called, aka you have no key
                return;
            }

            string text1 = textBox1.Text;   //from filebox1 which is where you get the filename
            string text2 = text1 + ".enc"; //add .enc filetype for "encoded"

            if (File.Exists(text2) && MessageBox.Show("Output file exists. Do you want to overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //load the cursor
            Cursor = Cursors.WaitCursor;
            Form1.encrypt_Data(text1, text2, key);
            Cursor = Cursors.Default;

        }

        //function to encrypt file
        private static void encrypt_Data(string input_Name, string output_Name, string key)
        {
            //need filestreams, declare null 
            FileStream stream1 = null;  //input
            FileStream stream2 = null;  //output

            try
            {
                //create a new filestream for hte input file/output file, add attributes like read and write
                stream1 = new FileStream(input_Name, FileMode.Open, FileAccess.Read);
                stream2 = new FileStream(output_Name, FileMode.OpenOrCreate, FileAccess.Write);
                stream2.SetLength(0L);
            }
            catch
            {
                MessageBox.Show("Error :-(( Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                //if input stream or output stream is null
                if(stream1 != null)
                {
                    //close
                    stream1.Close();
                }
                if(stream2 != null)
                {
                    //close
                    stream2.Close();
                }

                return;
          
            }

            /*Instructions for encryption algorithm
             * The encryption is done by performing an exclusive OR (^ operator) on each byte of the file and a corresponding character in the key cast to a byte. 
             * Byte 1 of the file is XORed with byte 1 of the key. 
             * Byte 2 of the file is XORed with byte 2 of the key etc. 
             * After using the last byte of the key we go back to the first byte of the key wrapping around as many times as needed. 
             * The character in the Unicode key string is cast to a byte (byte). 
             */


            int num = 0;
            int length = key.Length;    //get key length
            int num2;

            while((num2 = stream1.ReadByte()) != -1)
            {
                byte b = (byte)key[num];    //byte1
                byte val = (byte)(num2 ^ (int)b);   //byte2

                stream2.WriteByte(val); //write byte 2 to output file
                num++;  //increment num

                if (num == length)  //if num == length of key then reset to 0
                {
                    num = 0;
                }


            }

            //close the streams
            stream2.Close();
            stream1.Close();

            MessageBox.Show("Congrats! The operation completed successfully.");
        }

    }
}
