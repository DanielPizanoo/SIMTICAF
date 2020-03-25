using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIMTICAF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Clicked(object sender, EventArgs eventArgs)
        {
            var usuario = user.Text;
            var contra = pass.Text;

            if (!string.IsNullOrEmpty(usuario))
            {
                DisplayAlert("Error", "Favor de ingresar usuario", "Aceptar");
            }

            if (!string.IsNullOrEmpty(contra))
            {
                DisplayAlert("Error", "Favor de ingresar contraseña", "Aceptar");
            }
        }
    }
}
