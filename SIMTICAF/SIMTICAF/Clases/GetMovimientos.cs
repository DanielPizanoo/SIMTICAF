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
    class GetMovimientos
    {
        const String URL = "https://simticaf.000webhostapp.com/GetRegistros.php";

        private HttpClient getRegistro()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<Registros>> GetRegistros()
        {
            HttpClient client = getRegistro();
            var res = await client.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Registros>>(content);
            }

            return Enumerable.Empty<Registros>();
        }
    }
}
