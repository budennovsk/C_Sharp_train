// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Введите свое имя: ");
//         var name = Console.ReadLine();       // вводим имя
//         Console.WriteLine($"Привет {name}");
//     }
// }
// ReSharper disable once SuggestVarOrType_BuiltInTypes
// int first_var = 22;
// Console.WriteLine(first_var);
// string first_var = "REFERFR";
// Console.WriteLine(first_var);

int num =0;

int Incrementnum(ref int n)
{   
    return n+=5;
}
Console.WriteLine(num);
var res = Incrementnum(ref num);
Console.WriteLine(num);
Console.WriteLine(res);