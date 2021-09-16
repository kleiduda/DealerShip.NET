using System;
using System.Collections.Generic;
using System.Text;

namespace DealerShip.Domain.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public Entity()
        {
        }
    }
}
