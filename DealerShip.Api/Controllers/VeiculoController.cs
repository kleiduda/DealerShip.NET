using AutoMapper;
using DealerShip.Api.ViewModels;
using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Models;
using DealerShip.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerShip.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : MainController
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IVeiculoService _veiculoService;
        private readonly IMapper _mapper;
        public VeiculoController(IVeiculoRepository veiculoRepository, IMapper mapper, IVeiculoService veiculoService)
        {
            _veiculoRepository = veiculoRepository;
            _mapper = mapper;
            _veiculoService = veiculoService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VeiculoViewModel>>> ObterVeiculos()
        {
            var veiculo = _mapper.Map<IEnumerable<VeiculoViewModel>>(await _veiculoRepository.FindAll());
            return Ok(veiculo);
        }
        [HttpGet("{placa}")]
        public async Task<ActionResult<VeiculoViewModel>> ObterVeiculoPorPlaca(string placa)
        {
            var veiculo = _mapper.Map<VeiculoViewModel>(await _veiculoRepository.ObterVeiculoPorPlaca(placa));
            return Ok(veiculo);
        }
        [HttpPost]
        public async Task<ActionResult<VeiculoViewModel>> CadastrarNovoVeiculo(VeiculoViewModel veiculoViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var veiculo = _mapper.Map<Veiculo>(veiculoViewModel);
            var result = await _veiculoService.Cadastrar(veiculo);

            if (!result) return BadRequest();

            return Ok(veiculo);
        }
        

    }
}
