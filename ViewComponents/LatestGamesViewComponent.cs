using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;
using OrganizeYourGames.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var latestGamesInHomePage = data.Games.Select(g => new HomePageItem
            {
                Image = g.ImagePath,
                Description = string.Format("Inserts/Organizers: {0}", g.NumberOfOrganizers),
                Title = g.Name
            }).ToList();

            return View(latestGamesInHomePage);

        }
    }
}
