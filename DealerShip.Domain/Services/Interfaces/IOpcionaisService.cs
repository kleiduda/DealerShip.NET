using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Services.Interfaces
{
    public interface IOpcionaisService : IDisposable
    {
        Task<bool> Cadastrar(Opcionais opcionais);
        Task<bool> Atualizar(Opcionais opcionais);
        Task<bool> Remover(int id);
    }
}
