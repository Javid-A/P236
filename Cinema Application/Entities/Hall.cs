using Cinema_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Application.Entities
{
    internal class Hall
    {
        public string No;
        public Category Category;
        public Seat[,] Seats;
        static int count;

        public Hall(Category category,byte row, byte column)
        {
            switch (category)
            {
                case Category.SciFi:
                    No = string.Concat("SF-", count++);
                    break;
                case Category.Drama:
                    No = string.Concat("D-",count++);
                    break;
                case Category.Action:
                    No = string.Concat("A-",count++);
                    break;
                case Category.Horror:
                    No = string.Concat("H-",count++);
                    break;
                case Category.Romantic:
                    No = string.Concat("R-",count++);
                    break;
                case Category.Comedy:
                    No = string.Concat("C-",count++);
                    break;
            }

            Seats = new Seat[row,column];

            for (byte i = 0; i < row; i++)
            {
                for (byte j = 0; j < column; j++)
                {
                    Seats[i, j] = new Seat((byte)(i + 1),(byte)(j + 1));
                }
            }


        }
        static Hall()
        {
            count = 100;
        }

        public override string ToString()
        {
            return $"Hall No: {No}, Seats count: {Seats.Length}";
        }
    }
}
