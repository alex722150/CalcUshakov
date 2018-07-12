using System;
using System.Windows.Forms;
using CalcUshakov.CalculatorOneArgument;
using CalcUshakov.CalculatorTwoArgument;

namespace CalcUshakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

    private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnum = Convert.ToDouble(textBox4.Text);
                double secondnum = Convert.ToDouble(textBox5.Text);
                string caluclateName = ((Button)sender).Name;
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator(caluclateName);
                double result = calculator.Calculator(firstnum, secondnum);

                textBox6.Text = result.ToString();
            }
            catch (Exception TwoArgumentException)
            {
                MessageBox.Show("Неверное выражение" + TwoArgumentException);
            }

        }

        private void Square_Click(object sender, EventArgs e)
        {
                try
                {
                    double firstnum = Convert.ToDouble(textBox4.Text);
                    string caluclateName = ((Button)sender).Name;
                    ICalculatorOneArgument calculator1 = CalculatorOneFactory.CreateCalculator(caluclateName);
                    double result = calculator1.Calculator(firstnum);
                    textBox6.Text = result.ToString();
                }
                catch (Exception OneArgumentException)
                {
                    MessageBox.Show("Неверное выражение" + OneArgumentException);
                }
            }
        }
}



