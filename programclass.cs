using System;

public class ATM
{
  public static void Main(string[] args)
  {
    int budget = 10000;
    string opzione;

    Console.WriteLine("Benvenuto");

    do
    {
      Console.WriteLine("Inserisci un'opzione:");
      opzione = Console.ReadLine();

      switch (opzione)
      {
        case "balance":
          Console.WriteLine("Hai un budget di: " + budget);
          break;

        case "withdraw":
          Console.WriteLine("Inserisci l'importo da prelevare:");
          if (int.TryParse(Console.ReadLine(), out int money))
          {
            int result = budget - money;
            Console.WriteLine("Hai prelevato: " + money);
            Console.WriteLine("Ti rimane un budget di: " + result);
            budget = result; // Aggiorna il budget con il risultato
          }
          else
          {
            Console.WriteLine("Input non valido. Inserisci un importo valido.");
          }
          break;

        case "deposit":
          Console.WriteLine("Inserisci il denaro:");
          if (int.TryParse(Console.ReadLine(), out int money1))
          {
            int result_deposit = budget + money1;
            Console.WriteLine("Hai depositato: " + money1);
            Console.WriteLine("Hai un budget di: " + result_deposit);
            budget = result_deposit; // Aggiorna il budget con il risultato
          }
          else
          {
            Console.WriteLine("Input non valido. Inserisci un importo valido.");
          }
          break;
        case "movements":
          Console.WriteLine("Ultimi 3 movimenti:");
          DisplayMovements();
          break;

        case "exit":
          Console.WriteLine("Grazie per aver utilizzato l'ATM. Arrivederci!");
          break;

        default:
          Console.WriteLine("Opzione non valida.");
          break;
      }

    } while (opzione != "exit");
  }
  private static void DisplayMovements()
  {
    Console.WriteLine("Movimento 1: €100 - Stroili");
    Console.WriteLine("Movimento 2: €200 - Deposito");
    Console.WriteLine("Movimento 3: €50 - Prelevato");
  }
}
