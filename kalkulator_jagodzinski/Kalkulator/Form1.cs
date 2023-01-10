using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string operacja;
        public string memory = "";
        public double n;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "1";
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "2";
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "3";
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "4";
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "5";
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "6";
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "7";
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "8";
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "9";
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string a=textBox1.Text;
            if (textBox1.Text != "" && !a.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                operacja = "/";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else if (textBox2.Text != "" && textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double liczba2 = double.Parse(textBox2.Text);
                n = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox1.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + liczba2;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba2 - liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = liczba2 * liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba2 / liczba1;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox2.Text = "1";
                    }
                    else
                    {
                        double x = liczba2;
                        for (int i = 1; i < potega; i++)
                        {
                            liczba2 *= x;
                        }
                        wynik = liczba2;
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                operacja = "/";
            }
            else operacja = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                operacja = "*";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else if (textBox2.Text != "" && textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double liczba2 = double.Parse(textBox2.Text);
                n = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox1.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + liczba2;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba2 - liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = liczba2 * liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba2 / liczba1;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox2.Text = "1";
                    }
                    else
                    {
                        double x = liczba2;
                        for (int i = 1; i < potega; i++)
                        {
                            liczba2 *= x;
                        }
                        wynik = liczba2;
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                operacja = "*";
            }
            else operacja = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                operacja = "-";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else if (textBox2.Text != "" && textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double liczba2 = double.Parse(textBox2.Text);
                n = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox1.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + liczba2;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba2 - liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = liczba2 * liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba2 / liczba1;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox2.Text = "1";
                    }
                    else
                    {
                        double x = liczba2;
                        for (int i = 1; i < potega; i++)
                        {
                            liczba2 *= x;
                        }
                        wynik = liczba2;
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                operacja = "-";
            }
            else operacja = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                operacja = "+";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else if(textBox2.Text != "" && textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double liczba2 = double.Parse(textBox2.Text);
                n = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox1.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + liczba2;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba2 - liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = liczba2 * liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba2 / liczba1;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox2.Text = "1";
                    }
                    else
                    {
                        double x = liczba2;
                        for (int i = 1; i < potega; i++)
                        {
                            liczba2 *= x;
                        }
                        wynik = liczba2;
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                operacja = "+";
            }
            else operacja = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double liczba2 = double.Parse(textBox2.Text);
                n = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox2.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + liczba2;
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba2 - liczba1;
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = liczba2 * liczba1;
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba2 / liczba1;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox1.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        double x = liczba2;
                        for (int i = 1; i < potega; i++)
                        {
                            liczba2 *= x;
                        }
                        wynik = liczba2;
                        wynikstring = wynik.ToString();
                        textBox1.Text = wynikstring;
                    }
                }
            }
            else if(textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox2.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + n;
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba1 - n;
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = n * liczba1;
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba1 / n;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox1.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        double x = n;
                        for (int i = 1; i < potega; i++)
                        {
                            n *= x;
                        }
                        wynik = n;
                        wynikstring = wynik.ToString();
                        textBox1.Text = wynikstring;
                    }
                }
            }
            else
            {
                textBox3.Text = "NIE WPISANO LICZBY!";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                operacja = "^";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else if (textBox2.Text != "" && textBox1.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double liczba2 = double.Parse(textBox2.Text);
                n = double.Parse(textBox1.Text);
                string wynikstring;
                double wynik;
                textBox3.Text = "";
                textBox1.Text = "";
                if (operacja == "+")
                {
                    wynik = liczba1 + liczba2;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "-")
                {
                    wynik = liczba2 - liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "*")
                {
                    wynik = liczba2 * liczba1;
                    wynikstring = wynik.ToString();
                    textBox2.Text = wynikstring;
                }
                else if (operacja == "/")
                {
                    wynik = liczba2 / liczba1;
                    if (liczba1 == 0)
                    {
                        textBox3.Text = "NIE DZIEL PRZEZ ZERO!";
                    }
                    else
                    {
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                else if (operacja == "^")
                {
                    int potega = Convert.ToInt32(liczba1);
                    if (potega == 0)
                    {
                        textBox2.Text = "1";
                    }
                    else
                    {
                        double x = liczba2;
                        for (int i = 1; i < potega; i++)
                        {
                            liczba2 *= x;
                        }
                        wynik = liczba2;
                        wynikstring = wynik.ToString();
                        textBox2.Text = wynikstring;
                    }
                }
                operacja = "^";
            }
            else operacja = "^";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (textBox1.Text != "" && !a.StartsWith("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (a.StartsWith("-"))
            {
                a = a.Remove(0, 1);
                textBox1.Text = a;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (a != "")
            {
                a = a.Remove(a.Length-1);
                textBox1.Text = a;
            }
            if (a == "-")
            {
                textBox1.Text = "";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (textBox2.Text == "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                if (liczba1 < 0) textBox3.Text = "PIERWIASTEK NIE ISTNIEJE!";
                else
                {
                    double wynik;
                    string wynikstring;
                    wynik = Math.Sqrt(liczba1);
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                if (liczba1 < 0) textBox3.Text = "PIERWIASTEK NIE ISTNIEJE!";
                else
                {
                    double wynik;
                    string wynikstring;
                    wynik = Math.Sqrt(liczba1);
                    wynikstring = wynik.ToString();
                    textBox1.Text = wynikstring;
                }
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (textBox2.Text == "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double wynik;
                string wynikstring;
                wynik = liczba1 / 100;
                wynikstring = wynik.ToString();
                textBox1.Text = wynikstring;
            }
            else if (textBox1.Text !="" && textBox2.Text != "")
            {
                double liczba1 = double.Parse(textBox1.Text);
                double wynik;
                string wynikstring;
                wynik = liczba1 / 100;
                wynikstring = wynik.ToString();
                textBox1.Text = wynikstring;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                memory = textBox1.Text;
                textBox3.Text = "ZAPISANO LICZBĘ: " + memory;
            }
            else textBox3.Text = "NIE WPISANO LICZBY!";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (memory != "")
            {
                textBox1.Text = memory;
                textBox3.Text = "WCZYTANO LICZBĘ!";
            }
            else textBox3.Text = "BRAK ZAPISANEJ LICZBY!";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = "USUNIĘTO LICZBĘ: " + memory;
                memory = "";
            }
            else textBox3.Text = "PAMIĘĆ JEST JUŻ PUSTA!";
        }
    }
}
