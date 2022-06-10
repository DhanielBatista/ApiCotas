using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [Required(ErrorMessage = "Data de nascimento é Obrigatorio")]
        public DateTime DataNascimento { get; set; }
        [JsonIgnore]
        public virtual List<Operacao> Operacoes { get; set; }
       

    }
}
