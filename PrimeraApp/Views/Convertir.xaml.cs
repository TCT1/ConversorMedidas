using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeraApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;

        public Convertir()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            cm = Convert.ToDouble(txt.Text);
            m = cm / 100;
            lblResultado.Text = m.ToString() + " m";
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}