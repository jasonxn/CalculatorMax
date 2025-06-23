namespace CalculatorMax
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool operationOFF = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            operationOFF = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            operationOFF = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            operationOFF = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operationOFF)
            {
                firstNumber = double.Parse(textBox1.Text);
                textBox1.Clear();

            }

            operation = "x";
            operationOFF = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operationOFF)
            {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
                
            }

            operation = "-";
            operationOFF = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            operationOFF = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            operationOFF = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            operationOFF = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            operationOFF = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            operationOFF = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            operationOFF = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            operationOFF = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            operationOFF = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operationOFF)
            {
                firstNumber = double.Parse(textBox1.Text);
                textBox1.Clear();

            }

            operation = "+";
            operationOFF = false;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (operationOFF)
            {
                firstNumber = double.Parse(textBox1.Text);
                textBox1.Clear();

            }

            operation = "/";
            operationOFF = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            double result = 0;
            operationOFF = true;

            switch (operation)
            {

                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "x":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        break;
                    }
                    else { textBox1.Text = "Err"; break; }

            }
            textBox1.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}

