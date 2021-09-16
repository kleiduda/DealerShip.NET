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
    public class OpcionaisServiceImplementation : BaseService, IOpcionaisService
    {
        private readonly IOpcionaisRepository _opcionaisRepository;
        private readonly IVeiculoRepository _veiculoRepository;
        public OpcionaisServiceImplementation(IOpcionaisRepository opcionaisRepository, IVeiculoRepository veiculoRepository,INotificador notificador): base(notificador)
        {
            _opcionaisRepository = opcionaisRepository;
            _veiculoRepository = veiculoRepository;
        }
        public async Task<bool> Atualizar(Opcionais opcionais)
        {
            if (_opcionaisRepository.Search(opc =>opc.OpcionalNome == opcionais.OpcionalNome).Result.Any())
            {
                Notificar("Já existem um opcional com essa descrição!");
                return false;
            }
            await _opcionaisRepository.Update(opcionais);
            return true;
        }

        public async Task<bool> Cadastrar(Opcionais opcionais)
        {
            if (_opcionaisRepository.Search(opc=>opc.OpcionalNome == opcionais.OpcionalNome).Result.Any())
            {
                Notificar("Ja existe um opcional com essa descrição");
                return false;
            }
            await _opcionaisRepository.Cadastrar(opcionais);
            return true;
        }

        public async Task<bool> Remover(int id)
        {
            if (_veiculoRepository.ObterVeiculoOpcional(id).Result.Any())
            {
                Notificar("Existem veículos que usam esse opcional, não é possível excluir!");
                return false;
            }
            await _opcionaisRepository.Delete(id);
            return true;
        }
        public void Dispose()
        {
            _opcionaisRepository?.Dispose();
            _veiculoRepository?.Dispose();
        }
    }
}
