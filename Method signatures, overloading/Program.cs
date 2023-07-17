#region Reverse name task
//static void Reverse()
//{
//	string name = "Javid";
//	for (int i = name.Length - 1; i >= 0; i--)
//	{
//		Console.Write(name[i]);
//	}
//}

//Reverse(); 
#endregion

//static void Write()
//{
//    Console.WriteLine("Hello");
//}


//static void Add()
//{
//    Console.WriteLine(5+10);
//}

//static void Divide(int[] arr,int divide)
//{
//    Console.WriteLine(divide+"-a bolunenler");
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % divide == 0)
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }
//}


//int[] arr = { 90, 20, 30, 40, 50, 60, 70, 80 };
//int[] arr2 = { 10, 20, 33, 44, 150, 260, 370, 780 };
//int[] arr3 = { 960, 2770, 370, 450, 750, 610, 7330, 820 };

//Divide(arr, 100);


class Program
{
    static void Main(string[] args)
    {
        int num = Add(5);
        Console.WriteLine(num);
    }

    #region Method overloading
    static int Add()
    {
        return 10;
    }

    static int Add(int num)
    {
        return num;
    }
    //Methodun return type-i onun signature-i SAYILMIR!!!
    static string Add(int num)
    {
        return num.ToString();
    }
    static int Add(int num, int num2)
    {
        return num + num2;
    }

    static int Add(byte num)
    {
        return num + 10;
    }

    static int Add(byte num, int num2)
    {
        return num + num2;
    }

    static int Add(int num, byte num2)
    {
        return num + num2;
    }
    #endregion
}
