﻿using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;
using OrganizeYourGames.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var latestInsertsInHomePage = data.Inserts.Select(g => new HomePageItem
            {
                ItemType = HomePageItemType.Insert,
                Image = g.Image,
                Description = string.Format("Organizer for {0} from {1}", g.Game, g.Store),
                ExternalLink = g.LinkToBuy,
                ExternalLinkText = "Buy it",
                Title = g.Game
            }).ToList();            

            return View(latestInsertsInHomePage);
        }
    }
}
