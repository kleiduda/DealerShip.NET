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
    public class MarcaController : MainController
    {
        private readonly IMarcaService _marcaService;
        private readonly IMarcaRepository _marcaRepository;
        private readonly IMapper _mapper;
        public MarcaController(IMarcaService marcaService, IMapper mapper, IMarcaRepository marcaRepository)
        {
            _marcaService = marcaService;
            _mapper = mapper;
            _marcaRepository = marcaRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarcaViewModel>>> ObterMarcas()
        {
            var marcas = _mapper.Map<IEnumerable<MarcaViewModel>>(await _marcaRepository.FindAll());
            return Ok(marcas);
        }
        [HttpPost]
        public async Task<ActionResult<MarcaViewModel>> CadastrarNovaMarca(MarcaViewModel marcaViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var marca = _mapper.Map<Marca>(marcaViewModel);
            var result = await _marcaService.Cadastrar(marca);

            if (!result) return BadRequest();

            return Ok(marca);
        }
    }
}
