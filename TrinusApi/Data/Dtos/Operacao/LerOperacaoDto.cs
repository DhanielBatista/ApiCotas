using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Data.Dtos.Operacao
{
    public class LerOperacaoDto
    {
        public int Id { get; set; }
        public int CotistaId { get; set; }
        public DateTime DataOperacao { get; set; } 
        public int TipoOperacao { get; set; }
        public int Cotas { get; set; }
        public double ValorCota { get; set; } 
        
    }
}
