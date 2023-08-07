using Nullable__Upcasting__Downcasting;
using System.Runtime.InteropServices;
#region Nullable
////int x = default;

////string name = "";

////int num = null;

//string nullName = null;

////string insertedName = name.Insert(0, "test");

//string insertedNullName = nullName?.Insert(0,"test");

//Console.WriteLine(insertedNullName == null);


//int? num2 = null;


//bool? result = null;


//object test = 5;



//if(test == null)
//{
//    Console.WriteLine("Null");
//}
//else
//{
//    Console.WriteLine("not null");
//}

#endregion

#region Casting


//int num = 500;
//Student stu = new Student();

//Console.WriteLine(stu.Age);

//checked
//{
//    stu.Age = (byte)num;
//    //int val = int.MaxValue;
//    //Console.WriteLine(val + 2);
//}

//int num2 = 5;

//double num3 = num2;

//double num4 = 5.9;

//int num5 = (int)num4;

//Console.WriteLine(num5);

//Math.Floor(5.9);//5
//Math.Ceiling(5.000000001);//6
//Math.Round(5.21627381231,2);//5.22

//Samoyed samoyed = new Samoyed();

//Lionfish fish = new Lionfish();

//Console.WriteLine(samoyed.GetType());
//Console.WriteLine(fish.GetType());

//Animal dog = new Samoyed();//Upcasting

//Animal lionFish = new Lionfish();//Upcasting

//Samoyed newDog = (Samoyed)dog;//Downcasting


//Lionfish newSamoyed = lionFish as Lionfish;


//if (lionFish is Lionfish)
//{
//    Lionfish exp = (Lionfish)lionFish;
//    Console.WriteLine("test");
//}

//Terrestrial terr = new Samoyed();

//Pitbull pitbull = new Pitbull();
//Husky husky = new Husky();
//Samoyed sam = new Samoyed();
//NewDog test = new NewDog();
//pitbull.Treat();
//husky.Treat();
//sam.Treat();
//test.Treat();

//IShaveable shave = new Samoyed();

//shave.Shave();



#endregion

#region Casting & operator
//Manat manat = new Manat { AZN = 340};

//Dollar dollar = new Dollar();

//dollar = manat;

//Console.WriteLine(dollar.USD);

//Person person = new Person(25);
//Person person1 = new Person(25);

//Console.WriteLine(person >= person1);

//class Manat
//{
//    public double AZN { get; set; }

//    public static implicit operator Dollar(Manat manat)
//    {
//        return new Dollar { USD = manat.AZN / 1.7 };
//    }
//}

//class Dollar
//{
//    public double USD { get; set; }
//}


//class Person
//{
//    public byte Age;

//    public Person(byte age)
//    {
//        Age = age;
//    }

//    public static bool operator ==(Person p1,Person p2)
//    {
//        return p1.Age == p2.Age;
//    }
//    public static bool operator !=(Person p1, Person p2)
//    {
//        return p1.Age != p2.Age;
//    }
//    public static bool operator >(Person p1, Person p2)
//    {
//        return p1.Age > p2.Age;
//    }
//    public static bool operator <(Person p1, Person p2)
//    {
//        return p1.Age < p2.Age;
//    }
//    public static bool operator <=(Person p1, Person p2)
//    {
//        return p1.Age <= p2.Age;
//    }
//    public static bool operator >=(Person p1, Person p2)
//    {
//        return p1.Age >= p2.Age;
//    }
//}


#endregion

#region Multi-dimensional arrays
//int[] arr1D = new int[5];//{1,2,3,4,5}
//int[,] arr2D = new int[3, 2];//{{1,2},{3,4},{5,6}}

//int[,] AnotherArr2D = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

//int[,,] arr3D = new int[3, 4, 5];

//int[,,] anotherArr3D = {
//                           {
//                            { },
//                            { },
//                            { },
//                            { }
//                           },

//                           {
//                            { },
//                            { },
//                            { },
//                            { }
//                           },
//                           {
//                            { },
//                            { },
//                            { },
//                            { }
//                           }
                           
//                        };

#endregion