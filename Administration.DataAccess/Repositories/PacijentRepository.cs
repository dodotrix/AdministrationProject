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

        public async Task<Pacijent> GetByIdAsync(int id)
        {
            return await _context.Pacijenti.FindAsync(id);
        }

        public async Task<IEnumerable<Pacijent>> ListAsync()
        {
            return await _context.Pacijenti.ToListAsync();
        }

        public async Task AddPacijent(Pacijent pacijent)
        {
            _context.Pacijenti.Add(pacijent);
            await _context.SaveChangesAsync();
        }
    }
}
