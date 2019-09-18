using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}