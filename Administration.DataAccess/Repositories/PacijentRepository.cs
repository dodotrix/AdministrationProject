using Administration.DataAccess.Data;
using Administration.Domena.Models;
using Administration.Domena.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Administration.DataAccess.Repositories
{
    public class PacijentRepository : BaseRepository, IPacijentRepository
    {
        public PacijentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Pacijent>> ListAsync()
        {
            return await _context.Pacijenti.ToListAsync();
        }
    }
}
