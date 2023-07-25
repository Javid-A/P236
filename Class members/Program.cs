using Class_members;
using System.Text;

#region First homework
string sentence = "thiS IS TesT MesSAgE";


//Console.WriteLine(ToCapitalized(sentence));
static string ToCapitalized(string sentence)
{
    string lowerSentence = sentence.ToLower();
    string[] arr = lowerSentence.Split();
    StringBuilder result = new StringBuilder();
    foreach (var word in arr)
    {
        result.Append(char.ToUpper(word[0]));
        for (int i = 1; i < word.Length; i++)
        {
            result.Append(word[i]);
        }
        result.Append(' ');
    }
    return result.ToString();

}
#endregion
#region Second homework
//Console.WriteLine(SetPreviousNumber(8544,1));
//static double SetPreviousNumber(int number,int previous)
//{
//    int copy = number;

//    int count = 0;
//    while (copy > 0)
//    {
//        copy /= 10;
//        count++;
//    }

//    double pow = Math.Pow(10, count);

//    pow = (pow * previous) + number;

//    return pow;
//}
#endregion


Student student = new Student("Aysel","Aliyeva",30,"UX/UI");
Student student1 = new Student("Zahra", "Rzazade", 19, "Programming");

student.GetInfo();
student1.GetInfo();

//if (student.CheckAge())
//{
//    Console.WriteLine("Zemanetli tehsile uygunsuz");
//}
//else
//{
//    Console.WriteLine("Uygun deyilsiz");
//}


//if (student1.CheckAge())
//{
//    Console.WriteLine("Zemanetli tehsile uygunsuz");

//}
//else
//{
//    Console.WriteLine("Uygun deyilsiz");
//}






