using System;

namespace ADVENTURE //random change
{
    class Program
    {
        static void example(string name = "kenan")
        { // function 
            name = "shawn";
        }
        

        static void Main(string[] args)
        {
           example();
            Console.WriteLine("Welcome to your adventure!!");
            
            bool isvalidinput = false;
            string[] dialogueList = new string[20];
            string[] promptList = new string[20];
            string[] locationList = new string[20];
            string[] descriptiveList = new string[20];
            // the dialogue lists here are basically taking over locations. there is still a location section, but lots of things happen in the home location. 
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
                         
                        
            promptList[0] = "What do you do?\na) Pretend to be asleep.\nb) \"Five more minutes\"\nc) Get your lazy butt up";
            promptList[1] = "a) Get out of bed.";
            promptList[2] = "a) Sit down.";
            promptList[3] = "a) \"Yea totally...\"\nb) Stay silent.";
            promptList[4] = "a) Talk to mom about it\nb) Suck it up and head out";
            promptList[5] = "a) How does it look?\n" +
                            "b) How does it smell?\n" +
                            "c) How do you feel?\n" +
                            "d) Continue";
            promptList[6] = "a) Go to the bakery\n" +
                            "b) Head to ceremony square\n" +
                            "c) Go to Jamies house";
            promptList[7] = "a) \"I dont really want to talk about it\"\n" +
                            "b) \"Could I get a sweetroll?\"";     


            descriptiveList[0] = "You are in a quaint little town known by the name of \"Little Rock\"\n" +
                                 "The sky is bright blue with a few poofy clouds drifting along the horizon\n" +
                                 "People are milling about, kids are playing in the streets. Its a beautiful day so its surpise everybody's out."; 
            descriptiveList[1] = "You can smell Joanna's bakery down the street. She always make the best sweet rolls.\n" +
                                 "The air is fresh. The line of flowers leading up to Mom's place fill your nose with a pleasent sweet aroma";
            descriptiveList[2] = "Your heart is racing. Anxious thoughts bounce around your head. Can you do this??";
            descriptiveList[3] = "You examine the iced pastry. It is fluffy and aerated with teeny holes dotting it's smooth surface.\n" +
                                 "It looks delicious";
            string answer = "";                        
            while (!isvalidinput){ //1st while loop
                
            Console.WriteLine("PRESS ENTER TO CONTINUE WHEN THERE IS NO PROMPT");
            Console.ReadLine();
            Console.WriteLine($"You are at {locationList[0]}");
            Console.WriteLine(dialogueList[0]);
            Console.WriteLine(promptList[0]);          
            // if the player presses enter at any time during dialogue sections, it skips everything. this needs to be fixed. 
            answer = Console.ReadLine();
            
            if (answer == "a")
            {    
                // what happens if you pretend to be asleep
                isvalidinput = true;
                Console.WriteLine("\"I know you can hear me, don't make me come drag you out\""); // <------ do this
            }                
            else if (answer == "b")            
            {                        // <------ false
                // what happens if you say "Five more minutes"
                isvalidinput = true;
                Console.WriteLine("\"No way!! You don't have five mintues, you need to eat and get ready!\"");                                    
            }    
            else if (answer == "c") // Full C Line. Needs to end in the same place as A and B lines
            {
                    // what happens if you getcho lazy butt up!
                    isvalidinput = true;    
                    Console.WriteLine("You jolt up in bed, and make your way to the kitchen");
            }
            }
                isvalidinput = false;      // this is here because there is no valid input declared yet. so its automatically false
                while (!isvalidinput && answer != "c"){ // 2nd while loop
                    Console.WriteLine(promptList[1]);
                    answer = Console.ReadLine();
                    if (answer == "a")  {
                        isvalidinput = true;  // this is put here because the correct answer has been determined as a, therefore this is the valid input
                        }
                    }
                    isvalidinput = false;
                    while (!isvalidinput)     // these while statements make sure that the game does not close if given an invalid input               
                        {   Console.WriteLine(dialogueList[1]);
                            Console.WriteLine(promptList[2]);
                            answer = Console.ReadLine();                  
                    if (answer == "a")
                        {
                            isvalidinput = true;                            
                        }
                        }
                    isvalidinput = false;    
                    while (!isvalidinput){
                            Console.WriteLine(dialogueList[2]);
                            Console.WriteLine(promptList[3]);
                            answer = Console.ReadLine();    
                    if (answer == "a")
                        {
                            isvalidinput = true; //                       
                        }                       
                    else if (answer == "b")
                        {
                                isvalidinput = true;      // If you stay silent
                        } }
                    isvalidinput = false;           
                    while (!isvalidinput){
                            Console.WriteLine(dialogueList[3]);
                            Console.WriteLine(promptList[4]);
                            answer = Console.ReadLine();
                    if (answer == "a")
                        {
                            isvalidinput = true;
                            Console.WriteLine(dialogueList[4]);
                            Console.ReadLine();
                            Console.WriteLine(dialogueList[5]);
                            Console.ReadLine();
                            Console.WriteLine(dialogueList[6]);
                            Console.ReadLine();                            
                            Console.WriteLine(dialogueList[7]);
                            Console.ReadLine();
                            Console.Clear();                                   
                        }
                    else if (answer == "b")
                        {
                            isvalidinput = true;
                            Console.WriteLine(dialogueList[6]);
                            Console.ReadLine();
                            Console.WriteLine(dialogueList[7]);
                            Console.ReadLine();
                            Console.Clear();
                        } 
                    }                                    
                while(answer != "d"){
                    Console.WriteLine(locationList[1]);
                    Console.WriteLine(promptList[5]);
                    answer = Console.ReadLine();                                           
                    if (answer == "a")
                    {
                        Console.WriteLine(descriptiveList[0]);                        
                        Console.ReadLine();
                        Console.Clear();                    
                    }
                    else if (answer == "b")
                    {
                        Console.WriteLine(descriptiveList[1]);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (answer == "c")
                    {
                        Console.WriteLine(descriptiveList[2]);
                        Console.ReadLine();
                        Console.Clear();        
                    }
                    }                     
                    if (answer == "d"){
                        Console.WriteLine(locationList[2]);
                        Console.ReadLine();
                        Console.WriteLine(promptList[6]);
                        answer = Console.ReadLine();
                    }
                             
                    if (answer == "a")
                    {                             /* Everything from here down is a little buggy.
                                                     If you press anything other than the inputs listed on the prompts it will close the program */       
                        Console.WriteLine(locationList[3]);
                        Console.ReadLine();
                        Console.WriteLine(dialogueList[8]);
                        Console.ReadLine();
                        Console.WriteLine(promptList[7]);
                        answer = Console.ReadLine();
                        if (answer == "a"){
                        Console.WriteLine(dialogueList[9]);
                        Console.ReadLine();
                        Console.WriteLine(descriptiveList[3]);
                        Console.ReadLine();
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();    
                                        }
                        else if (answer == "b")
                        {
                        Console.WriteLine(dialogueList[10]);
                        Console.ReadLine();
                        Console.WriteLine(descriptiveList[3]);
                        Console.ReadLine();
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();

                        }
                    }                        
                    else if (answer == "b")
                    {
                        Console.WriteLine(locationList[4]);
                        Console.ReadLine();
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                             
                    }
                    else if (answer == "c")
                    {
                        Console.WriteLine(locationList[5]);
                        Console.ReadLine();
                        Console.WriteLine(dialogueList[11]);
                        Console.ReadLine();
                        Console.WriteLine("Thanks for playing!");           
                    }

                       
        }    
    }
}