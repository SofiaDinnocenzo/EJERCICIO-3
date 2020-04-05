using System;

class MainClass {
  public static void Main (string[] args) {
    int a,b;
    string linea;
    Console.Write("Ingrese primer número:");
    linea=Console.ReadLine();
    a=int.Parse(linea);
    Console.Write("Ingrese segundo número:");
    linea=Console.ReadLine();
    b=int.Parse(linea);
    Console.WriteLine();
    Console.WriteLine("Número a:" + a);
    Console.WriteLine();
    Console.WriteLine("Número b:" + b);
    int operacion=(a+b)*(a-b);
    Console.WriteLine("El resultado es:" + operacion);
  
  }
}