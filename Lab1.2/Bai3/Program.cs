using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 3
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int x = int.Parse(Console.ReadLine());
        int[] number = new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            number[i] = int.Parse(Console.ReadLine());
        }
        (int soDuong, int soAm) = CoutAmDuong(number);
        Console.WriteLine($"Số lượng số dương là: {soDuong}");
        Console.WriteLine($"Số lượng số âm là: {soAm}");
    }
    static (int, int) CoutAmDuong(int[] array)
    {
        int soDuong = 0;
        int soAm = 0;
        foreach (int number in array)
        {
            if (number > 0)
            {
                soDuong++;
            }
            else if (number < 0)
            {
                soAm++;
            }
        }
        return (soDuong, soAm);
    }
}