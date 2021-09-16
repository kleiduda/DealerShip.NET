using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Interfaces
{
    public interface IMarcaRepository : IRepository<Marca>
    {
        Task<IEnumerable<Marca>> ObterMarcas();
    }
}
