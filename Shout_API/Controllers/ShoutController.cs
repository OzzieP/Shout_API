using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shout_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shout_API.Controllers
{
    [Route("api/shout")]
    [ApiController]
    public class ShoutController : ControllerBase
    {
        // POST api/shout
        [HttpPost]
        public string Post([FromBody] Chaine chaine)
        {
            return chaine.Libelle;
        }
    }
}
