using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourGames.ViewModels
{
    /// <summary>
    /// Represents an item to be shown in the main content section in the home page
    /// </summary>
    public class HomePageItem
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string DetailsLink { get; set; }
        public string ExternalLink { get; set; }
        public string ExternalLinkText { get; set; }
        
    }
}
