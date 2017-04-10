using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ValidationSQLApiModel.Controllers
{
    [Route("api/[controller]")]
    public class SQLValidationController : Controller
    {
	private readonly ISQLDBRepository repository;
	
	public SQLValidationController(ISQLDBRepository repository)
	{
		this.repository = repository;
	}
		
        // GET api/values
        [HttpGet]
	public IEnumerable<PropertySql> GetAll()
        {
		return repository.GetAll();
        }

        // GET api/values/5
	[HttpGet("{id}", Name = "GetById")]
	public IActionResult GetById(long id)
        {
		var item = repository.Find(id);

		if (item == null)
		{
			return NotFound();
		}

		return new ObjectResult(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
	public void Put(long id, [FromBody]PropertySql sql)
        {
		repository.Update(sql);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
		repository.Remove(id);
        }
	
	[HttpPost]
	public IActionResult Create([FromBody]PropertySql sql) {
		if(sql == null) {
			return BadRequest();
		}

		repository.Add(sql);

		return CreatedAtAction(actionName: "GetById", routeValues: new { id = sql.Id },value: sql);
	}
    }
}
