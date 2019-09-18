using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CadastroCliente.Classes;

namespace CadastroCliente.API
{
    public class ConsomeAPI
    {
        public static class ConsomeApi
        {
            public static async Task<List<Cliente>> GetUsuarios(string URI)
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject<Cliente[]>(UsuarioJsonString).ToList();
                        }
                        else
                        {
                            throw new Exception("Não foi possível obter o usuário : " + response.StatusCode);
                        }
                    }
                }
            }
        }
    }
}