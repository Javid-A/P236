using Static__Extension__Enum__Nullable;
using System.Text;
#region Static

//Pupil.SchoolNo = "223";

//Pupil pupil = new Pupil("Mehemmed","Aliyev","Tural");
//Pupil pupil1 = new Pupil("Akif","Memmedov","Rashid");
//Pupil pupil2 = new Pupil("Ali","Qafarzade","Kamran");

//Product.Discount = 20;

//Product pro = new Product(1,"Redbull",3.50);


//Console.WriteLine(pro.GetPrice());

//Product pro2 = new Product(2, "Bizon", 1);


//Console.WriteLine(pro2.GetPrice());

//Product pro3 = new Product(2, "Full", 1);

//Console.WriteLine(pro3.GetPrice());


//Employee.ShowProfession();
//Employee emp = new Employee("Programming");


//Employee emp1 = new Employee("Designer");

//emp1.Profession
//Employee emp2 = new Employee("UX/UI");

//Console.WriteLine(emp2.Id);


//emp.ShowCountWithoutStatic();

//Employee.ShowProfession();

//string name = "eLNur";

//Console.WriteLine();


//string sentence = "Bu bir custom contains methodudur";

//Console.WriteLine(sentence.CustomContains("bir"));

//static string ToCap(string word)
//{
//    StringBuilder stringBuilder = new StringBuilder();
//    string lowerResult = word.ToLower();

//    stringBuilder.Append(char.ToUpper(lowerResult[0]));
//    stringBuilder.Append(lowerResult.Substring(1));
//    return stringBuilder.ToString();
//}

#endregion


#region Enum and Nullable


string name = "Elcan";
Categories category = Categories.Coffee;

//switch (categories)
//{
//	case Categories.AlcoholDrinks:
//        Console.WriteLine("Choose drink");
//        break;
//	case Categories.Coffee:
//        Console.WriteLine("Choose coffee");
//        break;
//	case Categories.Tea:
//        Console.WriteLine("Choose tea");
//        break;
//	case Categories.a:
//		break;
//	case Categories.b:
//		break;
//	case Categories.c:
//		break;
//	case Categories.d:
//		break;
//	case Categories.e:
//		break;
//	default:
//		break;
//}

//string[] categories = Enum.GetNames(typeof(Categories));
//foreach (var item in categories)
//{
//    Console.WriteLine($"1.{item}");
//}


//Console.WriteLine(typeof(Categories));
//Array values = Enum.GetValues(typeof(Categories));

//foreach (var item in values)
//{
//    Console.WriteLine($"{(int)item}.{item}");
//}

bool res = Enum.TryParse(typeof(Categories),Console.ReadLine(),out object result);


Console.WriteLine(result);
#endregion