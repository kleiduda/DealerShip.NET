using AutoMapper;
using DealerShip.Api.ViewModels;
using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerShip.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Veiculo, VeiculoViewModel>().ReverseMap();
            CreateMap<Marca, MarcaViewModel>().ReverseMap();
            CreateMap<Opcionais, OpcionaisViewModel>().ReverseMap();
        }
    }
}
