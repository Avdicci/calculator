using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operators;
        double first_num;

        

        private void BtnOp(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(txt_box.Text);
            operators = ((Button)sender).Text;

            txt_box.Text = "";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
         
            txt_box.Text += ((Button)sender).Text;
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            double second_num = Convert.ToDouble(txt_box.Text);

            switch (operators)
            {
                case "+":
                    first_num = first_num+second_num;
                    break;
                case "---":
                    first_num = first_num-second_num;
                    break;
                case "X":
                    first_num = first_num*second_num;
                    break;
                case "/":
                    first_num = first_num / second_num;
                    break;
            }
            txt_box.Text = first_num.ToString();

        }

        private void op_Btn(object sender, EventArgs e)
        {
            operators = ((Button)sender).Text;
            first_num = Convert.ToDouble(txt_box.Text);
            txt_box.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_box.Text = "";
            
        }
    }
}
