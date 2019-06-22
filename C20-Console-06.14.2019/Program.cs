using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_Console_06._14._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            C20 c20 = new C20();
            int userInt;
            string userInput;
            do
            {
                Console.WriteLine("Please select only bottom number");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Exam");
                Console.WriteLine("3.All Student");
                Console.WriteLine("4.Exit");
                Console.Write(">>>> ");

                userInput = Console.ReadLine();
                if(int.TryParse(userInput, out userInt))
                {
                    switch (userInt)
                    {
                        case 1:
                            c20.AddStudent();
                            foreach (Student st in c20.Students)
                            {
                                Console.WriteLine("Id : {0}, Name : {1}", st.Id, st.Fullname);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Exam Add Successfully");
                            break;
                        case 3:
                            Console.WriteLine("All Student");
                            break;

                        default:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Select Valid Action");
                            Console.WriteLine("----------------------");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please add Numeric Charachter");
                    Console.WriteLine("-------------------------");

                }

            } while (userInput != "4");






            //foreach (Student st in c20.Students)
            //{
            //    Console.WriteLine("Id : {0}, Name : {1}",st.Id,st.Fullname);
            //}
        }
    }
}
