using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calc_imc_xamrin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double peso = Double.Parse(txt_peso.Text);
                double altura = Double.Parse(txt_altura.Text);
                double imc = peso / (altura * altura);

                string classificacao = "";

                if (imc < 17)
                {
                    classificacao = "Muito abaixo do peso";
                }
                else if (imc >= 17 && imc < 18.5)
                {
                    classificacao = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    classificacao = "Peso normal";
                }
                else if (imc >= 25 && imc < 30)
                {
                    classificacao = "Acima do peso";
                }
                else if (imc >= 30 && imc < 35)
                {
                    classificacao = "Obesidade I";
                }
                else if (imc >= 35 && imc < 40)
                {
                    classificacao = "Obesidade II (Severa)";
                }
                else
                {
                    classificacao = "Obesidade III (Severa)";
                }
                resultatdo.Text = "Seu IMC é " + imc.ToString(("0.00")) + " está " + classificacao;
                resultatdo.TextColor = Color.Pink;
                resultatdo.HorizontalTextAlignment = TextAlignment.Center;
            }
            catch (Exception ex)
            {
                resultatdo.Text = "Desculpe, ocorreu um erro! \n" + ex.Message;
            }
        }
    }
}
