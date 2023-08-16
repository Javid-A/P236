

//int five = 5;
//int zero = 0;
//    int[] arr = new int[2];
//try
//{

//    //int total = five / zero;//divide by zero exception
//    //arr[3] = 5;//index was outside the bounds of array
//    //List<int> test = null;
//    //test.Add(5);//NullReferenceException
//    int.Parse("Asdasd");//FormatException
//    //Another exceptions
//}
//catch (NullReferenceException exp)
//{
//    //process
//    Array.Resize(ref arr,arr.Length+1);
//    Console.WriteLine(exp.Message);
//}
//catch (IndexOutOfRangeException exp)
//{
//    Console.WriteLine(exp.Message);
//}
//catch (DivideByZeroException exp)
//{
//    Console.WriteLine(exp.Message);
//}
//catch (FormatException exp)
//{
//    throw new FormatException("Test exception");
//    Console.WriteLine(exp.Message);
//}
//catch (System.Exception exp)
//{
//    Console.WriteLine(exp.Message);
//}
//finally
//{
//    Console.WriteLine("finally");
//}
//Console.WriteLine("Hello");

new Int32
using Exception;

int age = 17;

try
{
	if (age < 18)
	{
		throw new AgeOutOfRangeException();
	}
}
catch (System.Exception)
{

	throw;
}