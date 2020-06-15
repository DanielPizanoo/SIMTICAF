using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMTICAF.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Movimientos : ContentPage
    {
        public Movimientos()
        {
            InitializeComponent();
        }

        private void Btn_Modificar(object sender, EventArgs e)
        {

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                Clases.GetMovimientos getm = new Clases.GetMovimientos();
                var res = await getm.GetRegistros();

                if (res != null)
                {
                    ListaMovimientos.ItemsSource = res;
                }
            }
            catch (Exception e)
            {
                await DisplayAlert("Error", " " + e, "Ok");
            }
        }
    }
}