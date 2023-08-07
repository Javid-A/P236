using Cinema_Application.Entities;
using Cinema_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Application.Services
{
    internal interface ICinemaService
    {
        Hall[] Halls { get;}
        void CreateHall(Category category, byte row, byte column);
        void EditHall(string oldNo, string newNo);
        void ShowHalls();
        void ShowSeatsByHallNo(string no);
        void Reserve();
    }
}
