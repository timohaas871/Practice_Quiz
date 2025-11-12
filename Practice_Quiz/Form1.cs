using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        int factor1;
        int factor2;
        int product;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            question1OutputLabel.Text = "Happy Hump Day";
        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            question2OutputLabel.Text = "Hello " + question2TextBox.Text;
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            try
            {
                factor1 = Convert.ToInt16(q3Int1Text.Text);
                factor2 = Convert.ToInt16(q3int2Text.Text);
                product = factor1 * factor2;

                question3OutputLabel.Text = factor1 + " x " + factor2 + " = " + product;
            }

            catch
            {
                question3OutputLabel.Text = "Invalid input, try again";
            }
        }

        private void q3Int1Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
