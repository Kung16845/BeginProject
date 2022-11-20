public class Program
{
    public static void Main(string[] args)
    {
        char vars; 
        int i = 0;   
        string bools = "true"; 
        Queue<char> size = new Queue<char>();
        size.Push('L'); 
        size.Push('M'); 
        size.Push('S'); 
        Queue<char> number = new Queue<char>();
        do
        {
            vars = Inputcharacter();    
            if (vars == size.Get(0)) 
            {                                      
               number.Push('1');                                                  
            } 
            else if (vars == size.Get(1))
            {
                number.Push('2');
            } 
            else if (vars == size.Get(2))
            {
                number.Push('3');
            }            
            else 
            {
                 bools = "false"; 
            }                             
        }
        while(bools == "true");  
        for (i = 0; i < number.GetLength();i++)
        {
            if(number.Get(i) == '1')
            {
                number.Push('2');
                number.Push('2');
            }
            else if(number.Get(i) == '2')
            {
                number.Push('3');
                number.Push('3');
                number.Push('3');
            }
        } 
        for (i = 0;i < number.GetLength();i++)
        {
            Console.Write(number.Get(i));
        }    
    }
    static char Inputcharacter()
    {
        return char.Parse(Console.ReadLine());
    }
}
