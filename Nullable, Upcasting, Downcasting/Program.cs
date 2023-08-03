using Nullable__Upcasting__Downcasting;
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

Samoyed samoyed = new Samoyed();

Lionfish fish = new Lionfish();

//Console.WriteLine(samoyed.GetType());
//Console.WriteLine(fish.GetType());

Animal dog = new Samoyed();//Upcasting

Animal lionFish = new Lionfish();//Upcasting

Samoyed newDog = (Samoyed)dog;//Downcasting


//Lionfish newSamoyed = lionFish as Lionfish;


//if (lionFish is Lionfish)
//{
//    Lionfish exp = (Lionfish)lionFish;
//    Console.WriteLine("test");
//}

Terrestrial terr = new Samoyed();

Pitbull pitbull = new Pitbull();
Husky husky = new Husky();
Samoyed sam = new Samoyed();
NewDog test = new NewDog();
pitbull.Treat();
husky.Treat();
sam.Treat();
test.Treat();

IShaveable shave = new Samoyed();

shave.Shave();



#endregion