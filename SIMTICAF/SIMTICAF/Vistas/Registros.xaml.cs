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
    public partial class Registros : ContentPage
    {
        public Registros()
        {
            InitializeComponent();
        }

        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(des.Text))
            {
                await DisplayAlert("Alerta", "Favor de llenar todos los campos", "Aceptar");
            }
            else
            {
                Clases.Registros registro = new Clases.Registros();
                registro.cantidad = can.Text.ToString();
                registro.preciou = pre.Text.ToString();
                //registro.categoria = cat.Text.ToString();
                var cate = cat.SelectedIndex;
                string categ = cate.ToString();
                registro.categoria = categ;
                registro.descripcion = des.Text.ToString();

                HttpClient cliente = new HttpClient();
                String URL = "https://simticaf.000webhostapp.com/AgregarRegistro.php";

                String jsonUsuario = JsonConvert.SerializeObject(registro);
                var res = await cliente.PostAsync(URL, new StringContent(jsonUsuario));
                var response = res.Content.ReadAsStringAsync().Result;

                if (res.IsSuccessStatusCode)
                {
                    this.Navigation.PopAsync();
                }
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                Clases.GetCategorias getc = new Clases.GetCategorias();
                var res = await getc.getCategoriasList();

                if (res != null)
                {
                    cat.ItemsSource = res;
                }
            }
            catch (Exception e)
            {
                await DisplayAlert("Error", " " + e, "Ok");
            }
        }
    }
}