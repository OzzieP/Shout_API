using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shout_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UpperString;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shout_API.Controllers
{ 
    [EnableCors("Cors")]
    public class ShoutController : Controller
    {
        // POST api/shout
        [HttpPost]
        public string Index(string chaine)
        {
            return StringLibrary.StringToUpper(chaine);
        }
    }
}
