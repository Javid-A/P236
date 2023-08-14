using Generic_type__Collections;
using System.Xml.Linq;

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



CustomList<Group> customList = new CustomList<Group>();


customList.Add(new Group("P236",1));
customList.Add(new Group("P300",70));
customList.Add(new Group("P400",95));


Console.WriteLine(customList.Count);


customList.ShowInside();


//CustomDictionary<string, string> prod = new CustomDictionary<string, string>();

//CustomDictionary<long, byte> prod1 = new CustomDictionary<long, byte>();
//CustomDictionary<IComparable, IQueryable> prod2 = new CustomDictionary<IComparable, IQueryable>();
//CustomDictionary<IComparable, Group> prod3 = new CustomDictionary<IComparable, Group>();
