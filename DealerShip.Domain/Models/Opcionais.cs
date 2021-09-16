using System;
using System.Collections.Generic;
using System.Text;

namespace DealerShip.Domain.Models
{
    public class Opcionais : Entity
    {
        public string OpcionalNome { get; set; }
        public Veiculo VeiculoNome { get; set; }

    }
}
