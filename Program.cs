Humano heroe = new Humano("Alex", 10, 15, 20, 200);
Humano enemigo = new Humano("Marius", 5, 10, 15, 100);

Humano objetivo = heroe.Ataque(enemigo);
Console.WriteLine($"Nombre: {objetivo.Nombre} - Vida: {objetivo.Vida}");