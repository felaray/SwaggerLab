using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerLab.Model;
using Swashbuckle.AspNetCore.Annotations;

namespace SwaggerLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabController : ControllerBase
    {
        // GET: api/Lab
        [HttpGet]
        public List<User> Get()
        {
            return new List<User> { new Model.User() };
        }

        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Lab/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lab
        [HttpPost]
        public void Post([FromBody]User value)
        {
        }

        // PUT: api/Lab/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
