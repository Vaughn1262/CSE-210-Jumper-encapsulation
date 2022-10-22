class Wordlist {
    List<string> words = new List<string>();
    Random generator = new Random();
    
// Generates a list of words for the user to guess the letters.
    public Wordlist(){
    words.Add("Dog");
    words.Add("cat");
    words.Add("zebra");
    words.Add("monkey");
    words.Add("gorilla");
    }

// Randomly selects one of the words to use for the program.
    public string SelectWord(){
        int randomIndex = generator.Next(words.Count);
        string wordValue = words[randomIndex];
        return wordValue;
    }
    
}