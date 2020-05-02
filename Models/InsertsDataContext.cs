using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourGames.Models
{
    public class InsertsDataContext
    {
        public IEnumerable<Insert> GetLatestInserts()
        {
            Insert[] inserts = new Insert[]
            {
             new Insert{
                 Key = "51st_broken_token",
                 Game="51st State",
                 Price=36.99,
                 Store="The Broken Token",
                 LinkToBuy=  "https://thebrokentoken.com/51st-state-organizer",
                 Image="51stState_BrokenToken"
                },
             new Insert{
                 Key = "andor_game_doctors",
                 Game="Legends of Andor",
                 Price=21.17,
                 Store="The Game Doctors",
                 LinkToBuy=  "https://sales.game-drs.de/en/for-hybrid-games/38-leva-0751385593648.html",
                 Image="Andor_GameDoctors"
                },
            };

            return inserts;
        }
    }
}
