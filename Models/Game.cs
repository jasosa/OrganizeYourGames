using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourGames.Models
{
    public class Game
    {      
        [Key]
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Version { get; set; }
        public int PublishedIn { get; set; }
        public string Description { get; set; }
        public string BBGLink { get; set; }
        public string ImagePath { get; set; }
        public int NumberOfOrganizers{ get; set; }
    }
}
