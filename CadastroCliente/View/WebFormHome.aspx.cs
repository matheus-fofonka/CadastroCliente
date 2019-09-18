using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroCliente.View
{
    public partial class WebFormHome : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormPesquisa.aspx");
        }

        protected void ButtonListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormListar.aspx");
        }

        private async void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:54618/api/clientes");

                ClientePOCO clientePOCO = new ClientePOCO();
                clientePOCO.nome = TextBoxNome.Text;
                clientePOCO.dataNascimento = Convert.ToDateTime(TextBoxNascimento.Text);
                clientePOCO.email = TextBoxEmail.Text ;

                var resposta =await client.PostAsJsonAsync("", clientePOCO);
            }
        }
    }

    public class ClientePOCO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
    }
}