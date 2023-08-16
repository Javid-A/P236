using Delegate;

internal class Program
{
    delegate bool NumberCondition(int num1, int num2);
    private static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        //GetNumbers(arr, 80, (int num1, int num2) => num1 > num2);

        //NumberCondition numberCondition = new NumberCondition(IsSmaller);
        NumberCondition numberCondition = IsSmaller;
        //Console.WriteLine(numberCondition.Invoke(5, 10));
        //numberCondition += IsGreater;
        //numberCondition += NotForty;
        //numberCondition -= IsSmaller;
        //Console.WriteLine(numberCondition(5, 10));


        //NumberCondition lambda = (int num, int num2) =>
        //{
        //    return num>num2;
        //};

        //NumberCondition anonymous = delegate (int num, int num2)
        //{
        //    return num > num2;
        //};

        //Console.WriteLine(anonymous(2,3));

        Action<string, int, double> action = (string name, int age, double price) =>
        {
            Console.WriteLine($"{name} {age} {price}");
        };
        //action("Elcan",19,200.3);
        GetData("Elcan", 19, 200.3);

        Action<int, DateTime> aksdkasdksasdka = delegate (int number, DateTime date)
        {
            Console.WriteLine("Nijat");
        };

        Action<int, DateTime> nijat = (int asd, DateTime jasdjas) =>
        {

        };

        Action ac = () =>
        {

        };

        Func<int> f = () =>
        {
            return 5;
        };

        Func<string, int, double, bool> func = (string name, int num,double price) =>
        {
            return false;
        };


        Func<Settlement, City> f2 = (Settlement test) =>
        {
            City obj;
            return null;
        };
        Console.WriteLine();
    }

    static void GetNumbers(int[] arr, int number, NumberCondition method)
    {

        foreach (int item in arr)
        {
            if (method(item, number))// item > number
            {
                Console.WriteLine(item);
            }
        }

    }

    public static void GetData(string name, int age, double price)
    {
        Console.WriteLine($"{name} {age} {price}");
    }
    //static void GetNumbersWithAction(int[] arr, int number, Action<int,int> method)
    //{

    //    foreach (int item in arr)
    //    {
    //        if (method(item, number))// item > number
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //}
    static bool IsGreater(int num1, int num2)
    {
        Console.WriteLine("IsGreater");
        return num1 > num2;
    }

    static bool IsSmaller(int num1, int num2)
    {
        Console.WriteLine("IsSmaller");
        return num1 < num2;
    }

    static bool NotForty(int num1, int num2)
    {
        Console.WriteLine("NotForty");
        return num1 < num2 && num1 != 40;
    }
}




//static void GetNumber(int[] arr, int number)
//{

//    foreach (int item in arr)
//    {
//        if (item == number)
//        {
//            Console.WriteLine(item);
//        }
//    }

//}
//static void GetNumber2(int[] arr, int number)
//{

//    foreach (int item in arr)
//    {
//        if (item < number)
//        {
//            Console.WriteLine(item);
//        }
//    }

//}



//static void GetNumber2(int[] arr, int number)
//{

//    foreach (int item in arr)
//    {
//        if (item < number)
//        {
//            Console.WriteLine(item);
//        }
//    }

//}
#region Homework
//Country c = new Country();

//City c1 = new City("California", 22331);
//City c2 = new City("LA", 223312);
//City c3 = new City("NYC", 762923);
//City c4 = new City("Texas", 34567);

//Village v1 = new Village("Detroit", 75432);
//Village v2 = new Village("Kentucky", 4829);
//Village v3 = new Village("Boston", 75432);

//c.AddSettlement(c1);
//c.AddSettlement(c2);
//c.AddSettlement(c3);
//c.AddSettlement(c4);
//c.AddSettlement(v1);
//c.AddSettlement(v2);
//c.AddSettlement(v3);

//Console.Write("Total population: ");
//Console.WriteLine(c.TotalPopulation);

//Console.WriteLine("Settlements infos");
//c.ShowSettlementsInfos();
#endregion