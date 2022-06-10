using System;
using System.ComponentModel.DataAnnotations;

namespace TrinusApi.Data.Dtos.Cotista
{
    public class CriarCotistaDto
    {
        [Required(ErrorMessage = "Nome do cotista é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Cpf é Obrigatorio")]
        public string Cpf { get; set; }
        [Required(ErrorMessage ="Data de Nascimento é obrigatoria")]
        public DateTime DataNascimento { get; set; }
    }
}
