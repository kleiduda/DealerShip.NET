using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Services.Interfaces
{
    public interface IMarcaService : IDisposable
    {
        Task<bool> Cadastrar(Marca marca);
        Task<bool> Atualizar(Marca marca);
        Task<bool> Remover(int id);
    }
}
