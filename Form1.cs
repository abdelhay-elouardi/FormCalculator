using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
        double value;
        string seperator;
        bool check;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void BNumber(object sender , EventArgs e)
        {
            if ((seperator == "+") || (seperator == "-") || (seperator == "*") || (seperator == "/"))
            {
                if (check)
                {
                    check = false;
                    UserInput.Text = "0";
                }
            }
            Button b = sender as Button;
            if (UserInput.Text == "0")
                UserInput.Text = b.Text;
            else UserInput.Text += b.Text;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BSeperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(UserInput.Text);
            seperator = b.Text;
            UserInput.Text += b.Text;
            check = true; 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (seperator)
                {
                    case "+":
                        UserInput.Text = (value + double.Parse(UserInput.Text)).ToString(); break;
                    case "*":
                        UserInput.Text = (value + double.Parse(UserInput.Text)).ToString(); break;
                    case "-":
                        UserInput.Text = (value + double.Parse(UserInput.Text)).ToString(); break;
                    case "/":
                        UserInput.Text = (value + double.Parse(UserInput.Text)).ToString(); break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            UserInput.Text = "0";
            value = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            UserInput.Text = "0";
        }
    }
}

       