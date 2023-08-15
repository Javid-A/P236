internal class Program
{
    delegate bool NumberCondition(int num1,int num2);
    private static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        GetNumbers(arr, 80, IsSmaller);        
    }
    static void GetNumbers(int[] arr, int number, NumberCondition method)
    {

        foreach (int item in arr)
        {
            if (method(item,number))// item > number
            {
                Console.WriteLine(item);
            }
        }

    }
    static bool IsGreater(int num1, int num2)
    {
        return num1 > num2;
    }

    static bool IsSmaller(int num1, int num2)
    {
        return num1 < num2;
    }

    static bool NotForty(int num1, int num2)
    {
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