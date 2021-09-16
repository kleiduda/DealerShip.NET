using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Interfaces
{
    public interface IOpcionaisRepository : IRepository<Opcionais>
    {
        Task<IEnumerable<Opcionais>> ObterOpcionaisPorVeiculo(int veiculoId);
    }
}
