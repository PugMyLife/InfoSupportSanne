using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveJSONController : ControllerBase
    {
        // POST: api/CursusDetails
        [HttpPost]
        public string JsonStringBody(ContentClass content)
        {

            return content.Content;
        }


        public class ContentClass { public string Content { get; set; } public string Block { get; set; } }
    }
}
