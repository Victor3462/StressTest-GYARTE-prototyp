using System;

public class toolbox{ 

   public static void WriteCentered(string text)
{
    int a = Console.WindowWidth / 2;

    a -= text.Length / 2;

    for (int i = 0; i < a; i++)
    {
        Console.Write(" ");
    }
    Console.WriteLine(text);
}

public static string answer(){

string svar = "";

while (svar == ""){
    WriteCentered(" ");
    WriteCentered("Write your guess:");
    svar = Console.ReadLine().ToLower();
}

return svar;

}

}