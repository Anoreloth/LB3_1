using System;

namespace LB3_1
{
    class Person
    {
        public string name { get; set; }
        int age;
        public int setAge
        {
            set { age = value; }
        }
        public int Greet
        {
            get { return age; }
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int x)
        {
            Console.WriteLine($"My age is: " + x + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class StudentProfessorTest
    {
        string name { get; }
        public StudentProfessorTest(string _name)
        {
            name = _name;
        }
        public void Main()
        {
            Console.WriteLine("-Hi, my name is" + name);

            var student = new Student();
            student.setAge = 17;
            student.name = "Mary";
            Console.WriteLine("- Hi Lera, my name is " + student.name + ", I`m student");
            student.ShowAge(student.Greet);

            var teacher = new Professor();
            teacher.setAge = 46;
            teacher.name = "Mr. Winston";
            Console.WriteLine("- Good day, I your teacher, my name is " + teacher.name + ". I`m " + teacher.Greet + " years old.");
            teacher.Explain();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new StudentProfessorTest("Lera");
            test.Main();
        }
    }
}
