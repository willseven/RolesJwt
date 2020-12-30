using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Cursos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //  Http://localhost:5000/api/Cursos
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : MiControllerBase
    {
        // private readonly IMediator _mediator;
        // public CursosController(IMediator mediator){
        //     _mediator = mediator;
        // }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<List<CursoDto>>> Get()
        {

            return await Mediator.Send(new Consulta.ListaCursos());

        }
        // Http://localhost:5000/api/Cursos/{id}
        // Http://localhost:5000/api/Cursos/1

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoDto>> Detalle(Guid id)
        {
            return await Mediator.Send(new ConsultaPorId.CursoUnico { Id = id });
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await Mediator.Send(data);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Editar(Guid id, Editar.Ejecuta data)
        {
            data.CursoId = id;
            return await Mediator.Send(data);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Eliminar(Guid id)
        {
            return await Mediator.Send(new Eliminar.Ejecuta { Id = id });
        }
    }
}