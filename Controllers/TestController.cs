using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SwaggerLab.Data;
using SwaggerLab.Model;

namespace SwaggerLab.Controllers
{
    [Route("api/user/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly SwaggerLabContext _context;

        public TestController(SwaggerLabContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Get()
        {
            var result = _context.User.FirstOrDefault();
            return Ok(result);
        }


        [HttpPost]
        public IActionResult Add(User model)
        {
            _context.User.Add(model);
            _context.SaveChanges();
            return Ok();
        }

        /// <summary>
        /// 使用 JsonPatchDocument 進行資料的部分更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patchDoc"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, JsonPatchDocument<User> patchDoc)
        {
            if (patchDoc != null)
            {
                var customer = await _context.User.FindAsync(id);

                patchDoc.ApplyTo(customer, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.SaveChanges();

                return new ObjectResult(customer);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        //// GET: api/Test
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Test/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Test
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Test/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
