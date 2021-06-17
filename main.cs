using System;

class PruebaVector {

  private int[] numeros;

  public void Cargar(){
    int contador = 1;
    numeros = new int[5];

    for (int f=0; f<=5; f++){
      contador +=f;
      Console.Write("Ingrese el valor a cargar "+contador + ": ");
          string linea;
    linea = Console.ReadLine();
    numeros[f]= int.Parse(linea);
    }
  }
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    PruebaVector objeto = new PruebaVector();
    
    objeto.Cargar();


  }
  
  
}