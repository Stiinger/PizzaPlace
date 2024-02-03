using System.Text.Json;

namespace PizzaPlace.Client;

public static class ExtencionDepuracion
{
	private static JsonSerializerOptions opciones = new JsonSerializerOptions { WriteIndented = true };
	public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, opciones);
}