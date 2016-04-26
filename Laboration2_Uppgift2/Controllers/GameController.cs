using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboration2_Uppgift2.Content;
using Laboration2_Uppgift2.Models;

namespace Laboration2_Uppgift2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult TicTacToe()
        {
            var ticTacToeModel = new TicTacToe();
            ticTacToeModel.BoxList = new List<BoxInfo>()
            {
                new BoxInfo('x', 1),
                new BoxInfo('o', 2),
                new BoxInfo('x', 3),
                new BoxInfo('o', 7)
            };
            ticTacToeModel.Players = new List<string>() { "Adriana", "Erik" };
            return View(ticTacToeModel);
        }
    }
}