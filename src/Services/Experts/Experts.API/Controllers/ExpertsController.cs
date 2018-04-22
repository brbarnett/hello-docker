using Experts.API.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Experts.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class ExpertsController : ControllerBase
    {

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Expert),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var item = new Expert{
                Id = 1,
                Name = "Brandon Barnett"
            };

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }
    }
}