using Microsoft.AspNetCore.Mvc;
using OrganizeYourGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourGames.ViewComponents
{
    public class LatestInsertsViewComponent : ViewComponent
    {
        InsertsDataContext data;
        public LatestInsertsViewComponent(InsertsDataContext data)
        {
            this.data = data;
        }
        public IViewComponentResult Invoke()
        {
            var specials = data.GetLatestInserts().ToArray();
            return View(specials);
        }
    }
}
