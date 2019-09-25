using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadastroCliente.Models;


namespace CadastroCliente.View
{
    public partial class WebFormPesquisa : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ApiConnections api = new ApiConnections();
            if (RadioButtonNome.Checked && TextBoxPesquisa.Text != "")
            {
                api.ProcurarClienteNome(TextBoxPesquisa.Text);
                

            }
            if (RadioButtonEmail.Checked && TextBoxPesquisa.Text != "")
            {
                cliente.Email = TextBoxPesquisa.Text;
                api.ProcurarClienteEmail(TextBoxPesquisa.Text);
                

                    LabelNome.Text = cliente.Nome;
                    LabelEmail.Text = cliente.Email;
                    LabelNasc.Text = (cliente.DataNascimento).ToString();
                    

                
            }
           // Response.Redirect("http://localhost:54618/api/clientes/" + cliente.Id);
        }
        
    }
    
}