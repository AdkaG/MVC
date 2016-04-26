using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboration2_Uppgift2.Content;

namespace Laboration2_Uppgift2.Models
{
    public class TicTacToe
    {
        public List<BoxInfo> BoxList { get; set; }
        public List<string> Players { get; set; }
    }
}