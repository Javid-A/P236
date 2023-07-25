using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string GroupNo;
        public byte Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value>= 0 && value<= 100)
                {
                     _point= value;
                }
            }
        }
        byte _point;
        public bool IsGraduated;

        public Student(string name, string surname, string groupNo, byte point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Point = point;
            IsGraduated = isGraduated;
        }

        public void GetNameAndSurname()
        {
            Console.WriteLine($"Telebe adi:{Name}, Telebe soyadi:{Surname}");
        }

        public void GetInfo()
        {

            Console.WriteLine($"Telebe adi: {Name}, Telebe soyadi: {Surname}, Telebenin qrupu: {GroupNo}, Telebenin bali: {Point}, {(IsGraduated ? "Telebe mezun olub" : "Telebe mezun olmayib")}");
        }

        public void CheckPointForSecondExam()
        {
            if (Point > 80)
            {
                Console.WriteLine("Telebe novbeti imtahana girish ede biler");
            }
            else
            {
                Console.WriteLine("Telebe novbeti imtahana girish ede bilmez");
            }
        }

        //public byte GetPoint()
        //{
        //    return Point;
        //}
        //public void SetPoint(byte point)
        //{
        //    if(point>=0 && point <= 100)
        //    {
        //        Point = point;
        //    }
        //    Console.WriteLine("Point 0 ve 100 arasinda olmalidir");
        //}
    }
}
