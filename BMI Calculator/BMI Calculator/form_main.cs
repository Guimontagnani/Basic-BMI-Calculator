using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        Calc bmi = new Calc();
        public string ret;

        private void btn_calc_Click(object sender, EventArgs e)
        {
            ret = bmi.bmi(txb_peso.Text, txb_altura.Text);
            
            if (Convert.ToDouble(ret) <= 16.9)
            {
                txb_res.Text=("Você está muito abaixo do peso");
                txb_english.Text=("You are very underweight.");
            }
            else
                if (Convert.ToDouble(ret) <= 18.4)
                {
                    txb_res.Text = ("You are underweight");
                    txb_english.Text = ("");
                }
                else
                    if (Convert.ToDouble(ret) <= 24.9)
                    {
                        txb_res.Text = ("Você está no seu peso normal");
                        txb_english.Text = ("You are at your normal weight");
                    }
                    else
                        if (Convert.ToDouble(ret) <= 29.9)
                        {
                            txb_res.Text = ("Você está acima do peso");
                            txb_english.Text = ("You are at overweight");
                        }
                        else
                            if (Convert.ToDouble(ret) <= 34.9)
                            {
                                txb_res.Text = ("Você está com Obesidade de Primeiro Grau");
                                txb_english.Text = ("You Have First Degree Obesity");
                            }
                            else
                                if (Convert.ToDouble(ret) <= 40)
                                {
                                    txb_res.Text = ("Você está com Obesidade de Segundo Grau");
                                    txb_english.Text = ("You Have High School Obesity");
                                }
                                else
                                    if (Convert.ToDouble(ret) > 40)
                                    {
                                        txb_res.Text = ("Você está com Obesidade de Terceiro Grau");
                                        txb_english.Text = ("You have Obesity of Third Degree");
                                    }
                                    else
                                    {
                                        txb_res.Text = ("Insira um valor válido");
                                        txb_english.Text = ("Please enter a valid value");
                                    }
        }
    }
}
