using Senai.InLock.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    interface IJogosRepository
    {
        List<JogosDomain> Listar();

        JogosDomain BuscarPorId(int id);
        
        void CadastrarJogos(JogosDomain jogo);

        
    }
}
