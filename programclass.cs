using System;

public class ATM
{
  public static void Main(string[] args)
  {
    int budget = 10000;
    string opzione;

    Console.WriteLine("Welcome");

    do
    {
      Console.WriteLine("Enter a option:");
      opzione = Console.ReadLine();

      switch (opzione)
      {
        case "balance":
          Console.WriteLine("Have a budget of: " + budget);
          break;

        case "withdraw":
          Console.WriteLine("Enter  a import of withdraw:");
          if (int.TryParse(Console.ReadLine(), out int money))
          {
            int result = budget - money;
            Console.WriteLine("you picked up: " + money);
            Console.WriteLine("you are left with a balance of: " + result);
            budget = result; // Aggiorna il budget con il risultato
          }
          else
          {
            Console.WriteLine("Invalid input. Please enter a valid amount.");
          }
          break;

        case "deposit":
          Console.WriteLine("deposit money here:");
          if (int.TryParse(Console.ReadLine(), out int money1))
          {
            int result_deposit = budget + money1;
            Console.WriteLine("you deposited: " + money1);
            Console.WriteLine("you have a budget of: " + result_deposit);
            budget = result_deposit; // Aggiorna il budget con il risultato
          }
          else
          {
            Console.WriteLine("Invalid input. Please enter a valid amount.");
          }
          break;
        case "movements":
          Console.WriteLine("Ultimi 3 movimenti:");
          DisplayMovements();
          break;

        case "recharge":
          Console.WriteLine("recharge mobile phone");
          DisplayRecharge();
          break
       

        case "exit":
          Console.WriteLine("Thanks for using the ATM. Until we meet again!");
          break;

        default:
          Console.WriteLine("Invalid option");
          break;
      }

    } while (opzione != "exit");
  }
  private static void DisplayMovements()
  {
    Console.WriteLine("15/07/2023: €100 - Stroili");
    Console.WriteLine("15/07/2023: €200 - Deposito");
    Console.WriteLine("16/07/2023: €50 - Prelevato");
  }

  private static void DisplayRecharge()
  {
    Console.WriteLine("Vodafone");
    Console.WriteLine("WindTre");
    Console.WriteLine("tim");

  }
}
