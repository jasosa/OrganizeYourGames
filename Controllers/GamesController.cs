using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;

namespace OrganizeYourGames.Controllers
{
    [Route("games")]
    public class GamesController : Controller
    {
        private GamesDataContext data;

        public GamesController(GamesDataContext data)
        {
            this.data = data;
        }


        [Route("{name}")]
        public IActionResult Inserts(string name)
        {
            var game = data.Games.Where(g => g.Name == name).SingleOrDefault();
            return View(game);
        }
    }
}