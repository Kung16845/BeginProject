public class Program
{
    public static void Main(string[] args)
    {
        char vars;  
        string start = "stay01";
        int number = 0;    
        string bools = "false";
        CircularLinkedList<char> character = new CircularLinkedList<char>();
        character.Add('J'); 
        character.Add('G'); 
        character.Add('O'); 
        character.Add('R'); 
        CircularLinkedList<char> Inputchar = new CircularLinkedList<char>();
        do
        {
            vars = Inputcharacter();    
            if (vars == character.Get(0) || vars == character.Get(1) 
            || vars == character.Get(2) || vars == character.Get(3))
               {
                    Inputchar.Add(vars);
                    bools = "true";  
                    if (Inputchar.Get(number) == 'R' && start == "stay01")
                    {
                        Console.WriteLine("Invalid pattern.");
                        vars = Inputcharacter();
                        Inputchar.Add(vars);
                        Inputchar.Remove(number);
                    } 
                    else if (Inputchar.Get(number-1) == 'R' && vars == Inputchar.Get(number-2) && Inputchar.GetLength() >= 3)
                    {
                        Console.WriteLine("Invalid pattern.");
                        Inputchar.Remove(number);
                    }
                    else if (Inputchar.Get(number-1) == 'R' && vars == 'R' && Inputchar.GetLength() >= 3)
                    {
                        Console.WriteLine("Invalid pattern.");
                        Inputchar.Remove(number);
                    }
                    if ((Inputchar.Get(number-1) == 'G' && vars == 'G' && Inputchar.Get(number-2) == 'G') 
                     && Inputchar.GetLength() >= 4 && Inputchar.Get(number-3) == 'G')
                    {
                       Console.WriteLine("Invalid pattern."); 
                       Inputchar.Remove(number);
                    } 
                    else if ((Inputchar.Get(number+1) == 'G' && vars == 'G' && Inputchar.Get(number+2) == 'G') 
                     && Inputchar.GetLength() >= 4 && Inputchar.Get(number+3) == 'G')
                    {
                       Console.WriteLine("Invalid pattern."); 
                       Inputchar.Remove(number);
                    }   
                    start = "stay00";                
                    number++;                                                            
               }             
            else 
            {
                 bools = "false"; 
            }          
                     
        }
        while(bools == "true");
        for (int i = 0;i < Inputchar.GetLength();i++)
        {
            Console.Write(Inputchar.Get(i));
        }
    }
    static char Inputcharacter()
    {
        return char.Parse(Console.ReadLine());
    }
}
