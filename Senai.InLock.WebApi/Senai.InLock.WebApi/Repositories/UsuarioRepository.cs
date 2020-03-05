using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioDomain BuscarPorConta(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
