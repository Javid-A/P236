using Cinema_Application.Entities;
using Cinema_Application.Enums;
using Cinema_Application.Services;
Console.WriteLine("Welcome our Cinema");

byte selection;
do
{
    //Console.Clear();
    Console.WriteLine("1.Create hall");
    Console.WriteLine("2.Edit hall");
    Console.WriteLine("3.Show halls");
    Console.WriteLine("4.Show seats by hall no");
    Console.WriteLine("5.Reserve");
    Console.WriteLine("0.Exit");
    bool result = byte.TryParse(Console.ReadLine(), out selection);

    if (result)
    {
        switch (selection)
        {
            case 1:
                MenuService.CreateHall();
                break;
            case 2:
                MenuService.EditHall();
                break;
            case 3:
                MenuService.ShowHalls();
                break;
            case 4:
                MenuService.ShowSeatsByNo();
                break;
            case 5:
                MenuService.Reserve();
                break;
        }
    }
} while (selection != 0);