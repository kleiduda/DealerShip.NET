using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Interfaces
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        Task<IEnumerable<Veiculo>> ObterVeiculosPorMarca(int marcaId);
        Task<IEnumerable<Veiculo>> ObterTodosVeiculos();
        Task<IEnumerable<Veiculo>> ObterVeiculoOpcional(int id);
        Task<Veiculo> ObterVeiculoPorPlaca(string placa);
    }
}
