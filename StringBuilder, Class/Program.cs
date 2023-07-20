#region String class methods
//string name = "Xadica";
//string name2= (string)name.Clone();
//name2 = "asd";
//Console.WriteLine(name); 

using System.Text;

string concat;
//Console.WriteLine(string.Concat("Hello", " ", "P236,", " What's", " ", "up"));


string student = "Inal";

//Console.WriteLine(student.Contains("Inal"));


//string studentsProblems = "They do not spend much time on computer desk";

//Console.WriteLine(studentsProblems.StartsWith("hey d"));
//Console.WriteLine(studentsProblems.EndsWith("much time on computer desk"));


//string price = string.Format("{1:c},{0:c},{9:c}", 10000, 20000,2,3,3,4,5,6,7,23);

//Console.WriteLine(DateTime.Now);
//Console.WriteLine("After format");
//Console.WriteLine(string.Format("{0:r}", DateTime.Now));


//string about = "Contact us";

//string insertedAbout = about.Insert(8,"with ");

//Console.WriteLine(insertedAbout);

//string profession = null;

//string gender = "";


//Console.WriteLine(string.IsNullOrEmpty(gender));
//Console.WriteLine(string.IsNullOrWhiteSpace(gender));


//string datas = "1. Milk,2. Tea,3. Coffee,4. Cola,5. Fanta,6. Redbull,7. Still water,8. Sprite";

//string[] dataArray = datas.Split(',');

//foreach (var item in dataArray)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine(string.Join("==>>", dataArray));



//string NonTrimed = "<Hello              World<>";


//Console.WriteLine(NonTrimed.Trim('<','>'));

//StringBuilder sb = new StringBuilder();
////string str = "";

//StringBuilder sb2 = new StringBuilder("Hello world");
////string str2 = "Hello World";

//sb2.AppendLine("");
//sb2.Append("test");


//Console.WriteLine(sb2);

#endregion

//namespace Test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 5;
//            int b = 6;
//            Console.WriteLine(a+b);
//        }
//    }
//}


//var cup = new
//{
//    Height = 40,
//    Diameter = 20
//};

//Cup cup = new Cup();

//cup.Height = 13;
//cup.Image = "cup.jpg";
//cup.Diameter = 7;
//cup.HasEmblem = true;
//cup.Count = 500;

//Cup cup2 = new Cup();

//cup2.Height =10;
//cup2.Image = "cup2.png";
//cup2.Diameter = 5;
//cup2.HasEmblem = false;
//cup2.Count = 200;

//class Cup
//{
//    public byte Height;
//    public byte Diameter;
//    public bool HasEmblem;
//    public string Image;
//    public int Count;


//    public Cup()
//    {

//    }
//    public Cup(byte test)
//    {

//    }
//    public Cup(string name)
//    {

//    }
//}