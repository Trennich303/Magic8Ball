using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }
        Random randGen = new Random();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button8Ball_Click(object sender, EventArgs e)
        {
            int value;
            value = randGen.Next(1, 7);

            if (value == 1)
            {
                OutputTextBox.Text = "Yes";
            }
            else if (value == 2)
            {
                OutputTextBox.Text = "No";
            }
            else if (value == 3)
            {
               OutputTextBox.Text = "It is certain";
            }
            else if (value == 4)
            {
                OutputTextBox.Text = "Very doubtful";
            }
            else if (value == 5)
            {
                OutputTextBox.Text = "Most likely";
            }
            else if (value == 6)
            {
                OutputTextBox.Text = "Don't count on it";
            }
           
        }
    }
}
