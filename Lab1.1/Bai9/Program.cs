using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 9
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        long giaithua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaithua *= i;
        }

        Console.WriteLine($"Giai thừa của {n} là {giaithua}.");
    }
}