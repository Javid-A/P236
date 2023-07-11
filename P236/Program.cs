int test = 10;


var number = test;
dynamic name = "test";


int day = 7;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Please enter valid number");
        break;
}


int month = 8;

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter is coming");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Spring");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Summer");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Fall");
        break;
    default:
        Console.WriteLine("Please enter valid month number");
        break;
}


#region Break keyword
//int count = 0;
//for (int i = 0; i < 10; i++)
//{
//    if (i == 7)
//    {
//        Console.WriteLine(i);
//        break;
//    }

//    count++;
//}
//Console.WriteLine(count); 
#endregion

#region Continue keyword

int count = 0;

for (int i = 0; i < 20; i++)
{
    if (i == 5)
    {
        continue;
        Console.WriteLine(i);
    }
    count++;
}
Console.WriteLine(count);
#endregion

string[] names = { "Aysel", "Nicat", "Inal", "Elnur", "Zahra", "Xadica" ,"Elcan"};

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "Elnur")   // condition
    {
        continue;  
    }
    Console.WriteLine($"{names[i]} adli telebeye sual verilir");//process
}