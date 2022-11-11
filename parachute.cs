class Parachute
{
    List<string> parachute_man = new List<string>();
    public int length_parachute_man = 7;
    // Creates a class object called a parachute that is an integer to be used to represent a parachute.
    public Parachute()
    {

        parachute_man.Add(" ----");
        parachute_man.Add(@"/    \");
        parachute_man.Add(" ----");
        parachute_man.Add(@"\    /");
        parachute_man.Add(@" \  / ");
        parachute_man.Add("  0  ");
        parachute_man.Add(@" /|\  ");
        parachute_man.Add(@" / \  ");
    }

    public void print()
    {
        for (int i = 0; i <= length_parachute_man; i++)
        {
            Console.WriteLine(parachute_man[i]);
        }
    }

    public void removeTop(){
        parachute_man.RemoveAt(0);
        length_parachute_man = length_parachute_man - 1;
    }

    public bool Isdead(){
        if (parachute_man[0] == "  0  "){
            return true;
        }
        else
            return false;

    }
    
        
}