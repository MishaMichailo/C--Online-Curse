namespace HomeWork_Delegate
{
    using System;
    using System.Collections.Generic;

    public delegate void MyDel(int m);

    public class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event MyDel MarkChange;

        public Student(string name)
        {
            Name = name;
            Marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            Marks.Add(mark);
            MarkChange?.Invoke(mark);
        }
    }

    public class Parent
    {
        public void OnMarkChange(int estimate)
        {
            Console.WriteLine("Parent - Mark changed: " + estimate);
        }
    }

    public class Accountancy
    {
        public void PayingFellowship(int estimate)
        {
            if (estimate >= 90)
                Console.WriteLine("Accountancy - Student is eligible for a scholarship.");
            else
                Console.WriteLine("Accountancy - Student is not eligible for a scholarship.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             Student student = new Student("John");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(85);
            student.AddMark(95);
            student.AddMark(75);
            student.AddMark(92);
        }
    }
}