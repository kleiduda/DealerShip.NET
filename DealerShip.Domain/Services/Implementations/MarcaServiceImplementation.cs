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
    public class MarcaServiceImplementation : BaseService, IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;
        private readonly IVeiculoRepository _veiculoRepository;
        public MarcaServiceImplementation(IMarcaRepository marcaRepository, IVeiculoRepository veiculoRepository, INotificador notificador) : base(notificador)
        {
            _marcaRepository    = marcaRepository;
            _veiculoRepository  = veiculoRepository;
        }
        public async Task<bool> Cadastrar(Marca marca)
        {
            //
            //implementar umas validacoes aqui
            //
            if (_marcaRepository.Search(m => m.NomeMarca == marca.NomeMarca).Result.Any())
            {
                Notificar("Já existe uma marca com esse nome!");
                return false;
            }
            await _marcaRepository.Cadastrar(marca);
            return true;
        }
        public async Task<bool> Atualizar(Marca marca)
        {
            if (_marcaRepository.Search(m => m.NomeMarca == marca.NomeMarca).Result.Any())
            {
                Notificar("Ja existe uma marca com esse nome!");
                return false;
            }
            await _marcaRepository.Update(marca);
            return true;
        }
        public async Task<bool> Remover(int id)
        {
            if (_veiculoRepository.ObterVeiculosPorMarca(id).Result.Any())
            {
                Notificar("Existem Veículos cadastrados nessa Marca! Exclua os veículos e tente novamente!");
                return false;
            }
            await _marcaRepository.Delete(id);
            return true;
        }
        public void Dispose()
        {
            _marcaRepository?.Dispose();
            _veiculoRepository?.Dispose();
        }
    }
}
