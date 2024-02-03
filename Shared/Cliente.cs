using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Shared;

public class Cliente
{
	public int Id { get; set; }
	[Required(ErrorMessage = "Debe ingresar un nombre")]
	public string Nombre { get; set; } = default!;
	[Required(ErrorMessage = "Debe ingresar una calle y número de casa")]
	public string Calle { get; set; } = default!;
	[Required(ErrorMessage = "Debe ingresar una ciudad")]
	public string Ciudad { get; set; } = default!;
}