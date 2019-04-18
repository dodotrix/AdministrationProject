using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Administration.Domena.Models;
using Administration.Domena.Services;
using Microsoft.AspNetCore.Mvc;

namespace Administration.WebAPI.Controllers
{
    [Route("/api/[controller]")]
    public class PacijentController : Controller
    {
        private readonly IPacijentService _pacijentService;

        public PacijentController(IPacijentService pacijentService)
        {
            _pacijentService = pacijentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Pacijent>> GetAllAsync()
        {
            var pacijenti = await _pacijentService.ListAsync();
            return pacijenti;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pacijent>> GetById(int id)
        {
            var pacijent = await _pacijentService.GetByIdAsync(id);
            if (pacijent == null)
                return NoContent();
            return pacijent;
        }

        [HttpPost("{addPacijent}")]
        public async Task<IActionResult> AddPacijent([FromBody] Pacijent pacijent)
        {
            await _pacijentService.AddPacijent(pacijent);
            return Ok();
        }

    }
}