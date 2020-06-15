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
    public partial class AgregarCategorias : ContentPage
    {


        public AgregarCategorias()
        {
            InitializeComponent();
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EntryCategoria.Text))
            {
                await DisplayAlert("Alerta", "Ingresar la categoria al insertar", "Aceptar");
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
                    this.Navigation.PopAsync();
                }
            }

        }

    }
}