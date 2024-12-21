using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        int id;
        string name;
        DateTime birthday;
        bool male;
        public Student() 
        {
            id = 63133655;
            name = "Nguyễn Hoài Huy Đạt";
            string b = "13/10/2003";
            birthday= DateTime.Parse(b);
            male = true;
        }
        public Student(int id, string name, DateTime birthday, bool male)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.male = male;
        }
        public Student(Student student)
        {
            this.id = student.id;
            this.name = student.name;
            this.birthday = student.birthday;
            this.male = student.male;
        }
        public void info()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine(this.name);
            Console.WriteLine($"{birthday.ToShortDateString()}");
            if (male)
                Console.WriteLine("Giới tính nam");
            else
                Console.WriteLine("Giới tính nữ");
        }
    }
}
