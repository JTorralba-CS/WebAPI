using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//MinLength
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[]
        //    {
        //        "ID",
        //        "First",
        //        "Last",
        //        "Phone"
        //    };
        //}

        // GET api/<controller>/NNNNNN
        //[HttpGet("{ID:int=123456}")]
        //public string Get(int ID, string First, string Last, string Phone)
        //{
        //    return $"ID = {ID}, First = {First}, Last = {Last}, Phone = {Phone}";
        //}

        // GET api/<controller>/NNNNNN
        [HttpGet("{ID:int=000000}")]
        public IActionResult Get(int ID, string First, string Last, string Phone)
        {
            return Ok(new Record { ID = ID, First = First, Last = Last, Phone = Phone });
        }

        // POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody] Record Data)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        throw new InvalidOperationException("MinLength < 3");
        //    }
        //}

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] Record Data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { ID = Data.ID }, Data);
        }

        // PUT api/<controller>/NNNNNN
        [HttpPut("{ID}")]
        public void Put(int ID, [FromBody] Record Data)
        {
        }

        // DELETE api/<controller>/NNNNNN
        [HttpDelete("{ID}")]
        public void Delete(int ID)
        {
        }
    }

    public class Record
    {
        public int ID { get; set; }

        [MinLength(1)]
        public string First { get; set; }
        [MinLength(1)]
        public string Last { get; set; }
        [MinLength(10)]
        public string Phone { get; set; }
    }

}
