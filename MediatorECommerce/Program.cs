
using MediatorECommerce.Elements;

//se pueden crear sin ningun mediador
var inventario = new InventorySystem(null);
var carrito = new ShoppingCart(null);

//y luego crear el mediador
var ecommerceplatform = new EcommercePlatform(carrito,inventario);

inventario.SerMediator(ecommerceplatform);
carrito.SetMediator(ecommerceplatform);

carrito.AddItem("Banana, Barcode:99826");
carrito.AddItem("Naranja, Barcode:99846");
carrito.AddItem("Sandia, Barcode:99526");