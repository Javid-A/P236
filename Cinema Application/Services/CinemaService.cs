using Cinema_Application.Entities;
using Cinema_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Application.Services
{
    internal class CinemaService : ICinemaService
    {
        Hall[] _halls;//private readonly access modifier-i set olundugu field ve ya prop sadece ve sadece constructor daxilinde set oluna biler
        public Hall[] Halls => _halls;

        public CinemaService()
        {
            _halls = new Hall[0];
        }
        public void CreateHall(Category category, byte row, byte column)
        {
            Hall hall = new Hall(category, row, column);
            Array.Resize(ref _halls, _halls.Length + 1);
            _halls[_halls.Length - 1] = hall;
            Console.WriteLine($"{hall.No} hall has successfully added");
        }

        public void EditHall(string oldNo, string newNo)
        {
            Hall hall = FindHall(oldNo);
            if (hall is null)
            {
                Console.WriteLine($"{oldNo} hall cannot be found");
            }
            else
            {
                Console.WriteLine($"{hall.No} hall has been successfuly changed to {newNo}");
                hall.No = newNo;
            }
        }

        Hall FindHall(string oldNo)
        {
            Hall existedHall = null;
            string changedOldNo = oldNo.Replace("-", "").ToLower().Trim();
            foreach (Hall hall in _halls)
            {
                string currentNo = hall.No.Replace("-", "").ToLower().Trim();
                if (currentNo == changedOldNo)
                {
                    existedHall = hall;
                }
            }
            return existedHall;
        }
        public void ShowHalls()
        {
            foreach (Hall hall in _halls)
            {
                Console.WriteLine(hall);
            }
        }
        
        public void ShowSeatsByHallNo(string no)
        {
            Hall hall = FindHall(no);
            if (hall is null)
            {
                Console.WriteLine($"{no} hall cannot be found");
                return;
            }
            foreach (Seat seat in hall.Seats)
            {
                Console.WriteLine(seat);
            }
        }
        public void Reserve(string no,byte row, byte column)
        {
            Hall hall = FindHall(no);
            if(hall is null)
            {
                Console.WriteLine($"{no} cannot be found");
                return;
            }
            
            if(row>hall.Seats.GetLength(0) || column > hall.Seats.GetLength(1))
            {
                Console.WriteLine("Please choose valid row or column");
                return;
            }

            if (!hall.Seats[row-1,column-1].IsFull)
            {
                Console.WriteLine($"You have successfuly reserved Row:{row}, Column{column}");
                hall.Seats[row - 1, column - 1].IsFull = true;
            }
            else
            {
                Console.WriteLine("Please choose another seat");
                ShowSeatsByHallNo(no);
            }
        }
    }
}
