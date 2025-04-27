using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Bài 1:
        Console.OutputEncoding = Encoding.UTF8;
        int age = 20; 
        string name = "Doan HoaiNam";
        Console.WriteLine($"Xin chao {name} ban {age} tuoi ");
        
    }
}