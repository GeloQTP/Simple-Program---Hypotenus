internal class Program // done 3-16-23
{
    static void Main(String[] Args)
    {
        Console.WriteLine("Enter Side A: ");
        double Side_A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n");

        Console.WriteLine("Enter Side B:");
        double Side_B = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n");
            
        double Ans = Math.Sqrt((Side_A * Side_A) + (Side_B * Side_B));

        Console.WriteLine("The Hypotenus is: " + Ans);
    }
}