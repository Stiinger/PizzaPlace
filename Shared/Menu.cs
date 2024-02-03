namespace PizzaPlace.Shared;

public class Menu
{
	public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
	public void Agregar(Pizza pizza) => Pizzas.Add(pizza);
	public Pizza? ObtenerPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
}