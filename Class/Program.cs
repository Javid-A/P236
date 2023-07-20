
#region Classworks
static void SetArrayElements()
{
    Console.WriteLine("Enter valid array length");
    string numberStr = Console.ReadLine();
    int number;
    bool result = int.TryParse(numberStr, out number);
    if (!result)
    {
        Console.WriteLine("Please enter valid number");
        return;
    }
    int[] arr = new int[number];

    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Enter valid array element value");
        bool resultNum = int.TryParse(Console.ReadLine(), out int num);

        if (resultNum)
        {
            arr[i] = num;
        }
    }


    foreach (int num in arr)
    {
        Console.WriteLine(num);
    }
}

static int Max(int num1, int num2, int num3)
{
    if (num1 > num2 && num1>num3)
    {
        return num1;
    }else if(num2>num1 && num2 > num3)
    {
        return num2;
    }
    else
    {
        return num3;
    }
}

//bool result1 = int.TryParse(Console.ReadLine(), out int num1);
//bool result2 = int.TryParse(Console.ReadLine(), out int num2);
//bool result3 = int.TryParse(Console.ReadLine(), out int num3);

//Console.WriteLine(Max(num1, num2, num3));




int[] arr = { 2, 4, -30, -100, 50, 23,54,-200,90 };//{-200,54,23,50,-100,-30,4,2}=>{ 2, 4, -30, -100, 50, 23,54,-200 }


for (int i = 0; i < arr.Length/2; i++)
{
    int current = arr[i];//2
    arr[i] = arr[arr.Length - 1-i];//23
    arr[arr.Length-1-i] = current;//2
}

foreach (var item in arr)
{
    Console.WriteLine(item);

}
#endregion