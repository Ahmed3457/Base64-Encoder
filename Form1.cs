using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64_Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn2_click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    string text = textBox1.Text;
                    byte[] encodedText = System.Convert.FromBase64String(text);
                    EncodedTextLabel.Text = System.Text.Encoding.UTF8.GetString(encodedText);
                }
                else
                {
                    string text = textBox1.Text;
                    byte[] decodedText = System.Text.Encoding.UTF8.GetBytes(text);
                    EncodedTextLabel.Text = System.Convert.ToBase64String(decodedText);
                }
            }
            catch (System.FormatException)
            {
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void copyToClipboard(object sender, EventArgs e)
        {
            string text = EncodedTextLabel.Text;
            Clipboard.SetText(text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
