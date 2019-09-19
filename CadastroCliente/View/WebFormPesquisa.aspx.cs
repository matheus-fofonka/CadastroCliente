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
        private string ConnectionString = "Data Source=DT-ROOM;Integrated Security=True;Initial Catalog=master";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (RadioButtonNome.Checked)
            {
                cliente.Nome = TextBox1.Text;

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select id, nome, data_nascimento, email from clientes where nome = @nome";
                        command.Parameters.AddWithValue("nome", cliente.Nome);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cliente.Id = reader["id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id"]);                                                       
                        }
                    }
                    connection.Close();
                }

            }
            if (RadioButtonEmail.Checked)
            {
                cliente.Email = TextBox1.Text;

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select id, nome, data_nascimento, email from clientes where email = @email";
                        command.Parameters.AddWithValue("email", cliente.Email);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cliente.Id = reader["id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id"]);
                        }
                    }
                    connection.Close();
                }

             
            }
            Response.Redirect("http://localhost:54618/api/clientes/" + cliente.Id);
        }

        protected void ChangePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}