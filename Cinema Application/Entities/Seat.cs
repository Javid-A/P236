using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Application.Entities
{
    internal class Seat
    {
        public byte Row;
        public byte Column;
        public bool IsFull;

        public Seat(byte row, byte column, bool isFull=false)
        {
            Row = row;
            Column = column;
            IsFull = isFull;
        }

        public override string ToString()
        {
            return $"Row: {Row}, Column: {Column}, Status: {(IsFull ? "Reserved":"Empty")}";
        }
    }
}
