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
            var insertsOfAGame = data.Inserts.Select(i => new HomePageItem
            {
                ItemType = HomePageItemType.Insert,
                Image = i.Image,
                Description = string.Format("Organizer for {0} from {1}", i.Game, i.Store),
                ExternalLink = i.LinkToBuy,
                ExternalLinkText = "Buy it",
                Title = i.Game
            }).ToList();            

            return View(insertsOfAGame);
        }
    }
}
