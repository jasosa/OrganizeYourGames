﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourGames.Models
{
    public class Insert
    {
        [Key]
        public string Key { get; set; }
        public string Game { get; set; }

        public string Store { get; set; }

        public double Price { get; set; }

        public string LinkToBuy { get; set; }        

        public string Image { get; set; }
    }
}
