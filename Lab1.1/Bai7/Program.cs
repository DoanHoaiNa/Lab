using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 7 
        int year;
        Console.WriteLine("Nhập Năm: ");
        Console.Write("Year: ");
        year = int.Parse(Console.ReadLine());
        if (year % 4 == 0 && year % 100 != 0 || (year % 400 == 0))
        {
            Console.WriteLine(" Năm vừa nhập là năm nhuận: ");
        }
        else
        {
            Console.WriteLine("Năm vừa nhập không phải là năm nhuận");
        }
    }
}