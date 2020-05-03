using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;
using System.Linq;

namespace OrganizeYourGames.ViewComponents
{
    /// <summary>
    /// Component to load and show all the inserts of a given game
    /// </summary>
    public class InsertsOfAGameViewComponent : ViewComponent
    {
        private GamesDataContext data;        

        public InsertsOfAGameViewComponent(GamesDataContext data)
        {
            this.data = data;            
        }

        public IViewComponentResult Invoke(string game)
        {
            var insertsOfAGame = data.Inserts.Where(i => i.Game == game).ToList();
            return View(insertsOfAGame);
        }
    }
}
