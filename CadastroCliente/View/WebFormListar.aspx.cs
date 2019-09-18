using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CadastroCliente.View
{
    public partial class WebFormListar : System.Web.UI.Page
    {
        private async void Page_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:54618/api/clientes");

                var resposta = await client.GetAsync("");
                string dados = await resposta.Content.ReadAsStringAsync();

                List<View.ClientePOCO> clientes = new JavaScriptSerializer().Deserialize < List<View.ClientePOCO> > (dados);
                ListBox1.DataSource = clientes;
            }
        }



       

    }

}