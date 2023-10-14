// Cree una clase Humana con cinco campos públicos: Nombre (string), Fuerza (int), Inteligencia (int), Destreza (int), Vida (int)
class Humano{
  // Propiedades
  public string Nombre { get; set; }
  public int Fuerza { get; set; }
  public int Inteligencia { get; set; }
  public int Destreza { get; set; }
  public int Vida { get; set; }
  /* Agregue un método constructor que tome una cadena para inicializar Nombre, y que inicializará Fuerza, Inteligencia,
  y Destreza a un valor predeterminado de 3, y salud a un valor predeterminado de 100 */
  public Humano(string nombre){
    Nombre = nombre;
    Fuerza = 3;
    Inteligencia = 3;
    Destreza = 3;
    Vida = 100;
  }  
    
  // Creemos un constructor adicional que acepte 5 parámetros, para que podamos establecer valores personalizados para cada campo.
  public Humano(string nombre, int fuerza, int inteligencia, int destreza, int vida)
  {
    Nombre = nombre;
    Fuerza = fuerza;
    Inteligencia = inteligencia;
    Destreza = destreza;
    Vida = vida;
  }

  /* Ahora agregue un nuevo método llamado Ataque, que cuando se invoca, debería reducir la salud de un objeto Humano que se pasa como parámetro.
  El daño realizado debe ser 3 * fuerza (3 puntos de daño al atacado, por cada 1 punto de fuerza del atacante). Este método debería devolver el
  estado restante del objeto de destino. */
  public int Ataque(Humano humanoAtacado){
    int daño = 3 * Fuerza;
    humanoAtacado.Vida -= daño;
    return humanoAtacado.Vida; 
  }
}