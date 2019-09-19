using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using CadastroCliente.Models;

namespace CadastroCliente.View
{
    public class ApiConnections
    {
                public static async void AddCliente(string URI, Cliente cliente)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var serializedUsuario = JsonConvert.SerializeObject(cliente);
                    var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(URI, content);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-------------------------------------------------
        public static async void UpdateCliente(string URI, Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + cliente.Id, cliente);
                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception("Falha ao atualizar o usuário : " + responseMessage.StatusCode);
                }
            }
        }
        //-----------------------------------------------------------
                public static async void ProcurarClienteNome(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                string URI = "http://localhost:54618/api/clientes/pesquisa/nome";
                client.BaseAddress = new Uri(URI);                
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                    JsonConvert.DeserializeObject<Cliente>(UsuarioJsonString);
                }
                else
                {
                throw new Exception("Falha ao procurar o usuário pelo nome : " + response.StatusCode);
                }
            }
        }

        //-----------------------------------------------------------
        public static async void ProcurarClienteEmail(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                string URI = "http://localhost:54618/api/clientes/pesquisa/email";
                client.BaseAddress = new Uri(URI);                
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                    JsonConvert.DeserializeObject<Cliente>(UsuarioJsonString);
                }
                else
                {
                throw new Exception("Falha ao procurar o usuário pelo email : " + response.StatusCode);
                }
            }
        }
    }


}
