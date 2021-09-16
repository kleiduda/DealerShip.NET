using DealerShip.Data.Context;
using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DealerShip.Data.Repository
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(SqlContext sqlContext): base(sqlContext)
        {

        }

        public async Task<IEnumerable<Veiculo>> ObterTodosVeiculos()
        {
            throw new NotImplementedException();
            //return await _sqlContext.Veiculos.Include(m => m.MarcaId).AsNoTracking().ToListAsync();
        }

        public Task<IEnumerable<Veiculo>> ObterVeiculoOpcional(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Veiculo> ObterVeiculoPorPlaca(string placa)
        {
            return await _sqlContext.Veiculos.AsNoTracking().FirstOrDefaultAsync(v=>v.Placa == placa);
        }

        public async Task<IEnumerable<Veiculo>> ObterVeiculosPorMarca(int marcaId)
        {
            throw new NotImplementedException();
        }
    }
}
