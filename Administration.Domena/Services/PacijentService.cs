using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Administration.Domena.Models;
using Administration.Domena.Repositories;

namespace Administration.Domena.Services
{
    public class PacijentService : IPacijentService
    {
        private readonly IPacijentRepository _pacijentRepository;

        public PacijentService(IPacijentRepository pacijentRepository)
        {
            _pacijentRepository = pacijentRepository;
        }

        public async Task<IEnumerable<Pacijent>> ListAsync()
        {
            return await _pacijentRepository.ListAsync();
            
        }
    }
}
