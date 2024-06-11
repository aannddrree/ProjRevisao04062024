using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjRevisao04062024.Models;
using Services;

namespace ProjRevisao.TerraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerraController : ControllerBase
    {

        [HttpGet]
        public List<Terra> Get()
        {
            TerraService terraService = new TerraService();
            return terraService.GetAll();
        }
    }
}
