namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double hasil;
        int operationCounter = 0;
        double[] angka = new double[100];

        string operasi;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void buttonAutoClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            angka[operationCounter] = double.Parse(textBox1.Text);

            operationCounter++;

            operasi += "+";
            textBox1.Text += "+";
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            angka[operationCounter] = double.Parse(textBox1.Text);

            operationCounter ++;

            operasi += "-";
            textBox1.Text += "-";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            angka[operationCounter] = double.Parse(textBox1.Text);

            operationCounter++;

            operasi += "*";
            textBox1.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            angka[operationCounter] = double.Parse(textBox1.Text);

            operationCounter++;

            operasi += "÷";
            textBox1.Text += "÷";
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            angka[operationCounter] = double.Parse(textBox1.Text);

            operationCounter++;

            operasi += "%";
            textBox1.Text += "%";
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            for (int currentOperationIndex = 0; currentOperationIndex <= operationCounter; 
                currentOperationIndex += 1)
            {
            for (int i = 0; i < operasi.Length; i++)
              {
               

                    if (operasi[i] == '+')
                    {
                        hasil += angka[i];
                    }
                    else if (operasi[i] == '-')
                    {
                        hasil -= angka[i];
                    }
                    else if (operasi[i] == '*')
                    {
                        hasil *= angka[i];
                    }
                    else if (operasi[i] == '÷')
                    {
                        hasil /= angka[i];
                    }
                    else if (operasi[i] == '%')
                    {
                        hasil %= angka[i];
                    }
                }
                textBox1.Text = hasil.ToString();
            }
            hasil = 0;
            operasi = "";
            operationCounter = 0;
        }
    }
}
