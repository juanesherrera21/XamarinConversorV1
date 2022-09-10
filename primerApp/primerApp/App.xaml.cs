using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using primerApp;


namespace primerApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new primerApp.Page1()); //La pagina 1 es la que inicia. 
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
