using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    Caja obj = new Caja();
    Console.WriteLine("Ingresa el largo: ");
    obj.LARGO = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingresa el alto: ");
    obj.ALTO = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingresa el ancho: ");
    obj.ANCHO = int.Parse(Console.ReadLine());
		 Console.WriteLine("El largo es {0}, el alto es {1}, el ancho es {2}. Por lo tanto el volúmen es {3}", obj.LARGO, obj.ALTO, obj.ANCHO, obj.VOLUMEN = obj.LARGO
    * obj.ANCHO * obj.ANCHO);
  }
}

class Caja{
  private int largo;
  private int alto;
  //private int ancho; con la prop auto implantada suprimimos la variable
  //private int volumen; con la prop auto implantada suprimimos la variable
  
  //propiedad convencional 
  public int LARGO{
    get {
      return largo;
    }
    set{
			if(value < 0) value = -value;
      largo = value;
    }
  }
  //propiedad minificado
  public int ALTO{
    get => this.alto;
    set {
      if(value < 0) value = -value;
			//throw new Exception("El tamaño no puede ser positivo");
      alto = value;
    }
  }
	//propiedad auto implantada
  public int ANCHO{get; set;}
  public int VOLUMEN{get;set;}


}