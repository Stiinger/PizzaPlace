﻿namespace PizzaPlace.Shared;

public class Pizza
{
	public Pizza(int id, string nombre, decimal precio, Picantes picante)
	{
		this.Id = id;
		this.Nombre = nombre;
		this.Precio = precio;
		this.Picante = picante;
	}

	public int Id { get; }
	public string Nombre { get; }
	public decimal Precio { get; }
	public Picantes Picante { get; }
}