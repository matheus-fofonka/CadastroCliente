using System;
using System.Net.Http;
using CadastroCliente.Models;

namespace CadastroCliente.View
{
    public partial class WebFormHome : System.Web.UI.Page
    {
        string URI = "http://localhost:54618/api/clientes";
        int codigoUsuario = 1;

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

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
           
                Cliente cliente = new Cliente();
                cliente.Nome = TextBoxNome.Text;
                cliente.DataNascimento = Convert.ToDateTime(TextBoxNascimento.Text);
                cliente.Email = TextBoxEmail.Text ;
            ApiConnections.AddCliente(URI, cliente);
            
        }
    }

}