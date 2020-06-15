using SIMTICAF.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace SIMTICAF
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user.Text) || String.IsNullOrEmpty(pass.Text))
            {
                await DisplayAlert("Alerta", "Favor de llenar los datos de inicio", "Aceptar");
            }
            else
            {
                Usuarios usuario = new Usuarios();
                usuario.usuario = user.Text.ToString();
                usuario.pass = pass.Text.ToString();

                HttpClient cliente = new HttpClient();
                String URL = "https://simticaf.000webhostapp.com/ValidarLogin.php";

                String jsonUsuario = JsonConvert.SerializeObject(usuario);
                var res = await cliente.PostAsync(URL, new StringContent(jsonUsuario));
                var response = res.Content.ReadAsStringAsync().Result;

                if (response == "1")
                {
                    user.Text = "";
                    pass.Text = "";
                    await Navigation.PushAsync(new Vistas.Index());
                }
                else
                {
                    await DisplayAlert("Alerta", "Usuario y contraseña incorrectos", "Aceptar");
                }
            }
            
        }
    }
}