using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace primerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            double cm, m;

            cm = Convert.ToDouble(txtCentimetros.Text);

                

            resCentimetros.Text = Convert.ToString(calcular(cm)) + "(m)";

        }

        public double calcular(double cm) {
            double m=0;

            m= cm*0.01;

            return m;
        }
    }
}