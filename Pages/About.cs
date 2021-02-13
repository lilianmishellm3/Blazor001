using Blazor001.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor001.Pages
{
    public partial class About
    {
        List<Datos> listDatos = new List<Datos>();

        protected async override Task OnInitializedAsync()
        {
            listDatos = await GetEquipo();

        }

        private async Task<List<Datos>> GetEquipo()
        {
            List<Datos> listProductos = new List<Datos>();
            string json = string.Empty;


            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://angurlar-html-default-rtdb.firebaseio.com/equipo.json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listProductos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Datos>>(responseBody);

           


            return listProductos;
        }
    }
}
