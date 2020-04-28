using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace minhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int  Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(60,MinimumLength = 3,ErrorMessage ="O titulo precisa ter entre 3 e 60 caracteres.")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto.")]
        [Required(ErrorMessage = "O Campo data Lançamento é obrigatório")]
        [Display(Name="Data Lançamento")]
        public DateTime DataLancamento { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Genero em formato inválido")]
        [StringLength(30, ErrorMessage = "Maximo de 30 caracteres"), Required(ErrorMessage ="O Campo é obrigatório")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor entre 1 e 1000")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public decimal Valor { get; set; }


        [Range(1, 5, ErrorMessage = "Valor entre 1 e 5")]
        public int Avaliacao { get; set; }



    }
}
