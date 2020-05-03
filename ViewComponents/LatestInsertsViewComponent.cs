using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;
using System.Linq;

namespace OrganizeYourGames.ViewComponents
{
    /// <summary>
    /// Component to load and show the latest added inserts
    /// </summary>
    public class LatestInsertsViewComponent : ViewComponent
    {
        GamesDataContext data;
        public LatestInsertsViewComponent(GamesDataContext data)
        {
            this.data = data;            
        }

        public IViewComponentResult Invoke()
        {
            //TODO Order by added_date
            var latestInsertsInHomePage = data.Inserts.Take(5).ToList();
            return View(latestInsertsInHomePage);
        }
    }
}
