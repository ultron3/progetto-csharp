using System;

public class ATM
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Hello World");
     int budget = 10000;

    Console.WriteLine("Inserisci un'opzione:");
    string opzione = Console.ReadLine();

    switch (opzione)
    {
      case "balance":
        
        Console.Writeline("hai un budget  di: " + budget);
        break;

      case "withdraw":
       
        Console.WriteLine("Inserisci l'importo da prelevare:");
        int money = Convert.ToInt32(Console.ReadLine());
        int result = budget - money;
        Console.WriteLine("Hai prelevato: " + money);
        Console.WriteLine("Ti rimane un budget di: " + result);
        break;
      case "deposit":
       
        Console.WriteLine("Inserisci il denaro:");
        int money1 = Convert.ToInt32(Console.ReadLine());
        int result_deposit = budget + money1;
        Console.WriteLine("Hai depositato: " + money1);
        Console.WriteLine("Hai un budget di: " + result_deposit);
        break;
      default:
        Console.WriteLine("Opzione non valida.");
        break;
    }
  }
}
