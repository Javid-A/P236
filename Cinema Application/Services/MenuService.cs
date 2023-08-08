using Cinema_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Application.Services
{
    internal static class MenuService
    {
        private readonly static CinemaService _cinemaService;

        static MenuService()
        {
            _cinemaService = new CinemaService();
        }

        public static void CreateHall()
        {
            Console.WriteLine("Please choose category:");
        category:
            foreach (Category ctg in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"{(int)ctg}.{ctg}");
            }

            bool result = Enum.TryParse(typeof(Category), Console.ReadLine(), out object category);

            if (!result)
            {
                Console.WriteLine("Please choose valid category");
                goto category;
            }

            GetValidRowAndColumn(out byte row, out byte col);
            _cinemaService.CreateHall((Category)category, row, col);
        }
        static void GetValidRowAndColumn(out byte row, out byte col)
        {

            Console.WriteLine("Please choose row:");
        row:
            bool resultRow = byte.TryParse(Console.ReadLine(), out row);
            if (!resultRow || row == 0)
            {
                Console.WriteLine("Please choose valid row");
                goto row;
            }

            Console.WriteLine("Please choose column:");
        column:
            bool resultCol = byte.TryParse(Console.ReadLine(), out col);
            if (!resultCol || col == 0)
            {
                Console.WriteLine("Please choose valid column");
                goto column;
            }
        }
        public static void EditHall()
        {
            Console.WriteLine("Please enter hall no:");
            string old = Console.ReadLine();
            Console.WriteLine("Please enter new hall no:");
            string newNo = Console.ReadLine();

            _cinemaService.EditHall(old, newNo);
        }

        public static void ShowHalls()
        {
            _cinemaService.ShowHalls();
        }

        public static void ShowSeatsByNo()
        {
            Console.WriteLine("Please enter hall no:");
            string no = Console.ReadLine();
            _cinemaService.ShowSeatsByHallNo(no);
        }


        public static void Reserve()
        {
            Console.WriteLine("Please enter hall no:");
            string no = Console.ReadLine();

            GetValidRowAndColumn(out byte row, out byte col);

            _cinemaService.Reserve(no, row, col);
        }
    }
}
