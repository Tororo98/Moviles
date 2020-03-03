using System;
using AppPrueba.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPrueba
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.Properties["ValorGuardado"] = 25;
            MainPage = new CarroView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
