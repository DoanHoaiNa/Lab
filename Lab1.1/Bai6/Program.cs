using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 6
        int a;
        Console.WriteLine("Nhập số: ");
        Console.Write("A:");
        a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("Số vừa nhập là số dương");
        }
        else
        {
            Console.WriteLine("Số vừa nhập là số âm");
        }
    }
}