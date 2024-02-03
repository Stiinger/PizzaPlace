namespace PizzaPlace.Shared;

public class CarritoCompras
{
	public Cliente Cliente { get; set; } = new Cliente();
	public List<int> Pedidos { get; set; } = new List<int>();
	public bool HaPagado { get; set; }

	public void Agregar(int pizzaId) => Pedidos.Add(pizzaId);
	public void Remover(int pos) => Pedidos.RemoveAt(pos);
}