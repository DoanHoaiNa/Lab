using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 5
        int x, y, sum, tich;
        Console.WriteLine("Nhập 2 số X và Y");
        Console.Write("X: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        y = int.Parse(Console.ReadLine());
        sum = x + y;
        Console.WriteLine($"Tổng của 2 số là: {sum}");
        tich = x * y;
        Console.WriteLine($"Tích của 2 số là: {tich}");
    }
}