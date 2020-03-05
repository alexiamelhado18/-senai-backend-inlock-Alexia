using Senai.InLock.WebApi.Domain;
using System.Collections.Generic;

namespace Senai.InLock.WebApi.Interfaces
{
    interface IEstudioRepository
    {
        List<EstudioDomain> Listar();


        void CadastarEstudio(EstudioDomain estudio);
    }
}
