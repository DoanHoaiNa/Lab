using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            number[i] = int.Parse(Console.ReadLine());
        }
        int SoLThu2 = TimSoLon2(number);
        Console.WriteLine($"Số lớn thứ hai trong mảng là: {SoLThu2}");
    }
    static int TimSoLon2(int[] array)
    {
        int soL = int.MaxValue;
        int soL2 = int.MinValue;
        foreach (int number in array)
        {
            if (number > soL)
            {
                soL2 = soL;
                soL = number;
            }
            else if (number > soL2 && number < soL)
            {
                soL2 = number;
            }
        }
        return soL2;
    }
}