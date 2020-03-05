namespace Senai.InLock.WebApi.Domain
{
    public class JogosDomain
    {

        public int IdJogo { get; set; }

        public string NomeJogo { get; set; }

        public string Descricao { get; set; }
        
        public string DataLancamento { get; set; }

        public decimal Valor { get; set; }

        public int IdEstudio { get; set; }

        public EstudioDomain Estudio { get; set; }


    }
}
