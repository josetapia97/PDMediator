using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorECommerce.Elements
{
    public class ShoppingCart
    {
        private IMediator _mediator;
        public ShoppingCart(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void AddItem(string item)
        {
            _mediator.Notify(this, item);
        }
    }
}
