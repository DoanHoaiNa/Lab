using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 10
        int b;
        Console.WriteLine("Nhập số ");
        Console.Write("B:");
        b = int.Parse(Console.ReadLine());
        bool SNT = true;
        if (b <= 1)
        {
            Console.WriteLine("Vui lòng nhập lại:");
            SNT = false;
        }
        else
        {
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                {
                    SNT = false;
                }
            }
            if (SNT)
            {
                Console.WriteLine($"Số {b} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"Số {b} không phải là số nguyên tố");
            }
        }
    }
}