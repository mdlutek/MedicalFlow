using MedicalFlow.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicalFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HealthController : ControllerBase
    {
        [HttpGet]
        public ActionResult<HealthDto> KnockKnock()
        {
            var result = new HealthDto()
            {
                Status = "OK",
                // Zawsze używamy czasu uniwersalnego UTC na serwerze
                DateTime = DateTime.Now,
            };

            return Ok(result);
        }
    }
}
