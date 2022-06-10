using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Data.Dtos.OperacaoDto
{
    public class CriarOperacaoDto
    {
        public int CotistaId { get; set; }
        [Range(0, 1, ErrorMessage = "Os Tipos de Operação aceitos são: 0 compra e 1 venda.")]
        public int TipoOperacao { get; set; }
        public int Cotas { get; set; }
        
    }
}
