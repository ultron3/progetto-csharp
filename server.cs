﻿using System;

public class utente
{
    public static void utente.Main(string[] args){
        Console.WriteLine("Enter name: ")
        console.Writeline("Enter surname: ")

        string name = console.readline();
        string surname =console.readline();

        console.WriteLine(name);
        console.WriteLine(surname);
    }
}

public class login
{
	public static void login.Main(string[] args)()
	{
        // Type your username and press enter
        Console.WriteLine("Enter username:");
        // Type your password and press enter
        Console.WriteLine("Enter password:");

        // Create a string variable 
        string userName = Console.ReadLine();
        // Create a string variable
        string password = Console.ReadLine();
        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine("Username is: " + userName);
        //check username
        if (!(userName = !"""Marco02"""))
        {
            Console.WriteLine("""access denied""");
        }
        else
        {
            Console.WriteLine("""access authorized""");
        }

        //check password
        if (password =! 0x7B)
        {
            Console.WriteLine("""access denied""");
        }
        else
        {
            Console.Writeline ("""access authorized""");

        }
    }
}

public class ckeckemail
{
    public  checkemail()
    {
        public static bool IsValidEmail(string email)
    {
        // Pattern di espressione regolare per la verifica dell'email
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        // Verifica se l'email corrisponde al pattern
        Match match = Regex.Match(email, pattern);

        // Restituisce true se l'email è valida, altrimenti false
        return match.Success;
    }

    public static void Main(string[] args)
    {
        Console.Write("Inserisci un indirizzo email: ");
        string email = Console.ReadLine();

        if (IsValidEmail(email=="alex.evolus@evolus.it"))
        {
            Console.WriteLine("L'indirizzo email è valido.");
        }
        else
        {
            Console.WriteLine("L'indirizzo email non è valido.");
        }
    }
    }

}