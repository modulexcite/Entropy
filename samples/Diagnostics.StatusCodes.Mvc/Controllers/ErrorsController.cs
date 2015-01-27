using Microsoft.AspNet.Mvc;

namespace Diagnostics.StatusCodes.Mvc.Controllers
{
    public class ErrorsController : Controller
    {
        [Route("errors/{id:int}")]
        public IActionResult Index(int id)
        {
            return new ObjectResult("Error page, status code: " + id) { StatusCode = id };
        }
    }
}