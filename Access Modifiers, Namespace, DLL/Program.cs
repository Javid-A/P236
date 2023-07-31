using Access_Modifiers__Namespace__DLL;
using Access_Modifiers__Namespace__DLL.Models;
using DLL;
using DLL.Base_Entity;
#region Homework
//User user = new User();
//string username;
//string pw;
//do
//{
//    Console.WriteLine("Please enter username");
//    username = Console.ReadLine();

//} while (username.Length <= 6);

//do
//{
//    Console.WriteLine("Please enter password");
//    pw = Console.ReadLine();
//} while (!user.CheckPassword(pw));


//Console.WriteLine("Is super admin (y/n)");

//char answer = Console.ReadKey().KeyChar;
//bool isSuperAdmin = false;
//if (answer == 'y')
//{
//    isSuperAdmin = true;
//}

//Console.WriteLine("\nPlease enter section");
//string section = Console.ReadLine();

//Admin admin = new Admin(username, pw, isSuperAdmin, section);

//admin.GetInfo(); 
#endregion

Accessable accessable = new Accessable();

AnotherAssembly anotherAssembly = new AnotherAssembly();


Product product = new Product();
Computer comp = new Computer();

Point point = new Point();
DerivedPoint derivedPoint = new DerivedPoint();



Person person = new Person();



int num = 5;
int num2 = 10;
//int total = SumV2(num, num2);
int total;
Sum(out total, num, num2);

Console.WriteLine(total);
static void Sum(out int asdasda, int num, int num2)
{
    asdasda = num + num2;
}


static void SumV2(int asdasda, int num, int num2)
{
    asdasda = num + num2;
    Console.WriteLine($"Inside method: {asdasda}");
}


