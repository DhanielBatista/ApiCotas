using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Models
{
    public class Cotista
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
