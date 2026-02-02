using System;

class Program
{
    static void Main()
    {
        string message = Console.ReadLine();
        if (message.StartsWith("H3i9AH")) {
            message = message.Substring(6);
            string[] code = message.Split(new string[] {"weather "}, StringSplitOptions.None);
            foreach (string part in code)
            {
                Console.WriteLine(part);
            }
            
        }
        else if (message == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }
        else{
            Console.WriteLine("ok");
            }
         // True
    }
}