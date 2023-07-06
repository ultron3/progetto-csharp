using System;

public class login
{
	public login()
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
