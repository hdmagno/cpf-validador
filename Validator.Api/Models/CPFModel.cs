using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validator.Api.Models
{
    public class CPFModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "{1} é obrigatório.")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "CPF deve conter {2} digitos.")]
        public string Cpf { get; set; }
    }
}