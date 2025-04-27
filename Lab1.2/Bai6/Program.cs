internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            numbers[i] = double.Parse(Console.ReadLine());
        }
        SapXep(numbers);
        Console.WriteLine("Mảng sau khi sắp xếp theo chiều tăng dần:");
        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    static void SapXep(double[] array)
    {
        Array.Sort(array); 
    }

}