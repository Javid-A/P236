using Reflection__Filestream__Multi_task;
using System.Diagnostics;
using System.Reflection;
#region Homework

//MainPrintFile printer = new MainPrintFile(new Nijat());

Product product1 = new Product("Monitor", 100, 4);
Product product2 = new Product("Mouse", 50, 5);
Product product3 = new Product("Keyboard", 70, 3);

List<Product> products = new List<Product>()
{
    product1,
    product2,
    product3
};


Order order = new Order();
order.Products = products;

order.Sale();
Order order2 = new Order();
order2.Products = products;

order2.Sale(order2.AnotherCondition);

#endregion

#region Predicate
//Predicate<int> predicate = (num) => num > 7;
//Console.WriteLine(predicate(5));

//List<int?> list = new List<int?>()
//{
//    1,2,3,4,5,6,10,20,30,40,55,555,60,123,8127
//};

//List<int?> newList = list.Where((x) => x > 60).ToList();

//newList.ForEach(x =>
//{
//    Console.WriteLine(x);
//});

//foreach (var x in newList)
//{
//    Console.WriteLine(x);
//}

//int? found = list.FirstOrDefault(e => e == 50);
//Console.WriteLine(found);

//var newProducts = products.Where(x=>x.Price>55).Select(x => new ProductDto
//{
//    Price = x.Price
//});

//foreach (var item in newProducts)
//{
//    Console.WriteLine(item.);
//}
#endregion

#region FileStream
//string desktopPath = @"C:\Users\Lenovo\Desktop";
//string p236FolderName = "P236";
//string txtFile = "test.txt";

//string p236Folder = Path.Combine(desktopPath, p236FolderName);
//string filePath = Path.Combine(desktopPath, txtFile);
//Console.WriteLine(Directory.CreateDirectory(p236Folder).Parent);

//Directory.Delete(p236Folder);


//Console.WriteLine(Directory.Exists(p236Folder));

//File.Create(filePath);

//Console.WriteLine(File.Exists(filePath));

//File.WriteAllText(filePath,"Salam");

//string article = File.ReadAllText(filePath);
//string[] article2 = File.ReadAllLines(filePath);
//foreach (var item in article2)
//{
//    Console.WriteLine(item);
//}





//using (StreamWriter stream = new StreamWriter(filePath))
//{
//    stream.WriteLine("Salam asdkaskdas");
//}

//StreamReader reader = new StreamReader(filePath);

//string article3= reader.ReadLine();

//Console.WriteLine(article3);

//FileStream stream = new FileStream();
#endregion

#region Reflection
//Assembly assembly = Assembly.GetExecutingAssembly();

//Type[] types = assembly.GetTypes();

//foreach (var type in types)
//{
//    Console.WriteLine(type.Name);
//    //foreach (var field in type.GetFields())
//    //{
//    //       Console.WriteLine(field.Name);
//    //   }
//    //foreach (var field in type.GetProperties())
//    //{
//    //    Console.WriteLine(field.Name);
//    //}
//    //foreach (var field in type.GetMethods())
//    //{
//    //    Console.WriteLine(field.Name);
//    //}
//}

//ProductDto dto = new ProductDto("First");
//ProductDto dto2 = new ProductDto("Second");
//ProductDto dto3 = new ProductDto("Third");
//ProductDto dto4 = new ProductDto("Fourth");

//Type dtoType = dto.GetType();

//FieldInfo[] fields = dtoType.GetFields();

//fields.ToList().ForEach(x =>
//{
//    Console.WriteLine(x.Name);
//});
//FieldInfo privateField = dtoType.GetField("PrivateField", BindingFlags.NonPublic | BindingFlags.Instance);


//privateField.SetValue(dto,"We can change private field value");
//Console.WriteLine(privateField.GetValue(dto));
#endregion


#region Asynchronous programming

//Thread thread0 = new Thread(() =>
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.Write(0);
//    }
//});


//Thread thread1 = new Thread(() =>
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.Write(1);
//    }
//});
//thread0.Start();
//thread0.Join();
//thread1.Start();


//Task task = Task.Run(() =>
//{
//    Console.WriteLine("Hello world");
//});
//for (int i = 0; i < 100; i++)
//{
//    Console.Write("");
//}
//Console.Read();
//Boiling();
//Cleaning();
//Cooking();

//Console.Read();


HttpClient client = new HttpClient();

//Stopwatch watch = Stopwatch.StartNew();
//string source = await client.GetStringAsync("https://www.google.com");
//Console.WriteLine(source.Contains("html"));

Task<string> source1 = client.GetStringAsync("https://www.google.com");

await source1.ContinueWith(t =>
{
    Console.WriteLine(t.Result.Contains("html"));
});
//Task<string> source2 = client.GetStringAsync("https://www.google.com");
//Task<string> source3 = client.GetStringAsync("https://www.google.com");
//string source = await client.GetStringAsync("https://www.google.com");
//string source1 = await client.GetStringAsync("https://www.google.com");
//string source2 = await client.GetStringAsync("https://www.google.com");
//string source3 = await client.GetStringAsync("https://www.google.com");
Console.WriteLine("Hello");
Console.WriteLine("Hello1");
Console.WriteLine("Hello2");
Console.WriteLine("Hello3");
Console.WriteLine("Hello4");
//watch.Stop();
//Console.WriteLine(watch.ElapsedMilliseconds);
Console.ReadLine();


static async void Boiling()
{
     await Task.Run(() =>
    {
        Console.WriteLine("Start boiling");
        Thread.Sleep(1500);
        Console.WriteLine("Boiling end");
    });
    Task task = Task.Run(() =>
    {
        Console.WriteLine("Start tea");
        Thread.Sleep(10000);
        Console.WriteLine("Tea end");
    });
}

static void Cleaning()
{
    Task task = Task.Run(() =>
    {
        Console.WriteLine("Start cleaning");
        Thread.Sleep(3000);
        Console.WriteLine("Cleaning end");
    });
}

static void Cooking()
{
    Task task = Task.Run(() =>
    {
        Console.WriteLine("Start cooking");
        Thread.Sleep(1000);
        Console.WriteLine("Cooking end");
    });
}
#endregion