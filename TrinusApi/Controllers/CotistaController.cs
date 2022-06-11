using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TrinusApi.Data;
using TrinusApi.Data.Dtos;
using TrinusApi.Data.Dtos.Cotista;
using TrinusApi.Models;

namespace TrinusApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotistaController : Controller
    {
        private Context _context;
        private IMapper _mapper;

        public CotistaController(Context context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AdicionaCotista([FromBody] CriarCotistaDto cotistaDto)
        {
            Cotista cotista = _mapper.Map<Cotista>(cotistaDto);
            _context.Cotistas.Add(cotista);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscarCotistaPorId), new { Id = cotista.Id }, cotista);
        }
        [HttpGet]
        public IActionResult BuscarCotista()
        {
            List<Cotista> cotistas = _context.Cotistas.ToList();
            List<LerCotistaDto> lerCotistaDtos = _mapper.Map<List<LerCotistaDto>>(cotistas);
            return Ok(lerCotistaDtos);
        }
        [HttpGet("{id}")]
        public IActionResult BuscarCotistaPorId(int id)
        {
            Cotista cotista = _context.Cotistas.FirstOrDefault(cotista => cotista.Id == id);
            if(cotista != null)
            {
                LerCotistaDto cotistaDto = _mapper.Map<LerCotistaDto>(cotista);
                return Ok(cotistaDto);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaCotista(int id, [FromBody] AtualizarCotistaDto cotistaDto)
        {
            Cotista cotista = _context.Cotistas.FirstOrDefault(cotista => cotista.Id == id);
            if(cotista == null)
            {
                return NotFound();
            }
            _mapper.Map(cotistaDto,cotista);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeletaCotista(int id)
        {
            Cotista cotista = _context.Cotistas.FirstOrDefault(cotista=> cotista.Id == id);
            if(cotista == null)
            {
                return NotFound();
            }
            _context.Remove(cotista);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
