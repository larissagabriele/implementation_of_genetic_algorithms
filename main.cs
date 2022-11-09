// Matriz - leitura com laço

using System;
using System.IO;
using System.Text;

  internal class Program
  {
    static void Main(string[] args) {
      int numero = 0;
      Console.WriteLine("Entre com um número");
      try
      {
        numero = int.Parse(Console.ReadLine());
        int resultado = numero/0;
        Console.WriteLine(resultado);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao tentar calcular ->" + ex.Message);
      }
      finally
      {
        Console.ReadKey();
      }
    }
  }