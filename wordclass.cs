class Word {

    
    private string randomword;

//makes the word to be used and converts it to a character array.
    public Word(){
        Wordlist wordlist = new Wordlist();
        randomword = wordlist.SelectWord();
        char[] randomchar = randomword.ToCharArray();
        int lengthchar = randomchar.Length;
    }

// uses the created character array to get a length for it.
    public int getcharlength(){
        char[] randomchar = randomword.ToCharArray();
        int lengthchar = randomchar.Length;
        return lengthchar;
    }
// uses the word to create a character array.
    public char[] getchararray(){
        char[] randomchar = randomword.ToCharArray();
        return randomchar;
    }
   
        
}