Humano heroe = new Humano("Alex", 10, 15, 20, 200);
Humano enemigo = new Humano("Marius", 5, 10, 15, 100);

int vidaRestante = heroe.Ataque(enemigo);
enemigo.Vida = vidaRestante;
Console.WriteLine($"Nombre: {enemigo.Nombre} - Vida: {enemigo.Vida}");