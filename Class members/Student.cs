using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_members
{
    internal class Student
    {
        public string Firstname;
        public string Lastname;
        public byte Age;
        public string Speciality;

        //public Student(string firstname,string lastname, byte age, string speciality)
        //{
        //    Firstname = firstname;
        //    Lastname = lastname;
        //    Age = age;
        //    Speciality = speciality;
        //}
        //public Student(string firstname,string lastname, byte age)
        //{
        //    Firstname = firstname;
        //    Lastname = lastname;
        //    Age = age;
        //}

        //public Student(string speciality)
        //{
        //    Speciality = speciality;
        //}

        public Student(string firstname, string lastname, byte age, string speciality):this(age, speciality)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Student(byte age,string speciality):this(speciality)
        {
            Age = age;
        }
        public Student(string speciality)
        {
            Speciality = speciality;
        }
        public void GetInfo()
        {
            //Console.WriteLine(string.Concat(Firstname," ", Lastname, " ", Age, " ", Speciality));
            //Console.WriteLine("Telebenin adi:{0}, Telebenin soyadi: {1},Telebenin soyadi: {2}",Firstname,Lastname,Age);
            Console.WriteLine($"Telebenin adi:{Firstname}, Telebenin soyadi: {Lastname},Telebenin yashi: {Age},Speciality: {Speciality}");
        }


        public bool CheckAge()
        {

            int test = 5;
            if (Age > 20)
            {
                return true;
            }
            return false;
        }
    }
}
