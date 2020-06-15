using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SIMTICAF.Clases;

namespace SIMTICAF.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categorias : ContentPage
    {
        public Categorias()
        {
            InitializeComponent();
        }

        public void Btn_AgregarCategoria(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Vistas.AgregarCategorias());
        }

        /*
        public void Btn_Modificar(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Vistas.ModificarEliminar());
        }
        */

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                Clases.GetCategorias getc = new Clases.GetCategorias();
                var res = await getc.getCategorias();

                if (res != null)
                {
                    ListaCategorias.ItemsSource = res;
                }
            }
            catch (Exception e)
            {
                await DisplayAlert("Error", " " + e, "Ok");
            }
        }
    }
}