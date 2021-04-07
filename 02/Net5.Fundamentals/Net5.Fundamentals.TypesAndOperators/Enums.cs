using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    enum Season
    {
        Spring,
        Summer,
        Autum,
        Winter
    }

    enum Errorcode : ushort
    {
        None = 0,
        unknow = 1,
        ConnectionLost = 100,
        OutLierReading = 200
    }
}
