using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_deliverit.Core.Data.Context;
using test_deliverit.Core.Domain.Entities;
using test_deliverit.Core.Domain.Interfaces.Services;

namespace test_deliverit.Api_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasPagarController : ControllerBase
    {
        public IContaPagarService _service { get; set; }
        public ContasPagarController(IContaPagarService service)
        {
            _service = service;
        }

        // GET: api/ContasPagar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaPagarEntity>>> GetAllContaPagar()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (System.Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // GET: api/ContasPagar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaPagarEntity>> GetContaPagar(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // PUT: api/ContasPagar/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaPagar(Guid id, ContaPagarEntity contaPagar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(contaPagar);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // POST: api/ContasPagar
        [HttpPost]
        public async Task<ActionResult<ContaPagarEntity>> PostContaPagar(ContaPagarEntity contaPagar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(contaPagar);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetContaPagar", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // DELETE: api/ContasPagar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContaPagar(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
