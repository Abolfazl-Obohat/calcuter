using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcuter
{
    public partial class Form1: Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)texNumber1.Value, (int)texNumber2.Value);
                MessageBox.Show("sum is  " + sum);
            }

        }
        bool ValidateInputs()
        {
            bool isValid = true;
            if (texNumber1.Value == 0)
            {

                isValid = false;
                MessageBox.Show("لطفا عدد اول وارد کن...");

            }
            else
            {
                if (texNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کن...");

                }
            }
            return isValid;

        }

        private void btnMinese_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Minuse = calculate.Minus((int)texNumber1.Value, (int)texNumber2.Value);
                MessageBox.Show("Minuse is  " + Minuse);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Multiple = calculate.Multiple((int)texNumber1.Value, (int)texNumber2.Value);
                MessageBox.Show("Multiple is  " + Multiple);
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Divide = calculate.Divide((int)texNumber1.Value, (int)texNumber2.Value);
                MessageBox.Show("Divide is  " + Divide);
            }
        }
    }
}
