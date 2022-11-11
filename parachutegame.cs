class game{
    public void play(){
        bool game_over = false;
        int number = 5;
        Word letterlist = new Word();
        string blank = "_";
        char blank_char = char.Parse(blank);
        int arraylength = letterlist.getcharlength() - 1;
        char[] userWord = new char[arraylength + 1];
        for (int i = 0; i<= arraylength; i++)
            userWord[i] =  blank_char;
    
        Parachute parachute_man = new Parachute();

//Keeps the game going as long as it is supposed to go.
        while (game_over == false){
            //gets the users guess for a letter and converts it to a character
            Console.WriteLine("What is your guess?(a-z) ");
            string guess = Console.ReadLine();
            char guesschar = char.Parse(guess);
    
            //compares the character array to the guess to see if it is in the array.
            bool correctGuess = false;
            char[] letterchararray = letterlist.getchararray();
            for (int i = 0; i <= arraylength; i++){
                char chosenchar = letterchararray[i];
                if (chosenchar == guesschar){
                    userWord[i] = guesschar;
                    correctGuess = true;
            
                }
       

            }
            // displays the correct letters the user has guessed.
            Console.WriteLine(userWord);
    
            // subtracts from the parachute if the guess is not in the word.
            if (correctGuess == false){
                number = number - 1;
                parachute_man.removeTop();
        
            }
    
            parachute_man.print();
   

            // Determines if the user has guessed all the letters in the word.
            if (letterchararray.SequenceEqual(userWord)){
                game_over = true;
                Console.WriteLine("You win");
        
            }

            // If the user has no more parachute then the you lose message is displayed.
            if (parachute_man.Isdead()){
                game_over = true;
                Console.WriteLine("You lose");
            }

        }
//gives a nice message indicating the game is over.
        Console.WriteLine("Thanks for playing");
            } 
}