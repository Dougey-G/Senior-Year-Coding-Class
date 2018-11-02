using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        public static int SelectedSeat { get; private set; }

        static void Main(string[] args)
        {
            //Random rand = new Random();
            //int[] myIntArray = new int[10];
            //int myInt;

            //myInt = rand.Next();
            //for (int i = 0; i < 10; i++)
            //{
            //    myIntArray[i] = rand.Next();
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(myIntArray[i]);
            //}
            //Console.ReadLine();


            //Random rand = new Random();
            //List<int> myIntList = new List<int>();
            //int myInt;

            //myInt = rand.Next();
            //for (int i = 0; i < 10; i++)
            //{
            //    myIntList.Add(rand.Next());
            //}

            //for (int i = 0; i < myIntList.Count; i++)
            //{
            //    Console.WriteLine(myIntList[i]);
            //}
            //Console.ReadLine();

            int[] RollarCoaster = new int[10];
            Random rand = new Random();
            int input = 0;

            bool done = false;
            while (done == false)

            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("1. Put rider in random available seat on the Rollar Coaster.");
                Console.WriteLine("2. Lists available seats");
                Console.WriteLine("3. Start ride, print out how many people were on the ride.");
                Console.WriteLine("4. Exit program.");
                Console.WriteLine("*******************************************");
                string result = Console.ReadLine();


                if (result == "1")
                {
                    bool isSeatAvail = false;
                    for (int i = 0; i < RollarCoaster.Length; i++)
                    {
                        if (RollarCoaster[i] == 0)
                        {
                            isSeatAvail = true;
                            break;
                        }
                    }

                    if (isSeatAvail == true)
                    {
                        Console.WriteLine();
                        int SelectedSeat = 0;
                        do
                        {
                            SelectedSeat = rand.Next(10);
                            if (RollarCoaster[SelectedSeat] == 0)
                            {
                                RollarCoaster[SelectedSeat] = 1;
                                Console.WriteLine("Person put in seat " + SelectedSeat);
                                break;
                            }
                        } while (true);
                    }
                    else
                    {
                        Console.WriteLine("No seat is available, please wait for your turn, and DON'T ACT ENTITLED");
                    }
                    

                }
                else if (result == "2")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(RollarCoaster[i]);
                    }
                }
                else if (result == "3")
                {
                    int count = 0;
                    for (int i = 0; i < RollarCoaster.Length; i++)
                    {
                        if (RollarCoaster[i] == 1)
                        {
                            count++;
                            RollarCoaster[i] = 0;
                        }
                    }
                    Console.WriteLine(count + " people are on the ride");
                }
                else if (result == "4")
                {
                    Console.WriteLine("Ok, Good Bye.");
                    done = true;
                }

            }
        }
    }
}

