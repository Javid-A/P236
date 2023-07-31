using Abstarct__Interface;
using Abstarct__Interface.Company;

#region Homework
//Group group1 = new Group();
//Group group2 = new Group();
//Group group3 = new Group();

//group1.No = "P236";
//Console.WriteLine(group1.No);
//group1.No = "P236";
//group2.No = "P240";
//group3.No = "P245";
//group1.AvgPoint = 79;
//group2.AvgPoint = 60;
//group3.AvgPoint = 68;

//Course course = new Course();

//course.Groups[0] = group1;
//course.Groups[1] = group2;
//course.Groups[2] = group3;

////course.GetGroupByNo("P236");

//course.GetGroupsByPointRange(65,80);

#endregion


#region Polymorphism

//Idle idle = new Idle();

//Student student = new Student();

//Teacher teacher = new Teacher();
//teacher.Firstname = "Javid";
//teacher.Lastname = "Asadullayev";

//student.Firstname = "Nijat";
//student.Lastname = "Azizov";

//idle.Firstname = "Elnur";
//idle.Lastname = "Qafarzade";

//idle.GetInfo();
//student.GetInfo();
//teacher.GetInfo();

//idle.GetRoutin();
//student.GetRoutin();
//teacher.GetRoutin();

//MPT55 mpt = new MPT55();
//AK47 ak = new AK47();
//mpt.Fire();
//Console.WriteLine("AK\n");
//ak.Fire();

Minigun mini = new Minigun();
//mini.Fire();


//Student student = new Student();
//student.Firstname = "Elcan";
//student.Lastname = "Shalanov";
//Console.WriteLine(mini);
//Console.WriteLine(student);


//Person person = new Person();


#endregion


#region Abstract

//Employee employee = new Employee();

Developer developer = new Developer();

CyberSecurity cb = new CyberSecurity();

developer.WorkHours = 9;
cb.WorkHours = 10;


Console.WriteLine(developer.WorkHours);
Console.WriteLine(cb.WorkHours);

#endregion