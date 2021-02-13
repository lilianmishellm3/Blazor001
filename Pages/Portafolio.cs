using Blazor001.Entities;
using Blazor001.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace Blazor001.Pages
{
    public partial class Portafolio
    {
        List<Articulo> articulo = new List<Articulo>();

        List<Producto> productos = new List<Producto>();
        protected async override Task OnInitializedAsync()
        {


            articulo = GetArticulos();
            productos = await  GetProductos();
           

        }
      

        private List<Articulo> GetArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();

            articulos.Add(new Articulo
            {
                Name = "Tarjetas de presentación Blancas y Negras",
                Category = "papeleria",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",


            });
            articulos.Add(new Articulo
            {
                Name = "Café caliente",
                Category = "Comida",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",


            });
            articulos.Add(new Articulo
            {
                Name = "Pedazos de madera",
                Category = "Madera",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",


            });
            articulos.Add(new Articulo
            {
                Name = "Bolsas",
                Category = "Accesorios",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",


            });


            return articulos;
        }

        public async Task<List<Producto>> GetProductos()
        {
            List<Producto> listProductos = new List<Producto>();
            string json = string.Empty;


            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://angurlar-html-default-rtdb.firebaseio.com/productos_idx.json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listProductos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Producto>>(responseBody);
            
           for( int n=0; n < listProductos.Count; n++)
            {
                if (listProductos[n].Url != null)
                {
                    listProductos[n].Url = string.Format("assets/productos/{0}.jpg", listProductos[n].Url);
                }
            }


            return listProductos;


        }


       


    }
}
