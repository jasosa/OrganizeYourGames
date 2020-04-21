﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourGames.Models
{
    public class GamesDataContext
    {
        public IEnumerable<Game> GetLatestGames()
        {
            Game[] games = new Game[]
            {
             new Game{
                 Name="Journeys in the middle earth",
                 Publisher="Fantasy Flight Games",
                 PublishedIn=2019,
                 Description=   @"Form your Fellowship and set out on your own adventures in The Lord of the Rings: Journeys in Middle-earth, a fully-cooperative, app-supported board game set in J.R.R. Tolkien’s iconic land of Middle-earth! As the dark forces gather, players band together to unravel mysteries, make courageous choices, and fight against the evil that threatens the land.
                                No matter if you choose to set out on your own or venture forth with four other players, a free companion app takes control of the evil forces arrayed against you, freeing you and your companions to stand together in a single Fellowship and battle against the darkness. What’s more, the app guides you through entire campaigns, filling each adventure with content from a host of possibilities and allowing you to leave your own mark on Middle - earth.",
                 Version=String.Empty, BBGLink="https://boardgamegeek.com/boardgame/269385/lord-rings-journeys-middle-earth",
                 ImagePath="journeys",
                 NumberOfOrganizers = 3},
             new Game{
                 Name="Mice & Mystics",
                 Publisher="Plaid Hat Games",
                 PublishedIn=2012,
                 Description=   @"In Mice and Mystics, players take on the roles of those still loyal to the king – but to escape the clutches of Vanestra, 
                                they have been turned into mice! Play as cunning field mice who must race through a castle now twenty times larger than before. 
                                The castle would be a dangerous place with Vanestra's minions in control, but now countless other terrors also await heroes who are but the size of figs. 
                                Play as nimble Prince Collin and fence your way past your foes, or try Nez Bellows, the burly smith. Confound your foes as the wizened old mouse Maginos, or protect your companions as Tilda, the castle's former healer. Every player will have a vital role in the quest to warn the king, and it will take careful planning to find Vanestra's weakness and defeat her.",
                 Version=String.Empty, BBGLink="https://boardgamegeek.com/boardgame/124708/mice-and-mystics",
                 ImagePath="mice",
                 NumberOfOrganizers = 2},
             new Game{
                 Name="Everdell",
                 Publisher="Maldito Games",
                 PublishedIn=2012,
                 Description=   @"Within the charming valley of Everdell, beneath the boughs of towering trees, among meandering streams and mossy hollows, a civilization of forest critters is thriving and expanding. 
                                From Everfrost to Bellsong, many a year have come and gone, but the time has come for new territories to be settled and new cities established. 
                                You will be the leader of a group of critters intent on just such a task. There are buildings to construct, 
                                lively characters to meet, events to host—you have a busy year ahead of yourself. Will the sun shine brightest on your city before the winter moon rises?",
                 Version=String.Empty, BBGLink="https://boardgamegeek.com/boardgame/199792/everdell",
                 ImagePath="everdell",
                 NumberOfOrganizers = 2},
             new Game{
                 Name="Chai",
                 Publisher="Steeped Games",
                 PublishedIn=2018,
                 Description=   @"In Chai, you will step into the shoes of a tea merchant, combining tea flavours to make a perfect blend. Specializing in either rooibos, green, oolong, 
                                black or white tea, you will buy and collect ingredients to fulfill your customers’ orders.",
                 Version=String.Empty, BBGLink="https://boardgamegeek.com/boardgame/253185/chai",
                 ImagePath="chai",
                NumberOfOrganizers = 1},
             new Game{
                 Name = "Ecos",
                 Publisher = "AEG",
                 PublishedIn = 2019,
                 Description = @"In Ecos: First Continent, players are forces of nature molding the planet, but with competing visions of its grandeur. You have the chance to create a part of the world, similar but different to the one we know. 
                                Which landscapes, habitats, and species thrive will be up to you.",
                 Version = String.Empty,
                 BBGLink = "https://boardgamegeek.com/boardgame/279254/ecos-first-continent",
                 ImagePath = "ecos",
                 NumberOfOrganizers = 1}
            };

            return games;
        }
    }
}