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

        /*static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=simticaf;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        */

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var usuario = user.Text;
            var password = pass.Text;

            var us = "admin";
            var pa = "admin";

            if (string.IsNullOrEmpty (user.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un usuario", "Aceptar");
                user.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass.Text))
            {
                await DisplayAlert("Error", "Debe ingresar una contraseña", "Aceptar");
                pass.Focus();
                return;
            }

            if (user.Text != us)
            {
                await DisplayAlert("Alerta", "Usuario incorrecto", "Aceptar");
                pass.Focus();
                return;
            }

            if (pass.Text != pa)
            {
                await DisplayAlert("Alerta", "Contraseña incorrecto", "Aceptar");
                pass.Focus();
                return;
            }

            if (user.Text == us)
            {
                if (pass.Text == pa)
                {
                    this.Navigation.PushAsync(new Index());
                }
            }
            //this.Navigation.PushAsync(new Index());
        }
    }
}
//this.Navigation.PushAsync(new Index());