using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpet = 25;
            int largeCarpet = 35;
            double saleTax = 0.06;
            Console.WriteLine("enter the number of small carpit");
            int numerSmallCarpit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of large carpit");
            int numerLargelCarpit = int.Parse(Console.ReadLine());
            //store the total in the var to add  saleTax
            int Sum = (smallCarpet * numerSmallCarpit) + (largeCarpet * numerLargelCarpit);
            Console.WriteLine($" the Sum is {Sum}");
            //store the total after adding the saleTax
            double Sum_saleTax = (Sum * saleTax);

            Console.WriteLine($" and the totla is {Sum_saleTax + Sum} there is 6% for taxe");

        }
    }
}
