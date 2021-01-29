using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string GetExplosion(string numbers)
        {
            var explosion = "";
            foreach (var number in numbers)
            {
                var numberAsInt = int.Parse(number.ToString());
                for (var i = 0; i < numberAsInt; i++)
                {
                    explosion += number;
                }
            }
            return explosion;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{characters}")]
        public string GetMumbling(string characters)
        {
            var mumble = "";
            for (var index = 0; index < characters.Length; index++)
            {
                mumble += characters[index].ToString().ToUpper();
                for (var count = 0; count < index; count++)
                {
                    mumble += characters[index].ToString().ToLower();
                }
                if (index < characters.Length - 1)
                {
                    mumble += "-";
                }
            }
            return mumble;
        }
    }
}