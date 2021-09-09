using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome into students marks calculator, please enter the number of the student follow by the name of the student then his mark ");
            int size = Convert.ToInt32(Console.ReadLine());
            String markinfo;
            String name;
            double mark;
            object[,] studentinfo = new object[size,size];
            for (int i = 0; i < size; i++)
            {
                name = Console.ReadLine();
                mark = Convert.ToDouble(Console.ReadLine());
                if (mark < 60)
                {
                    markinfo = "Failed";
                }
                else
                {
                    markinfo = "Passed";
                }

               
                studentinfo[i, i] = (name, markinfo);
                

                
            }
            foreach (var student in studentinfo)
            {
                Console.WriteLine(student);
            }

        }
    }
}
