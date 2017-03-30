using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stone.Model;

namespace Stone
{
    public static class DB
    {
        public static Stone_DBEntities NewContext()
        {
            return new Model.Stone_DBEntities();
        }
    }
}
