using CadastroCliente.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;

namespace CadastroCliente.API.Controllers
{
    [RoutePrefix("api/projeto")]
    public class DefaultController : ApiController
    {
        private string ConnectionString = "Data Source=DT-ROOM;Integrated Security=True;Initial Catalog=master";


        [HttpGet]
        [Route("clientes/todos")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                List<Cliente> lstClientes = new List<Cliente>();

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select id, nome, data_nascimento, email from clientes";

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente()
                            {
                                Id = reader["id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"] == DBNull.Value ? string.Empty : reader["nome"].ToString(),
                                DataNascimento = reader["data_nascimento"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["data_nascimento"]),
                                Email = reader["email"] == DBNull.Value ? string.Empty : reader["email"].ToString()
                            };

                            lstClientes.Add(cliente);
                        }
                    }

                    connection.Close();
                }

                return Request.CreateResponse(HttpStatusCode.OK, lstClientes.ToArray());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// Metodo para consultar detalhes de um determinado cliente

        [HttpGet]
        [Route("cliente/{id:int}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                Cliente cliente = null;

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select id, nome, data_nascimento, email from clientes where id = @id";
                        command.Parameters.AddWithValue("id", id);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            cliente = new Cliente()
                            {
                                Id = reader["id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"] == DBNull.Value ? string.Empty : reader["nome"].ToString(),
                                DataNascimento = reader["data_nascimento"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["data_nascimento"]),
                                Email = reader["email"] == DBNull.Value ? string.Empty : reader["email"].ToString()
                            };
                        }
                    }

                    connection.Close();
                }

                return Request.CreateResponse(HttpStatusCode.OK, cliente);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// Metodo para excluir um determinado cliente

        [HttpDelete]
        [Route("cliente/{id:int}")]
        public HttpResponseMessage DeleteById(int id)
        {
            try
            {
                bool resultado = false;

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "delete from clientes where id = @id";
                        command.Parameters.AddWithValue("id", id);

                        int i = command.ExecuteNonQuery();
                        resultado = i > 0;
                    }

                    connection.Close();
                }

                return Request.CreateResponse(HttpStatusCode.OK, resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// Metodo para cadastrar um novo cliente
        /// formato json para inserir
        /*
            {"Nome":"Matheus Fofonka",
             "DataNascimento":"10-06-1999T00:00:00",
             "Email":"matheus.fofonka@gmail.com"}
        */
        [HttpPost]
        [Route("cliente")]
        public HttpResponseMessage Post(Cliente cliente)
        {
            try
            {
                bool resultado = false;

                if (cliente == null) throw new ArgumentNullException("cliente");

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "insert into clientes(nome, data_nascimento, email) values(@nome, @data_nascimento, @email)";

                        command.Parameters.AddWithValue("nome", cliente.Nome);
                        command.Parameters.AddWithValue("data_nascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("email", cliente.Email);

                        int i = command.ExecuteNonQuery();
                        resultado = i > 0;
                    }

                    connection.Close();
                }

                return Request.CreateResponse(HttpStatusCode.OK, resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// Metodo para atualizar os dados de um determinado cliente

        [HttpPut]
        [Route("cliente/{id:int}")]
        public HttpResponseMessage Put(int id, Cliente cliente)
        {
            try
            {
                bool resultado = false;

                if (cliente == null) throw new ArgumentNullException("cliente");
                if (id == 0) throw new ArgumentNullException("id");

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "update clientes set nome = @nome, data_nascimento = @data_nascimento, email = @email where id = @id";

                        command.Parameters.AddWithValue("id", id);
                        command.Parameters.AddWithValue("nome", cliente.Nome);
                        command.Parameters.AddWithValue("data_nascimento", cliente.DataNascimento);
                        command.Parameters.AddWithValue("email", cliente.Email);

                        int i = command.ExecuteNonQuery();
                        resultado = i > 0;
                    }

                    connection.Close();
                }

                return Request.CreateResponse(HttpStatusCode.OK, resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
