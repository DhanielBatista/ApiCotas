using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Data.Dtos.Cotista
{
    public class LerCotistaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do cotista é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Cpf é Obrigatorio")]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
