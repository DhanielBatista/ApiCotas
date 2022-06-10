using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TrinusApi.Data;
using TrinusApi.Data.Dtos.Operacao;
using TrinusApi.Data.Dtos.OperacaoDto;
using TrinusApi.Models;

namespace TrinusApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : Controller
    {
        private Context _context;
        private IMapper _mapper;

        public OperacaoController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaOperacao([FromBody] CriarOperacaoDto operacaoDto)
        {
            Operacao operacao = _mapper.Map<Operacao>(operacaoDto);
            _context.Operacoes.Add(operacao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscarOperacoesPorId), new { Id = operacao.Id }, operacao);
        }

        [HttpGet]
        public IActionResult BuscarOperacoes()
        {
            List<Operacao> operacoes = _context.Operacoes.ToList();
            List<LerOperacaoDto> lerOperacoesDtos = _mapper.Map<List<LerOperacaoDto>>(operacoes);
            return Ok(lerOperacoesDtos);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarOperacoesPorId(int id)
        {
            Operacao operacao = _context.Operacoes.FirstOrDefault(operacao => operacao.Id == id);
            if (operacao != null)
            {
                LerOperacaoDto operacaoDto = _mapper.Map<LerOperacaoDto>(operacao);
                return Ok(operacaoDto);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaOperacao(int id, [FromBody] AtualizarOperacaoDto operacaoDto)
        {
            Operacao operacao = _context.Operacoes.FirstOrDefault(operacao => operacao.Id == id);
            if (operacao == null)
            {
                return NotFound();
            }
            _mapper.Map(operacaoDto, operacao);
            _context.SaveChanges();
            return Ok("Deu bom cla");
        }
        [HttpDelete]
        public IActionResult DeletaOperacao(int id)
        {
            Operacao operacao = _context.Operacoes.FirstOrDefault(operacao=>operacao.Id == id);
            if(operacao == null)
            {
                return NotFound();
            }
            _context.Remove(operacao);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
