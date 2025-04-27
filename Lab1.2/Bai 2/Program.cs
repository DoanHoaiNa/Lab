using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 2
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] so = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}");
            so[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Các số nguyên tố trong mảng:");
        for (int i = 0; i < n; i++)
        {
            if (SNT(so[i]))
            {
                Console.WriteLine($"Chỉ số: {i}, Giá trị: {so[i]}");
            }
        }
    }
    static bool SNT(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return true;
            }
        }
        return true;
    }
}