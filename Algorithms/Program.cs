#region 1. Algorithm
//int number = 5;
//int sum = 0;

//for (int i = 1; i < number; i++)
//{
//    sum += i;// sum = sum + i
//}

//Console.Write(sum);

#endregion

#region 2. Algorithm
//int num = 5;
//int factorial = 1;

//for (int i = 1; i <= num; i++)
//{
//    factorial = factorial * i; // factorail*=i;
//}
//Console.WriteLine(factorial);
#endregion

#region 3. Algorithm
//int[] arr = { 1, 2, 3, 4, 5,6 };//0,1,2,3,4,5
//int asdfgh = 0;// Ayselin telebi ile bu variable-nin adi bu gune dushdu

//for (int i = 0; i < arr.Length; i++)
//{
//    if (i % 2 == 1)
//    {
//        asdfgh += arr[i];
//    }
//}

//Console.WriteLine(asdfgh);
#endregion

#region 4. Algorithm
//int[] arr2 = { 6, 10, 20, 46, 88 };
//bool result = true;

//foreach (int num in arr2)
//{
//    if (num % 2 == 1)
//    {
//        result = false;
//        break;
//    }
//}

//Console.WriteLine(result);
#endregion

#region Power of 2
//int number = 127;

//while (number>1)
//{
//    if (number % 2 == 0)
//    {
//        number /= 2;//number = number / 2
//    }
//    else
//    {
//        break;
//    }
//}

//if (number == 1)
//{
//    Console.WriteLine("Eded 2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("Eded 2-nin quvveti deyil");
//}

#endregion

#region Count of letter's factorial
//string sentence = "Hello P236, this lesson is about algorithms";
//int count = 0;
//foreach (char letter in sentence)
//{
//    if (letter == 't')
//    {
//        count++;
//    }
//}
//int factorial = 1;
//for (int i = 1; i <= count; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine(factorial);

#endregion

#region Names which length is less than 5
//string[] names = { "Xadica", "Aysel", "Zahra", "Nijat", "Inal", "Elnur", "Eljan" };

//foreach (string name in names)
//{
//    if (name.Length < 5)
//    {
//        Console.WriteLine(name);
//    }
//}
#endregion

#region Numerical average
//string[] students = { "Xadica", "Aysel", "Zahra", "Nijat", "Inal", "Elnur", "Eljan" };
//double SumOfLength = 0;
//foreach (string student in students)
//{
//    SumOfLength += student.Length;
//}
//double average = SumOfLength / students.Length;
//Console.WriteLine(average);
#endregion