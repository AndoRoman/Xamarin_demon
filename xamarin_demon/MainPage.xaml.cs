using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_demon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Get data of FrontEnd
            double altura = double.Parse(txtAltura.Text);
            double peso = double.Parse(txtPeso.Text);

            //Operation
            double IMC = peso / (altura * altura);

            //Set data on FrontEnd
            txtResultado.Text = IMC.ToString();

            //Alert
            string result = "";

            if(IMC < 18.5)
            {
                result = "Tienes Bajo Peso";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                result = "Tu peso es Correcto";
            }
            else if (IMC > 25 && IMC <= 29.9)
            {
                result = "Tienes sobrepeso";
            }
            else
            {
                result = "Tienes Obecidad";
            }

            DisplayAlert("Resultado", result, "OK");
        }

    }
}
