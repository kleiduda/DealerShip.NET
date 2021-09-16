using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Services.Interfaces
{
    public interface IVeiculoService : IDisposable
    {
        Task<bool> Cadastrar(Veiculo veiculo);
        Task Atualizar(Veiculo veiculo);
        Task Remover(int id);
        Task<List<Veiculo>> Listar();
    }
}
