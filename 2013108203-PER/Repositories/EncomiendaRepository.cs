﻿using _2013108203_ENT;
using _2013108203_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2013108203_PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        public EncomiendaRepository(DbContext context) : base(context)
        {
        }
    }
}
