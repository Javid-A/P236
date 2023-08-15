using Generic_type__Collections;
using System.Collections;
using System.Xml.Linq;

#region Generic type
#region Worst case
//Item item = new Item("Very Good");

////Console.WriteLine(item.Quality);

//Item item2 = new Item(100);

//Console.WriteLine(item2.quality);


//Item item3 = new Item('A');

//Console.WriteLine(item3._quality);
#endregion

//Item<bool> item = new Item<bool>(true);
//Item<char> item2 = new Item<char>('A');
//Item<string> item3 = new Item<string>("Awesome");
//Item<double> item4 = new Item<double>(99.78);
//Item<DateTime> item5 = new Item<DateTime>(DateTime.Now);


//Console.WriteLine(item.Quality);
//Console.WriteLine(item2.Quality);
//Console.WriteLine(item3.Quality);
//Console.WriteLine(item4.Quality);
//Console.WriteLine(item5.Quality);

Int32List list = new Int32List();

//list.Add(10);
//list.Add(100);
//list.Add(120);
//list.Add(1980);

//list.ShowInside();


//CustomList<string> custom = new CustomList<string>();

//custom.Add("1");
//custom.Add("2");
//custom.Add("3");
//custom.Add("4");

//Console.WriteLine(custom.Count);

//custom.ShowInside();



//CustomList<Group> customList = new CustomList<Group>();


//customList.Add(new Group("P236", 1));
//customList.Add(new Group("P300", 70));
//customList.Add(new Group("P400", 95));


//Console.WriteLine(customList.Count);


//customList.ShowInside();


//CustomDictionary<string, string> prod = new CustomDictionary<string, string>();

//CustomDictionary<long, byte> prod1 = new CustomDictionary<long, byte>();
//CustomDictionary<IComparable, IQueryable> prod2 = new CustomDictionary<IComparable, IQueryable>();
//CustomDictionary<IComparable, Group> prod3 = new CustomDictionary<IComparable, Group>();

#endregion


#region Collections
//ArrayList items = new ();
//items.Add(1);
//items.Add(2.5);
//items.Add('a');
//items.Add("Test");
//items.Add(new DateTime());

//items.RemoveAt(3);

//ArrayList another = new()
//{
//    1,
//    5.5m,
//    "Another",
//    "Elnur",
//    new
//    {
//        Id=1,
//        Name = "Test"
//    },
//    new Teacher()
//};

//items.AddRange(another);
//ArrayList range = items.GetRange(0,2);

//foreach (var item in range)
//{
//    Console.WriteLine(item);
//}
//items.Remove("Elnur");
//items.RemoveRange(0,items.Count);

//foreach (var item in items)
//{
//    Console.WriteLine(item);
//}


//SortedList sorted = new SortedList();

//sorted.Add("P400","Nicat,Elnur,Xadica");
//sorted.Add("P236","Elcan,Zahra,Nicat");
//sorted.Add("P300","Inal,Zahra,Aysel");
//sorted.Add("P500", new DateTime());

//foreach (DictionaryEntry item in sorted)
//{
//    Console.WriteLine(item);
//    //if (item.Value is string value)
//    //{
//    //    string[] names = value.Split(',');
//    //    Console.WriteLine(item.Key);
//    //    foreach (string name in names)
//    //    {
//    //        Console.WriteLine(name);
//    //    }
//    //}

//    string value = item.Value as string;

//    if (value is not null)
//    {
//        string[] names = value.Split(',');
//        Console.WriteLine(item.Key);
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}




//static void TestAdd(object key, object value)
//{
//    Type type = null;
//    int count=0;
//    if(count == 0)
//    {
//        type = key.GetType();
//    }
//    if(type != typeof(string))
//    {
//        throw new Exception();
//    }
//}


//SortedList<string, double> products = new SortedList<string, double>();

//products.Add("asd2ewda",20.3);
//products.Add("567asfa",30.3);
//products.Add("kjhgfd567",20.3);
//products.Add("XssWqAsd23",40.3);
//products.Add("k12dezsd",53.6);


//foreach (var item in products)
//{
//    Console.WriteLine(item.Key);
//}


//Dictionary<char, string> queryDatas = new Dictionary<char, string>();
//queryDatas.TryAdd('q',"test+123+test");
//queryDatas.TryAdd('d', "15/08/2023+16/08/2023");

//var result = queryDatas.TryAdd('q', "asdasjdaskdaksdka");

//Console.WriteLine(result);
//foreach (var item in queryDatas)
//{
//    Console.WriteLine(item.Key);
//    foreach (var query in item.Value.Split('+'))
//	{
//        Console.WriteLine(query);
//    }
//}


Queue<string> queue = new Queue<string>();

queue.Enqueue("Aysel");
queue.Enqueue("Zahra");
queue.Enqueue("Elcan");
queue.Enqueue("Nijat");

Console.WriteLine();

//string person = queue.Dequeue();
//Console.WriteLine(person + " Ishiniz bitdi");
string person = queue.Peek();

Console.WriteLine(string.Concat(person," Zehmet olmasa B2 masasina yaxinlasin"));
Console.WriteLine("Novbedekiler");
foreach (var item in queue)
{
    Console.WriteLine(item);
}


Stack<string> stack = new Stack<string>();


stack.Push("Elnur");
stack.Push("Inal");

foreach (var item in stack)
{
    Console.WriteLine(item);
}

List<string> list2 = new List<string>();
//list2.AddRange();
#endregion
