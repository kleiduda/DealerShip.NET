using DealerShip.Data.Context;
using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Data.Repository
{
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        public MarcaRepository(SqlContext sqlContext): base(sqlContext) { }

        public async Task<IEnumerable<Marca>> ObterMarcas()
        {
            return await _sqlContext.Marcas.AsNoTracking().ToListAsync();
        }
    }
}
