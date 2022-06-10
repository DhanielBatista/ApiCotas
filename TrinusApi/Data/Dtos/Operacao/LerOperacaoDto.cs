using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Data.Dtos.Operacao
{
    public class LerOperacaoDto
    {
        public int CotistaId { get; set; }
        public DateTime DataOperacao { get; set; }
        [Range(0, 1, ErrorMessage = "Os Tipos de Operação aceitos são: 0 compra e 1 venda.")]
        public int TipoOperacao { get; set; }
        public int Cotas { get; set; }
        public string ValorCota { get; set; }
        
    }
}
