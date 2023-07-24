using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Number(8,8,8);
        Sqrt(7,2);
        Hello("Hello I'm doing math.");
        Concerto.Person(400,"over");
    }
    
    public static void Number(int x,int y, int z){
        int somma = x + y + z;
        Console.WriteLine(somma);
    }
    public static void Sqrt(double a,double b){
     
       double Result = Math.Pow(a, b);
       Console.WriteLine(Result);
    }
    public static void Hello(string saluti){
        Console.WriteLine(saluti);
     
    }
}

public class Concerto{
    public int Numbers{get;set;}
    public string Event{get;set;}
    Concerto();
    public void Person(string events,int numbers){
        Numbers=numbers;
        Event=events;
        Console.WriteLine("all'"+events+"c'erano"+numbers+"persone");
    }
}