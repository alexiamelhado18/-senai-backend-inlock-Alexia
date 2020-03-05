using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        private string stringConexao = "Data Source=DEV14\\SQLEXPRESS; initial catalog=InLock_Games_Manha; user Id=sa; pwd=sa@132";

        //private string stringConexao = "Data Source=DEV14\\SQLEXPRESS; initial catalog=Peoples; user Id=sa; pwd=sa@132";


        public JogosDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo Post onde cadastra Jogos
        /// </summary>
        /// <param name="jogo">Objeto</param>
        public void CadastrarJogos(JogosDomain jogo)
        {

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryCadastrar = "INSERT INTO Jogos (NomeJogo,Descricao,DataLancamento,Valor,IdEstudio)" +
                                        "VALUES (@NomeJogo,@Descricao,@DataLancamento,@Valor,@IdEstudio)";


                using (SqlCommand cmd = new SqlCommand(queryCadastrar, con))
                {
                    cmd.Parameters.AddWithValue("@NomeJogo", jogo.NomeJogo);
                    cmd.Parameters.AddWithValue("@Descricao", jogo.Descricao);
                    cmd.Parameters.AddWithValue("@DataLancamento", jogo.DataLancamento);
                    cmd.Parameters.AddWithValue("@Valor", jogo.Valor);
                    cmd.Parameters.AddWithValue("@IdEstudio", jogo.IdEstudio);

                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<JogosDomain> Listar()
        {
            List<JogosDomain> jogos = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection (stringConexao))
            {
                string queryListar = "SELECT IdJogo, NomeJogo, Descricao, DataLancamento, Valor, Estudios.NomeEstudio,Estudios.idEstudio FROM Jogos INNER JOIN Estudios ON Estudios.idEstudio = Jogos.idEstudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryListar, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogosDomain jogo = new JogosDomain
                        {
                            IdJogo = Convert.ToInt32(rdr["IdJogo"]),
                            NomeJogo = rdr["NomeJogo"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLancamento = rdr["DataLancamento"].ToString(),
                            Valor = Convert.ToDecimal(rdr["Valor"]),
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                            Estudio = new EstudioDomain
                            {
                                IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                                NomeEstudio = rdr["NomeEstudio"].ToString(),
                            }
                        };
                        jogos.Add(jogo);
                    }
                }
            }
            return jogos;
       }



    }
}
