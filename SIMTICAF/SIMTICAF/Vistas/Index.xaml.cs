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
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
        }

        private void BtnSalir_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Registrar());
        }

        private void BtnCategorias_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Categorias());
        }

        private void BtnReportes_Clicked(Object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Reportes());
        }
    }
}