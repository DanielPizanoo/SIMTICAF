using SIMTICAF.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMTICAF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
        }

        public void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            //registros.precio_u = preciou.Text;
            //registros.cantidad = cantidad.Text;
            //registros.id_categoria = categoria;
            //registros.descripcion = descripcion.Text.ToString();

            HttpClient cliente = new HttpClient();

            String URL = "";

            this.Navigation.PopAsync();
        }
    }
}