using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double hasil;
        int operationCounter = 0;
        double[] angka = new double[100];
        string operasi = "";
        
        string inputSementara = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void tambahAngka(string nilai)
        {
            inputSementara += nilai; 
            textBox1.Text += nilai;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambahAngka("1");
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            tambahAngka("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tambahAngka("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tambahAngka("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tambahAngka("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            tambahAngka("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tambahAngka("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            tambahAngka("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tambahAngka("9");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            tambahAngka("0");
        }
        private void button00_Click(object sender, EventArgs e)
        {
            tambahAngka("00");
        }
        private void prosesOperator(string simbol)
        {
            if (inputSementara != "")
            { 
                angka[operationCounter] = double.Parse(inputSementara);
                operationCounter++;
                
                operasi += simbol;
                textBox1.Text += simbol; 
                
                inputSementara = ""; 
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            prosesOperator("+");
        } 
        private void buttonMin_Click(object sender, EventArgs e)
        {
            prosesOperator("-");
        }
        private void buttonTimes_Click(object sender, EventArgs e){
            prosesOperator("*");
        }        private void buttonDivide_Click(object sender, EventArgs e)
        {
            prosesOperator("÷");
        }
        private void buttonMod_Click(object sender, EventArgs e)
        {
            prosesOperator("%");
        }

        private void buttonAutoClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            inputSementara = "";
            operasi = "";
            operationCounter = 0;
            hasil = 0;
            Array.Clear(angka, 0, angka.Length); 
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (inputSementara != "")
            {
                angka[operationCounter] = double.Parse(inputSementara);
            }

            hasil = angka[0];

            for (int i = 0; i < operasi.Length; i++)
            {
                char operatorSekarang = operasi[i];
                double angkaBerikutnya = angka[i + 1];

                if (operatorSekarang == '+')
                {
                    hasil = hasil + angkaBerikutnya;
                }
                else if (operatorSekarang == '-')
                {
                    hasil = hasil - angkaBerikutnya;
                }
                else if (operatorSekarang == '*')
                {
                    hasil = hasil * angkaBerikutnya;
                }
                else if (operatorSekarang == '÷' || operatorSekarang == '/')
                {
                    hasil = hasil / angkaBerikutnya;
                }
                else if (operatorSekarang == '%')
                {
                    hasil = hasil % angkaBerikutnya;
                }
            }

            textBox1.Text = hasil.ToString();
            
          
            operasi = "";
            inputSementara = hasil.ToString(); 
            angka[0] = hasil; 
            operationCounter = 1; 
        }
    }
}