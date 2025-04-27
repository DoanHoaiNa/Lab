using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 3:
        int C;
        Console.WriteLine("Nhập độ C: ");
        Console.Write("C: ");
        C = int.Parse(Console.ReadLine());
        int F = (C * 9 / 5) + 32;
        Console.WriteLine($"Độ F là: {F}");
    }
}