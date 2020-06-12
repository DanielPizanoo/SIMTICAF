using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMTICAF.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarCategoria : ContentPage
    {


        public AgregarCategoria()
        {
            InitializeComponent();
        }
        public void Btn_Agregando(object sender, EventArgs e)
        {


            ((NavigationPage)this.Parent).PushAsync(new Categorias());
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EntryCategoria.Text))
            {
                await DisplayAlert("Alerta", "Favor de llenar los datos de inicio", "Aceptar");
            }
            else
            {
                Clases.Categorias categoria = new Clases.Categorias();
                categoria.descripcion = EntryCategoria.Text.ToString();

                HttpClient cliente = new HttpClient();
                String URL = "https://simticaf.000webhostapp.com/AgregarCategoria.php";

                String jsonUsuario = JsonConvert.SerializeObject(categoria);
                var res = await cliente.PostAsync(URL, new StringContent(jsonUsuario));
                var response = res.Content.ReadAsStringAsync().Result;

                if (res.IsSuccessStatusCode)

                {
                    await Navigation.PushAsync(new Categorias());
                }
            }

        }

    }
}