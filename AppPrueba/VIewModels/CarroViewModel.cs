using System;
using System.Windows.Input;
using AppPrueba.Models;
using Xamarin.Forms;

namespace AppPrueba.VIewModels
{
    public class CarroViewModel
    {
        #region Properties

        public CarroModel Carro { get; set; }
        public CarroModel CarroVista { get; set; }

        public ICommand ActualizarDatosCommand { get; set; }

        public int DatoGuardado { get; set; }

        #endregion Properties

        #region Initialize

        public CarroViewModel()
        {
            Carro = new CarroModel()
            {
                Marca = "Audi",
                Color = "Azul"
            };

            CarroVista = new CarroModel()
            {
                Marca = "Renault",
                Color = "Verde"
            };
            ActualizarDatosCommand = new Command(() => ActualizarDatos(), () => true);
            if (Application.Current.Properties.ContainsKey("ValorGuardado"))
            {
                var datoGuardado = (int)Application.Current.Properties["ValorGuardado"];
                DatoGuardado = Convert.ToInt32(datoGuardado);
            }
        }

        #endregion Initialize

        #region Metodos

        public void ActualizarDatos()
        {
            CarroVista.Marca = Carro.Marca;
            CarroVista.Color = Carro.Color;

        }

        #endregion Metodos

    }
}
