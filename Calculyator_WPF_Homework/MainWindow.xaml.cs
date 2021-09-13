using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculyator_WPF_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double num1 = 0;
        public double num2 = 0; 
        public bool novbe1 = true;
        public string hesablama = "";
        public bool sifiraBolme = false;
        public MainWindow()
        {
            InitializeComponent();
            txt_Result.Text = "0";
        }

        private void NumberClicked(object sender, RoutedEventArgs e)
        {
            
            Button btnNum = sender as Button;
            if(sifiraBolme == true)
            {
                txt_Result.Text = "0";
            }
            if (txt_Result.Text != "0")
            {
                txt_Result.Text += btnNum.Content.ToString();
            }
            else
            {
                txt_Result.Text = btnNum.Content.ToString();
            }
            if (novbe1 == true)
            {
                num1 = Convert.ToDouble(txt_Result.Text);
            }
            else
            {
                num2 = Convert.ToDouble(txt_Result.Text);
            }
            sifiraBolme = false;
        }

        private void HesabClicked(object sender, RoutedEventArgs e)
        {
            Button btnHesab = sender as Button;

            if (btnHesab.Name == "BtnToplama")
            {
                hesablama = "+";
                novbe1 = false;
                txt_Result.Text = "0";
    
                if(num2 != 0)              
                    num1 = num1 + num2;
                
            }
            else if (btnHesab.Name == "BtnCixma")
            {
                hesablama = "-";
                txt_Result.Text = "0";
                novbe1 = false;
                if (num2 != 0)
                    num1 = num1 - num2;
            }
            else if (btnHesab.Name == "BtnX")
            {
                hesablama = "x";
                txt_Result.Text = "0";
                novbe1 = false;
                if (num2 != 0)
                    num1 = num1 * num2;

            }
            else if (btnHesab.Name == "BtnBolme")
            {
                hesablama = "/";
                txt_Result.Text = "0";
                novbe1 = false;
                if (num2 != 0)
                    num1 = num1 / num2;
     
            }
            else if (btnHesab.Name == "BtnBeraber")
            {
                if (hesablama == "+")
                {
                    txt_Result.Text = Convert.ToString(num1 + num2);
                    novbe1 = true;
                }
                else if (hesablama == "-")
                {
                    txt_Result.Text = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                    novbe1 = true;
                }
                else if (hesablama == "x")
                {
                    txt_Result.Text = Convert.ToString(num1 * num2);
                    novbe1 = true; 
                }
                else if (hesablama == "/")
                {
                    if (num2 != 0)
                    {
                        txt_Result.Text = Convert.ToString(num1 / num2);
                    }
                    else
                    {
                        txt_Result.Text = "Mümkün deyil";
                        num1 = Convert.ToDouble(txt_Result.Text);
                        num2 = 0;
                        novbe1 = true;
                        hesablama = "";
                        sifiraBolme = true;
                    }

                }
                num1 = Convert.ToDouble(txt_Result.Text); ;
                num2 = 0;
                novbe1 = true;
                hesablama = "";
                novbe1 = true;
            }

        }

        private void DeleteAll_Clicked(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            novbe1 = true;
            hesablama = "";
            txt_Result.Text = "0";
        }

        private void EksBtnClicked(object sender, RoutedEventArgs e)
        {
            txt_Result.Text = Convert.ToString(Convert.ToDouble(txt_Result.Text) - (2 * Convert.ToDouble(txt_Result.Text)));

            if (novbe1 == true)
            {
                num1 = Convert.ToDouble(txt_Result.Text);
            }
            else
            {
                num2 = Convert.ToDouble(txt_Result.Text); 
            }
                
        }

        private void Kvadrat_Clicked(object sender, RoutedEventArgs e)
        {
            txt_Result.Text = Convert.ToString(Convert.ToDouble(txt_Result.Text) * 2);

            if (novbe1 == true)
            {
                num1 = Convert.ToDouble(txt_Result.Text);
            }
            else
            {
                num2 = Convert.ToDouble(txt_Result.Text);
            }
        }
    }
}
