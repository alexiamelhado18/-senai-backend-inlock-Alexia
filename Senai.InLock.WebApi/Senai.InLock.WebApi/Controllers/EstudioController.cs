using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }
        /// <summary>
        /// Metodo para cadastrar Estudio
        /// </summary>
        /// <param name="estudio"></param>
        /// <returns>retorna um Estudio cadsatrado</returns>
        [HttpPost]
       public IActionResult CadastrarEstudio(EstudioDomain estudio)
        {
            _estudioRepository.CadastarEstudio(estudio);
            return Created("http://localhost:5000/api/Estudio", estudio);
        }
    }
}