using Microsoft.AspNetCore.Mvc;
using System;

namespace SmartSchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                throw new Exception("Teste exception");
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
