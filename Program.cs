namespace firstNamelastName;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! What's your name? ");
        Console.Write("Type your first name: ");

        
        string myFirstName = Console.ReadLine()!;

        Console.WriteLine(" Type your last name: ");
        string myLastName = Console.ReadLine()!;

        Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        Console.ReadLine();


    }
}
