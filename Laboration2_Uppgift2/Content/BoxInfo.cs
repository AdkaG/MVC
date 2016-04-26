using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Laboration2_Uppgift2.Content
{
    public struct BoxInfo
    {
        public int BoxCoordinate { get; private set; }

        public char Value { get; private set; }

        public BoxInfo(char value, int box)
        {
            //TODO: kontrolera value
            BoxCoordinate = box;
            Value = value;
        }
    }
}