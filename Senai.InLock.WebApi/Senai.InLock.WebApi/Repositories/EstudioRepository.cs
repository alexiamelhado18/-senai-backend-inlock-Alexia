using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private string stringConexao = "Data Source=LAB104701\\SQLEXPRESS02; initial catalog=InLock_Games_Manha; user Id=sa; pwd=132";


        /// <summary>
        /// Método onde cadastra um novo Estúdio
        /// </summary>
        /// <param name="estudio">Objeto Estúdio que será cadastrado</param>
        public void CadastarEstudio(EstudioDomain estudio)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryCadastrar = "INSERT INTO Estudios (NomeEstudio) VALUES (@NomeEstudio)";

                using (SqlCommand cmd = new SqlCommand(queryCadastrar, con))
                {
                    cmd.Parameters.AddWithValue("@NomeEstudio", estudio.NomeEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();

                }
            }
         }


        /// <summary>
        /// Método que gera uma lista de estúdios
        /// </summary>
        /// <returns>Retorna lista de Estúdios</returns>
        public List<EstudioDomain> Listar() 
        {
            List<EstudioDomain> estudios = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryListarEstudio = "SELECT Estudios.IdEstudio, Estudios.NomeEstudio FROM Estudios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListarEstudio,con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain
                        {
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                            NomeEstudio = rdr["NomeEstudio"].ToString()
                        };
                        estudios.Add(estudio);
                    }
                }
                return estudios;
            }
        }


    }
}
