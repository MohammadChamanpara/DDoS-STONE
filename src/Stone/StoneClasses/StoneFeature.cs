using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stone.StoneClasses
{
    public class StoneFeatures
    {
        public double Frequency { get; set; }

        public double Weight { get; set; }

        public double LifeTime { get; set; }
        public Boolean HasValue
        {
            get
            {
                return (LifeTime != 0 || this.Weight != 0 || this.Frequency != 0);
            }
        }
    }
}
