namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();

            if (MyList.Count == 0)
            {
                Console.WriteLine("Your list is empty.");
            }

            while (true)
            {
                Console.WriteLine("Enter even values (press 0 to stop):");
                int listValues = int.Parse(Console.ReadLine());
                // new feature for bouns ==> you con add even number only
                if (listValues % 2 == 0)
                {
                  //to add any number != zero علشان مياثرش على average & min value
                    if (listValues != 0)
                    {
                        MyList.Add(listValues);
                    }
                }
                else
                {
                    Console.WriteLine("Enter EVEN NUMBER ONLY. Try again.");
                    MyList.Clear();
                }
                //handel min & max value and average

                if (listValues == 0)
                {
                    if (MyList.Count > 0)
                    {
                        int minValue = MyList[0];
                        int maxValue = MyList[0];
                        double theAverage = 0.0;

                        for (int i = 0; i < MyList.Count; i++)
                        {
                            Console.WriteLine($"The values in the list are ===> {MyList[i]}");
                            theAverage +=  MyList[i] / MyList.Count;

                            if (maxValue < MyList[i])
                            {
                                maxValue = MyList[i];
                            }

                            if (minValue > MyList[i])
                            {
                                minValue = MyList[i];
                            }
                        }

                        Console.WriteLine("=========================================");
                        Console.WriteLine($"The average is {theAverage}");
                        Console.WriteLine("=========================================");
                        Console.WriteLine($"The min value is {minValue}");
                        Console.WriteLine("=========================================");
                        Console.WriteLine($"The max value is {maxValue}");
                    }
                    //else
                    //{
                    //    Console.WriteLine("Your list is empty.");
                    //}



                    //handel search value
                    Console.WriteLine("Enter the search value:");
                    int userSearch = int.Parse(Console.ReadLine());
                     

                    for (int j = 0; j < MyList.Count; j++)
                    {
                        if (userSearch == MyList[j])
                        {
                            Console.WriteLine($"Your value already exists in the list ===> {userSearch} with index ===> {j}");
                            
                            break;
                        }
 
                        else if (userSearch % 2 != 0)
                        {
                            Console.WriteLine("Your search is an ODD number. This list accepts EVEN numbers only.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your value does NOT exist.");
                            break;
                        }
                    }


                    //handel delet values from list
                    Console.WriteLine("Enter 'd' to delete all values:");
                    string dletValues = Console.ReadLine();

                    if (dletValues == "d")
                    {
                        MyList.Clear();
                        Console.WriteLine("All values are deleted.");
                    }

                    break;
                }
            }
        }
    }
}
