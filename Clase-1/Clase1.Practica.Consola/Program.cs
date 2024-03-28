// See https://aka.ms/new-console-template for more information

using Clase1.Practica.Consola;

JuegoAdivinanza juegoAdivinanza = new(new ConsolaInput(), new ConsolaOutput(), new GeneradorNumeroRandom());
juegoAdivinanza.Jugar();