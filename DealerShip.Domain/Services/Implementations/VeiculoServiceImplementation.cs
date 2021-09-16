using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Models;
using DealerShip.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Services.Implementations
{
    public class VeiculoServiceImplementation : BaseService, IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;
        public VeiculoServiceImplementation(IVeiculoRepository veiculoRepository, INotificador notificador): base(notificador)
        {
            _veiculoRepository = veiculoRepository;
        }
        public async Task<bool> Cadastrar(Veiculo veiculo)
        {
            if (_veiculoRepository.Search(v=>v.Placa == veiculo.Placa).Result.Any())
            {
                Notificar("Já existe um veículo cadastrado com essa Placa!");
                return false;
            }
            await _veiculoRepository.Cadastrar(veiculo);
            return true;
        }
        public async Task Atualizar(Veiculo veiculo)
        {
            await _veiculoRepository.Update(veiculo);
        }
        public Task<List<Veiculo>> Listar()
        {
            throw new NotImplementedException();
        }

        public async Task Remover(int id)
        {
            await _veiculoRepository.Delete(id);
        }
        public void Dispose()
        {
            _veiculoRepository?.Dispose();
        }
    }
}
