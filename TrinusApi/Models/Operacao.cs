using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Models
{
    public class Operacao
    {
        public int Id { get; set; }
        public virtual Cotista Cotista { get; set; }
        public int CotistaId { get; set; }
        public DateTime DataOperacao { get; set; } = DateTime.Now;
        [Range(0, 1, ErrorMessage = "Os Tipos de Operação aceitos são: 0 compra e 1 venda.")]
        public int TipoOperacao { get; set; }
        public double Cotas { get; set; }
        public double ValorCota { get; set; } = double.Parse((120 + Math.Log2(DateTime.Now.Minute) - Math.Log(3) + 1).ToString("F2"));
       
        
    }
}
