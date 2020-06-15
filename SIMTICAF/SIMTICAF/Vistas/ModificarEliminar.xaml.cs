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
    public partial class ModificarEliminar : ContentPage
    {
        private int id_cat;
        public ModificarEliminar(int id, string categoria)
        {
            InitializeComponent();
            id_cat = id;
            textCategoria.Text = categoria;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Clases.Categorias categoria = new Clases.Categorias();
            categoria.descripcion = textCategoria.Text;
            HttpClient cliente = new HttpClient();

            string URL = "https://simticaf.000webhostapp.com/MovimientosModificar.php?id= " + id_cat;

            string jsonUsuario = JsonConvert.SerializeObject(categoria);
            var res = await cliente.PostAsync(URL, new StringContent(jsonUsuario));
            var response = res.Content.ReadAsStringAsync().Result;

            if (res.IsSuccessStatusCode)
            {
                await DisplayAlert("alerta", "Agregado correctamente" + response, "ok");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            HttpClient cliente = new HttpClient();

            string URL = "https://simticaf.000webhostapp.com/MovimientoEliminar.php?=" + id_cat;

            var res = await cliente.GetAsync(URL);
            var response = res.Content.ReadAsStringAsync().Result;

            if (res.IsSuccessStatusCode)
            {
                await DisplayAlert("alerta", "Agregado correctamente" + response, "ok");
            }
        }
    }
}