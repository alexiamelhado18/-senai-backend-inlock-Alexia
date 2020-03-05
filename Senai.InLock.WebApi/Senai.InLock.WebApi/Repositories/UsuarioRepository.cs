using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source=LAB104701\\SQLEXPRESS02; initial catalog=InLock_Games_Manha; user Id=sa; pwd=132";

        public UsuarioDomain BuscarPorConta(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {

                string queryBuscarporConta = "SELECT idUsuario, Email, Usuario.idTipoUsuario, TipoUsuario.Titulo FROM Usuario" +
                                             "INNER JOIN TipoUsuario ON Usuario.idTipoUsuario = TipoUsuario.idTipoUsuario " +
                                             "WHERE Usuario.Email = 'admin@admin.com' AND Usuario.Senha = 'admin'";

                using (SqlCommand cmd = new SqlCommand(StringConexao, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();


                    if (rdr.Read())
                    {

                        UsuarioDomain usuario = new UsuarioDomain
                        {

                            idUsuario = Convert.ToInt32(rdr["idUsuario"])
                            ,
                            Email = rdr["Email"].ToString()
                            ,
                            IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"])
                            ,
                            TipoUsuario = new TipoUsuarioDomain
                            {
                                IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"])
                                ,
                                Titulo = rdr["Titulo"].ToString()
                            }
                        };

                        return usuario;
                    }
                }

                return null;
            }
        }

        public List<UsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
