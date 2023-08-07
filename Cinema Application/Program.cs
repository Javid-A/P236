using Cinema_Application.Entities;
using Cinema_Application.Enums;
using Cinema_Application.Services;

//Hall hall = new Hall(Category.SciFi, 3, 6);
//Hall hall2 = new Hall(Category.SciFi, 2, 5);

CinemaService cinemaService = new CinemaService();

cinemaService.CreateHall(Category.SciFi, 3, 6);
cinemaService.CreateHall(Category.SciFi, 2, 6);
cinemaService.CreateHall(Category.Drama, 5, 6);

cinemaService.ShowHalls();
cinemaService.ShowSeatsByHallNo("sf100");


//foreach (var item in hall.Seats)
//{
//    Console.WriteLine(item.Row + "=>" + item.Column);
//}


