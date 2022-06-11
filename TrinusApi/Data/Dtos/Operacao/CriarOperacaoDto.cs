using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Data.Dtos.OperacaoDto
{
    public class CriarOperacaoDto
    {
        [Required(ErrorMessage = "O Id do Cotista é Obrigatorio")]
        public int CotistaId { get; set; }
        [Range(0, 1, ErrorMessage = "Os Tipos de Operação aceitos são: 0 compra e 1 venda.")]
        public int TipoOperacao { get; set; }
        [Required(ErrorMessage = "A quantidade de Cotas é Obrigatorio")]
        public int Cotas { get; set; }
        
    }
}
