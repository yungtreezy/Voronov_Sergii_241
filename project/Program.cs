using System;

namespace ConsoleApp1
{
    class Lab1
    {


        static void Main()
        {
            Student student = new Student("Serhii", "Voronov", 18, "Ukraine", "Kherson", "Perekopskaya", 8);
            student.GetInfo();

            Teacher teacher = new Teacher("Oleg", "Andreev", 35, "Ukraine", "Kherson", "Perekopskaya", 20);
            teacher.GetInfo();

            Console.ReadLine();
        }
    }
}
