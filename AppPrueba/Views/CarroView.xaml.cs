using System;
using System.Collections.Generic;
using AppPrueba.VIewModels;
using Xamarin.Forms;

namespace AppPrueba.Views
{
    public partial class CarroView : ContentPage
    {
        CarroViewModel context = new CarroViewModel();

        public CarroView()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}
