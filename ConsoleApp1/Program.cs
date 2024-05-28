internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите свое имя: ");
        var name = Console.ReadLine();       // вводим имя
        Console.WriteLine($"Привет {name}");
    }
}