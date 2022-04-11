using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMonsterLibrary
{
    public class MethodWarehouse
    {

        public static string GetRoom()
        {
            string[] rooms =
            {
                            "You meet an old foe in an open field.",
                            "You enter a pretty pink powder room and instantly get glitter on you.",
                            "You arrive in a room filled with chairs and a ticket stub machine... the dreaded DMV",
                            "You enter a quiet library... silence... nothing but silence....",
                            "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                            "Oh my.... what is that smell? You appear to be standing in a compost pile",
                            "You enter a dark room and all you can hear is hair metal music blaring.... This is going to be bad!",
                            "The room looks just like the room you are sitting in right now... or does it?",
            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }
        
        
        
    }
}
