using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DealerShip.Domain.Models
{
    public class Veiculo : Entity
    {
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public string CondicaoNovoUsado { get; set; }
        public string Ano { get; set; }
        public Decimal Preco { get; set; }
        public string Quilometragem { get; set; }
        public string Combustivel { get; set; }
        public string Cambio { get; set; }
        public string Placa { get; set; }
        public string Carroceria { get; set; }
        public IEnumerable<Opcionais>  Opcionais { get; set; }

        internal bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
