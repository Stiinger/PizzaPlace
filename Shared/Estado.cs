namespace PizzaPlace.Shared;

public class Estado
{
	public Menu Menu { get; } = new Menu();
	public CarritoCompras Carrito { get; } = new CarritoCompras();
	public InterfazUsuario InterfazUsuario { get; set; } = new InterfazUsuario();
	public decimal PrecioTotal => Carrito.Pedidos.Sum(id => Menu.ObtenerPizza(id)!.Precio);
}