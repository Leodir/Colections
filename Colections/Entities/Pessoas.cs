using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections.Entities
{
    public abstract class Pessoas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PessoasId { get; set; }
        [Required, MaxLength(100)]
        public string PessoaNome { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Web { get; set; }
        [MaxLength(11)]
        public string PessoaCep { get; set; }
        [MaxLength(3)]
        public string PessoaUF { get; set; }
        [MaxLength(80)]
        public string PessoaCidade { get; set; }
        [MaxLength(80)]
        public string PessoaBairro { get; set; }
        [MaxLength(100)]
        public string PessoaLogradouro { get; set; }
        public int PessoaNumero { get; set; }
        [MaxLength(100)]
        public string PessoaComplemento { get; set; }
        [Required,MaxLength(20)]
        public string PessoaCelular1 { get; set; }
        [MaxLength(20)]
        public string PessoaCelular2 { get; set; }
        [MaxLength(20)]
        public string PessoaTelefone { get; set; }
    }
}

