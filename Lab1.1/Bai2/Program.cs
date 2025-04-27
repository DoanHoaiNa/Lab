using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 2:
        int CD;
        int CR;
        Console.WriteLine("Vui lòng nhập chiều dài: ");
        Console.Write("CD: ");
        CD = int.Parse(Console.ReadLine());
        Console.WriteLine("Vui lòng nhập chiều rộng: ");
        Console.Write("CR: ");
        CR = int.Parse(Console.ReadLine());
    }
}