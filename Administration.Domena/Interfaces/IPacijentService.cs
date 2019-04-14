using Administration.Domena.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Domena.Services
{
    public interface IPacijentService
    {
        Task<IEnumerable<Pacijent>> ListAsync();
        Task<Pacijent> GetByIdAsync(int id);
    }
}
