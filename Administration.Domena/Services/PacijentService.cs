﻿using System;
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

        public async Task AddPacijent(Pacijent pacijent)
        {
            await _pacijentRepository.AddPacijent(pacijent);
        }

        public async Task<Pacijent> GetByIdAsync(int id)
        {
            return await _pacijentRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Pacijent>> ListAsync()
        {
            return await _pacijentRepository.ListAsync();
        }

        public async Task RemovePacijent(int id)
        {
            await _pacijentRepository.RemovePacijent(id);
        }

        
    }
}
