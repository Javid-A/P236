using Inheritance__Access_modifiers__Encapsulation;
using System.Data;
#region Second Homework 
//bool resultOfX = int.TryParse(Console.ReadLine(), out int x);
//bool resultOfY = int.TryParse(Console.ReadLine(), out int y);

//if (!resultOfX || !resultOfY)
//{
//    Console.WriteLine("Please enter valid numbers");
//    return;
//}



//int staticNumber = 17;

//int minusOfX = x - staticNumber;
//int minusOfY = y - staticNumber;

//if (Math.Abs(minusOfX) < Math.Abs(minusOfY))
//{
//    Console.WriteLine(x);
//}
//else if (Math.Abs(minusOfX) == Math.Abs(minusOfY))
//{
//    Console.WriteLine("X and Y are equal");
//}
//else
//{
//    Console.WriteLine(y);
//}



#endregion


#region First homework

Student student = new Student("Elnur", "Qafarzade", "P236", 190, true);
Console.WriteLine(student.Point);

//Console.WriteLine(student.GetPoint());
//Console.WriteLine("After change");
//student.SetPoint(student._point);
//Console.WriteLine(student.GetPoint());
//student.GetNameAndSurname();
//student.GetInfo();
//student.CheckPointForSecondExam();

#endregion


Milk milk = new ("98447723","Azersud","Palsud",18.20,0,2.5, "8.9 gr protein, 34.2 carbohydrates");

Console.WriteLine(milk.Nutrition);


Console.WriteLine(milk.Fat);
Console.WriteLine(milk.Barcode);


