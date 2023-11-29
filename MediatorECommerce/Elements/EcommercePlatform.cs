using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorECommerce.Elements
{
    public class EcommercePlatform : IMediator
    {
        private ShoppingCart _shoppingCart;
        private InventorySystem _inventorySystem;
        public EcommercePlatform(ShoppingCart shoppingCart, InventorySystem inventorySystem)
        {
            _inventorySystem = inventorySystem;
            _shoppingCart = shoppingCart; 
        }
        public void Notify(object sender, string eventCode)
        {
            if (sender is ShoppingCart)
            {
                _inventorySystem.CheckItemAvailability(eventCode);
            }

        }
    }
}
