using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 1
        int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        int Sum = tong (number);
        Console.WriteLine($"Tổng của các số chẵn là: {Sum}");  
    }
    static int tong(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
}