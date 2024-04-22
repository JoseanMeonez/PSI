﻿using Microsoft.AspNetCore.Mvc;
using PSI.Application.Features.Customer.Queries.GetById;

namespace PSI.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
	// GET: api/<CustomerController>
	[HttpGet]
	public IEnumerable<string> Get()
		=> new string[] { "value1", "value2" };

	// GET api/<CustomerController>/5
	[HttpGet("{id}")]
	public async Task<IActionResult> Get(int id)
		=> Ok(await Mediator.Send(new GetCustomerByIdQuery(id)));

	// POST api/<CustomerController>
	[HttpPost]
	public void Post([FromBody] string value)
	{
	}

	// PUT api/<CustomerController>/5
	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{
	}

	// DELETE api/<CustomerController>/5
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
	}
}