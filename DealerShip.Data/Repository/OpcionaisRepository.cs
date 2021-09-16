using DealerShip.Data.Context;
using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Data.Repository
{
    public class OpcionaisRepository : Repository<Opcionais>, IOpcionaisRepository
    {
        public OpcionaisRepository(SqlContext sqlContext): base(sqlContext)
        {

        }

        public async Task<IEnumerable<Opcionais>> ObterOpcionaisPorVeiculo(int veiculoId)
        {
            return await _sqlContext.Opcionais.AsNoTracking().Include(v => v.VeiculoNome).ToListAsync();
        }
    }
}
