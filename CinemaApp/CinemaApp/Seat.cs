using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Status { get; set; }

        public Seat(int row,int column)
        {
            Status = "Empty";
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return $"Row:{Row}, Column:{Column} is {Status}";
        }
    }
}
