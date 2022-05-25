using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validator.Api.Models;
using Validator.Api.Services;

namespace Validator.Api.Controllers
{
    [ApiController]
    [Route("api/cpf")]
    public class CPFController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CPFValidator([FromBody] CPFModel model)
        {
            if (!CPFService.IsValid(model))
                return BadRequest(new { message = "CPF inválido" });

            return Ok(new { message = $"O CPF {model.Cpf} é válido" });
        }
    }
}