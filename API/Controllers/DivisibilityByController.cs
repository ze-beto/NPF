using Microsoft.AspNetCore.Mvc;
using NPF.BusinessLogic;
using NPF.Model;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisibilityByController : ControllerBase
    {
        [HttpPost]
        public List<Response> CheckDivisibility([FromBody] List<string> collection)
        {
            List<Response> response = new();

            foreach (var item in collection)
            {
                response.Add(new Response()
                {
                    Number = item,
                    IsMultiple = Divisibility.By11(item)
                });
            }

            return response;
        }
    }
}
