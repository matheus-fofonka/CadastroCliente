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
                public async void ProcurarClienteNome( string nome)
        {

            using (var client = new HttpClient())
            {
                string URI = "http://localhost:54618/api/clientes/nome/"+ nome;
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
        public  async void ProcurarClienteEmail(string email)
        {
            using (var client = new HttpClient())
            {
                string URI = "http://localhost:54618/api/clientes/email/" + email;
                client.BaseAddress = new Uri(URI);                
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    Cliente cliente = new Cliente();
                    var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                    cliente  = JsonConvert.DeserializeObject<Cliente>(UsuarioJsonString);
                    // Tentar retornar por string e deserializar na webPesquisa
                    Pesquisa.Gamb(cliente);
                    
                }
                else
                {
                throw new Exception("Falha ao procurar o usuário pelo email : " + response.StatusCode);
                }
            }
        }
        

    }


}
