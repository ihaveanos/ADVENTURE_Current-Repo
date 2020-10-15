/* Copyright (C) 2020 Kenan Marriott-Baillie */
using System;

namespace ADVENTURE{

    class Map
    {
        private Location[,] _gameMap;
        public Map( int mapSize )
        {
            _gameMap = new Location[ mapSize, mapSize ];                
        }
        public void Init()
        {
            _gameMap [0,0] = new Location ("You wake up in your warm bed to the smell of chicken dumplings cooking in the kitchen \n" +   
                              "\"Kenan, wake up honey! It's time for breakfast\" \n" +
                              "\"Do you hear me?? Get up!!\"");
            _gameMap [0,1] = new Location ( "You walk into the kitchen. Mom is cooking an excellent breakfast. \n" + 
                            "\"Hey sweetie! Sit down at the table, breakfast is just about ready\"");
            _gameMap [0,2] = new Location ( "Mom looks at you with pure admiration. \"So today is the big day huh? Bet you're excited!\"");
            _gameMap [0,3] = new Location ( "Mom immediately knows somethings up.\n" +
                            "\"What's going on, you don't seem excited at all.\"");
            _gameMap [0,4] = new Location ( "I'm just nervous is all. There's a lot riding on this and everyone's gonna be watching");
            _gameMap [0,5] = new Location ( "Mom gives you a warm smile \n" +
                              "\"It's just nerves honey. You'll be fine.\"");
            _gameMap [0,6] = new Location ( "Alright mom, I'm gonna head out. I'll see you later!");
            _gameMap [0,7] = new Location ("\"Alright sweetie, have fun!\"");
            _gameMap [0,8] = new Location ("Joanna:\n" +
                              "\"Hey there friend, you ready for the big day today?\"");
        }
        public string GetLocation(int loc, int locY)
        {
           return _gameMap[loc,locY]._description;
        }
    }
}