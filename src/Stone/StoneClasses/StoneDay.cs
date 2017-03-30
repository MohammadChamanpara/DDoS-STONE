using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stone.StoneClasses
{
    public class StoneDay
    {
        public StoneDay(int number)
        {
            this.Number = number;
        }
        public double Weight { get; set; }
        public int Number { get; set; }
    }
}
