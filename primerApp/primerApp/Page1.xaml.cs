using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using primerApp;


namespace primerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2()); // PushAync no lleva a la pagina a la que queremos ir
        }
    }
}