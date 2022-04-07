namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Title / Introduction

            Console.Title = "DUNGEON OF DOOM";

            Console.WriteLine(@"
 a88888b.            dP            dP                     dP
d8'   `88            88            88                     88   
88        .d8888b. d8888P .d8888b. 88 dP    dP .d8888b. d8888P
88        88'  `88   88   88'  `88 88 88    88 Y8ooooo.   88
Y8.   .88 88.  .88   88   88.  .88 88 88.  .88       88   88
 Y88888P' `88888P8   dP   `88888P8 dP `8888P88 `88888P'   dP
ooooooooooooooooooooooooooooooooooooooo~~~~.88~oooooooooooooooo
                                       d8888P                  ");
            Console.WriteLine("\n<~=~=~=~=~=~=~=~=~=~=~=~=~=~>\n" +
                "\n<Press <Any Key> to continue.");
            Console.ReadKey();
            Console.Clear();

            #endregion

            //TODO: Create a Player object to track info/stats

            #region Main Game Loop

            //Bool (counter) for the loop
            bool exit = false;

            //Create the main loop
            do
            {                

                //TODO Select a Monster (at random) for the player to encounter

                #region Gameplay Menu Loop

                //Bool (counter) for the gameplay loop
                bool reload = false;

                //Create the gameplay loop


                //Create the gameplay menu
                #region Gameplay Menu

                //Prompt the user
                Console.WriteLine(@"
 a88888b.            dP            dP                     dP
d8'   `88            88            88                     88   
88        .d8888b. d8888P .d8888b. 88 dP    dP .d8888b. d8888P
88        88'  `88   88   88'  `88 88 88    88 Y8ooooo.   88
Y8.   .88 88.  .88   88   88.  .88 88 88.  .88       88   88
 Y88888P' `88888P8   dP   `88888P8 dP `8888P88 `88888P'   dP
ooooooooooooooooooooooooooooooooooooooo~~~~.88~oooooooooooooooo
                                       d8888P                  ");
                Console.Write("\n<~=~=~=~=~=~=~=~=~>\n" +
                        "S) Start New Game\n" +
                        "C) Constinue Game\n" +                        
                        "X) Exit\n");


                    //Capture the user's menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key; //Executes on key press

                    //Clear the console
                    Console.Clear();

                    //Use branching logic to execute code based on user's menu selection
                    switch (userChoice)
                    {

                        case ConsoleKey.S:
                            Console.WriteLine(" * So it begins * >:3 ");
                            //TODO Combat
                            break;

                        case ConsoleKey.C:
                            Console.WriteLine("* havn't I seen you somewhere before * ;3 ");
                            //TODO Run away
                            break;                       

                        //Allows the user to exit if they hit X OR E
                        case ConsoleKey.X:                        
                            Console.WriteLine(" * Scaredy cat! * >:3 ");

                            //Flip the bool to break from the loop
                            exit = true;
                            break;

                        default:

                            Console.WriteLine(" * tilts head in confusion * /:3 Please Enter Proper Response. ");

                            break;
                    }

                    #endregion


                 //Condition - while exit AND reload are NOT true, keep looping

                #endregion


            } while (!exit); //Condition for loop - While exit is NOT true, keep looping

            #endregion

        }//end Main()

        #region GetRoom()

        

        #endregion

    }//end class

}//end Namespace
