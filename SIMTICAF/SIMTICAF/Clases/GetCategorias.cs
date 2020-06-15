using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIMTICAF.Clases
{
    class GetCategorias
    {
        const String URL = "https://simticaf.000webhostapp.com/GetCategorias.php";

        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<Categorias>> getCategorias()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Categorias>>(content);
            }

            return Enumerable.Empty<Categorias>();
        }

        public async Task<List<Categorias>> getCategoriasList()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Categorias>>(content);
            }

            return new List<Categorias>();
        }
    }
}