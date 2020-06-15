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
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Vistas.Registros());
        }

        private void BtnCategorias_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Vistas.Categorias());
        }

        private void BtnMovimientos_Clicked(Object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Vistas.Movimientos());
        }

        private void BtnSalir_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}