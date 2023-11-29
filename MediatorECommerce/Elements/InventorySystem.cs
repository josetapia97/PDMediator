using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorECommerce.Elements
{
    public class InventorySystem
    {
        private IMediator _mediator;
        public InventorySystem(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SerMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void CheckItemAvailability(string item)
        {
            //aqui iria mediator.notify
            Console.WriteLine($"Chequing how many {item} are avaiable...");
        }
    }
}
