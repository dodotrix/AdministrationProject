using Administration.Domena.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Domena.Repositories
{
    public interface IPacijentRepository
    {
        Task<IEnumerable<Pacijent>> ListAsync();
    }
}
