using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public sealed class Student
    {
        public ArrayList studentinfo = new ArrayList();

        public List<Mark> Marks
        {
            get;
        } = new List<Mark>();

        public void StudentInfo()
        {
            for (int i = 0; i < studentinfo.Count; i++)
            {
                Console.Write(studentinfo[i]);
            }
            Console.WriteLine("\n");
            foreach(Mark i in Marks)
            { 
                Console.WriteLine($"{ i.Subject}-{i.Value}\n"); 
            }
        }


        public double a = 0;
        public double GetAvgMark(double a, out double b)
        {
            for (int i = 0; i < Marks.Count; i++)
            {
                a = a + Marks[i].Value;
            }
            return b = a / Marks.Count;
        }

        public void ResetAllMarks()
        {
            int i = 0;
            do
            {
                Marks[i].Value = 0;
                i++;
            }
            while (i < Marks.Count);
        }
    }
}
