
#region Tax task
//static double SumWithTax()
//{

//    Console.WriteLine("Please enter percent value:");
//    string percentStr = Console.ReadLine();
//    double percent = double.Parse(percentStr);

//    double[] arr = { 2, 5, 20, 30, 15, 50, 66 };
//    double total = 0;
//    foreach (double num in arr)
//    {
//        if (num < 20)
//        {
//            total += num * (100 + percent) / 100;
//            continue;
//        }

//        total += num;

//    }
//    return total;
//}

//double result = SumWithTax();
//Console.WriteLine(result); 
#endregion

#region Remove character
//static string RemoveChar(int num1, string words, bool result, DateTime date)
//{
//    Console.WriteLine("Please enter valid number:");
//    int number = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Please enter word:");
//    string word = Console.ReadLine();
//    string resultWord = string.Empty;
//    for (int i = 0; i < word.Length; i++)
//    {
//        if (i == number)
//        {
//            continue;
//        }
//        resultWord += word[i];

//    }

//    return resultWord;
//}

//static void Test()
//{
//    Console.WriteLine("Hello world");
//}


#endregion


#region Memory Allocation=> Stack and Heap memory
//byte num1 = 255;

//int num2 = 10000000;

//long num3 = 1000000000;

//char letter = '@';

//string word = "Hello P236";

//int num = 100;
//int num2 = num;
//num += 200;
//Console.WriteLine(num2);

//int[] arr = { 1, 2, 3, 4, 5 };

//int num = default;
//int[] arr2 = arr;

//arr[2] = 100;
//Console.WriteLine(arr2[2]);

//int number = 20;

//static void ChangeNumber(ref int number)
//{
//    number = 300;
//    Console.WriteLine(number);
//}

//ChangeNumber(ref number);

//static void ChangeArray(ref int[] arr)
//{
//    arr = new int[15];
//}

//ChangeArray(ref arr);

//Console.WriteLine(arr[0]);


//int numberOut=20;
//static void ChangeNumberWithOutKeyword(out int numberOut)
//{
//    int total = 30;
//    numberOut = 100;
//    numberOut += 200;
//    Console.WriteLine(total);
//}

//ChangeNumberWithOutKeyword(out numberOut);

//int numberRef = 20;
//static void ChangeNumberWithRefKeyword(ref int numberRef)
//{
//    numberRef += 20;
//}

//ChangeNumberWithRefKeyword(ref numberRef);

//Console.WriteLine(numberOut);



//Console.WriteLine(number);

//string name = "Zahra";
//Test stu = new Test();

//stu.Name = "Inal";
//static void ChangeName(string name)
//{
//    name = "Elnur";
//    Console.WriteLine(name);
//}

//static void ChangeObj(Test stu)
//{
//    //stu.Name = "Aysel";
//    //Console.WriteLine(stu.Name);
//}

//ChangeObj(stu);
//Console.WriteLine(stu.Name);

////ChangeName(name);
////Console.WriteLine(name);

//class Test
//{
//    public string Name { get; set; }
//}

//String is immutable
//string collection = "P";

//for (int i = 0; i < 10; i++)
//{
//    collection += i;
//    Console.WriteLine(collection);
//}
#endregion



#region Array methods
int[] arr = { 88,12, 2, 3, 4, 5 ,99,100,5};

//Array.Clear(arr,2,4);
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//int[] arr2 = (int[])arr.Clone();
//arr[2] = 2000;
//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//int[] arr2 = new int[5]; 
//Array.Copy(arr,2,arr2,3,2);
//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(Array.IndexOf(arr, 5));
//Console.WriteLine(Array.LastIndexOf(arr, 5));

//Array.Resize(ref arr,15);
//arr[9] = 20000;
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//Array.Sort(arr);

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//IReadOnlyCollection<int> arr44 = Array.AsReadOnly(arr);

//foreach (var item in arr44)
//{
//    Console.WriteLine(item);
//}
#endregion