using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = b = 0;
            int i = 0;
            Console.Write("1.Info aboult students\n2.Exit\n");
            do
            {
                int.TryParse(Console.ReadLine(), out i);
                    switch (i)
                    {
                            case 1:
                                #region student0
                                Student student0 = new Student();
                                student0.studentinfo.AddRange(new string[] { "Student0 ", "Student0 ", "Student0 " });
                                student0.Marks.Add(new Mark("A", 10));
                                student0.Marks.Add(new Mark("B", 9));
                                student0.Marks.Add(new Mark("C", 8));
                                student0.Marks.Add(new Mark("D", 7));
                                student0.StudentInfo();
                                Console.WriteLine("Average mark " + student0.GetAvgMark(a, out b) + "\n");
                                #endregion

                                #region student1
                                Student student1 = new Student();
                                student1.studentinfo.AddRange(new string[] { "Student1 ", "Student1 ", "Student1 " });
                                student1.Marks.Add(new Mark("A1", 6));
                                student1.Marks.Add(new Mark("B1", 5));
                                student1.Marks.Add(new Mark("C1", 4));
                                student1.Marks.Add(new Mark("D1", 3));
                                student1.StudentInfo();
                                Console.WriteLine("Average mark " + student1.GetAvgMark(a, out b) + "\n");
                                #endregion

                                Console.WriteLine("\n");
                        Console.Write("1.Info aboult students\n2.Exit\n");
                        break;       
                    case 2:
                        break;
                }   
            }
            while (i != 2);
        }
    }
}
