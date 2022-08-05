using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventosAPI.Models;

namespace ProEventosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

      public IEnumerable<Evento> _evento = new Evento[] {
         new Evento(){
              EventoId = 1,
              Tema = "Angular 12 e .NET 5",
              Local = "São Paulo",
              Lote = "1º Lote",
              QtdPessoas = 250,
              DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
              ImagemUrl = "Perfil.png"
            },
            new Evento(){
              EventoId = 2,
              Tema = ".NET Framework",
              Local = "Rio de Janeiro",
              Lote = "3º Lote",
              QtdPessoas = 2655,
              DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
              ImagemUrl = "Foto.png"
            }
      };


        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
          return _evento.Where(evento => evento.EventoId == id);
        }
     }
}
