using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMTICAF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
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