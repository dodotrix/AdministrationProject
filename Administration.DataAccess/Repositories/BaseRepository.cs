using Administration.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Administration.DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
