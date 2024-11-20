using System.Buffers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {


        //handel add number 
        static void HandelAddNumber()
        {
            Environment.Exit(0);

        }
        //add values in the list
        static void AddValues(List<int> list, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"enter the values number {i}");
                int eachValue = int.Parse(Console.ReadLine());
                //this feature for bouns allow user to enter even number only and stop the task is he enter the add number 
                if (eachValue % 2 == 0)
                {
                    list.Add(eachValue);
                }
                else
                {
                    Console.WriteLine("enter EVEN number only try again");
                    HandelAddNumber();
                }


            }
        }
        //handel display list 
        static void DIspayList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"the value is {list[i]}");
            }

        }
        // FindType max and min values in the list
        static void MaxandMinValues(List<int> list)
        {
            int max = list[0];
            int min = list[0];

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] > max)
                {
                    max = list[i];

                }
                else if (list[i] < min)
                {
                    min = list[i];
                }


            }

            Console.WriteLine($"Maximum Value: {max}");
            Console.WriteLine($"Minimum Value: {min}");
        }

        //handel Search value 
        static void SearchValue(List<int> list)
        {
            int searchValue = 0;
            Console.WriteLine("Enter the search value :");
            searchValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (searchValue == list[i])
                {
                    searchValue = list[i];
                    Console.WriteLine($"the {searchValue} exist in the list ");
                    break;
                }
                else
                {
                    Console.WriteLine($"the {searchValue} NOT exist in the list ");
                    break;
                }
            }

        }

        //handel clear list 
        static void ClrearList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list.Clear();
                Console.WriteLine("your list is empty");

            }

        }




        static void Main(string[] args)
        {
            List<int> list = new List<int>() { };
            Console.WriteLine("enter the lenght of loop");
            int count = int.Parse(Console.ReadLine());

            AddValues(list, count);
            DIspayList(list);
            MaxandMinValues(list);
            SearchValue(list);
            ClrearList(list);

        }
    }
}