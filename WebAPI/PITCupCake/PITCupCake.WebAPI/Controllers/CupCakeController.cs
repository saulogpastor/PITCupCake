using Microsoft.AspNetCore.Mvc;

using PITCupCake.WebAPI.Services;

namespace PITCupCake.WebAPI.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CupCakeController : ControllerBase
   {  
      private readonly ILogger<CupCakeController> _logger;

      public CupCakeController(ILogger<CupCakeController> logger) => _logger = logger;
      
      [HttpGet(Name = "GetCupCake")]
      public List<Model.CupCake> Get() => CupCakesServices.GetInstance().Listar();
   }
}