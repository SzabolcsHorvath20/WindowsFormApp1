using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int textBoxText1, textBoxText2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxText1 = Convert.ToInt32(textBox1.Text);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxText2 = Convert.ToInt32(textBox2.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(textBoxText1 + textBoxText2);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
