using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 4:
        int Z;
        Console.WriteLine("Nhập số nguyên: ");
        Console.Write("Z: ");
        Z = int.Parse(Console.ReadLine());
        if (Z % 2 == 0)
        {
            Console.WriteLine("Số nguyên vừa nhập là số chẵn");
        }
        else
        {
            Console.WriteLine("Số vừa nhập không phải số chẵn");
        }
    }
}