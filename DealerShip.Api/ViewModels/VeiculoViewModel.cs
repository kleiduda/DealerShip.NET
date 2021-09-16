using System;
using System.Collections;
using System.Collections.Generic;

namespace DealerShip.Api.ViewModels
{
    public class VeiculoViewModel
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public string CondicaoNovoUsado { get; set; }
        public string Ano { get; set; }
        public Decimal Preco { get; set; }
        public string Quilometragem { get; set; }
        public string Combustivel { get; set; }
        public string Cambio { get; set; }
        public string Placa { get; set; }
        //public string Blindado { get; set; }
        public string Carroceria { get; set; }
        public IEnumerable<OpcionaisViewModel> Opcionais { get; set; }

    }
}