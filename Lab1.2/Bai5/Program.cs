using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số nguyên a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số nguyên b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
    }
    static void HoanVi(ref int x, ref int y)
    {
        int temp = x; 
        x = y;        
        y = temp;     
    }
}