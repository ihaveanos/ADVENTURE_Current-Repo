using System;
namespace ADVENTURE{
    class Location
    {
        string[] dialogueList = new string[20];
        string[] locationList = new string[20];
        public Location() // constructor
        {
            dialogueList[0] = "You wake up in your warm bed to the smell of chicken dumplings cooking in the kitchen \n" +   
                              "\"Kenan, wake up honey! It's time for breakfast\" \n" +
                              "\"Do you hear me?? Get up!!\"";
            dialogueList[1] = "You walk into the kitchen. Mom is cooking an excellent breakfast. \n" + 
                            "\"Hey sweetie! Sit down at the table, breakfast is just about ready\"";
            dialogueList[2] = "Mom looks at you with pure admiration. \"So today is the big day huh? Bet you're excited!\"";
            dialogueList[3] = "Mom immediately knows somethings up.\n" +
                            "\"What's going on, you don't seem excited at all.\"";
            dialogueList[4] = "I'm just nervous is all. There's a lot riding on this and everyone's gonna be watching";
            dialogueList[5] = "Mom gives you a warm smile \n" +
                              "\"It's just nerves honey. You'll be fine.\"";
            dialogueList[6] = "Alright mom, I'm gonna head out. I'll see you later!";
            dialogueList[7] = "\"Alright sweetie, have fun!\"";
            dialogueList[8] = "Joanna:\n" +
                              "\"Hey there friend, you ready for the big day today?\"";
            dialogueList[9] = "Joanna:\n" +
                              "\"No problem, the usual today?\"\n" +
                              "Joanna hands you the sweet roll";
            dialogueList[10] = "Joanna:\n" +
                               "\"Sure thing friend, got one right here for ya!\"\n" +
                               "Joanna hands you the sweet roll";
            dialogueList[11] = "You hear some muffled bumps and shuffling from behind the large wooden door.\n" +
                                "Jamie opens the door and his initially blank face quickly turns in to a warm smile";
            
            locationList[0] = "\"Home\"";
            locationList[1] = "You open the door and step outside.";
            locationList[2] = "You step onto the main street.\n" +
                              "Straight ahead is the bakery, to the left is ceremony square, and to the right is Jamie's house";
            locationList[3] = "You step into the bakery. It smells AMAZING.";
            locationList[4] = "You decide now is not the time to procrastinate.\n" +
                              "You hang a left and press on";
            locationList[5] = "You walk over to Jamie's place and knock on the door";
        }
        
          



    }




}