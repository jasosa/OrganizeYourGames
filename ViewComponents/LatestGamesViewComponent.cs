using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;
using System.Linq;

namespace OrganizeYourGames.ViewComponents
{

    /// <summary>
    /// Component to load and show the latest added games
    /// </summary>
    public class LatestGamesViewComponent : ViewComponent
    {
        GamesDataContext data;
        
        public LatestGamesViewComponent(GamesDataContext data)
        {
            this.data = data;            
        }

        public IViewComponentResult Invoke()
        {
            var latestGamesInHomePage = data.Games.ToList();            
            return View(latestGamesInHomePage);

        }
    }
}
