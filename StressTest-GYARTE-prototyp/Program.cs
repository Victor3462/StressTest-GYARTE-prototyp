using System;

Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Blue;
toolbox.WriteCentered(" ██████  ██    ██ ██ ███████ ");
toolbox.WriteCentered("██    ██ ██    ██ ██    ███  ");
toolbox.WriteCentered("██    ██ ██    ██ ██   ███   ");
toolbox.WriteCentered("██ ▄▄ ██ ██    ██ ██  ███    ");
toolbox.WriteCentered(" ██████   ██████  ██ ███████ ");
toolbox.WriteCentered("    ▀▀                       ");
Console.ForegroundColor = ConsoleColor.Red;
toolbox.WriteCentered("");
toolbox.WriteCentered("Press Enter to start");

string currentQuestion = "start";
int points = 0;

Console.ReadLine();
Console.Clear();

currentQuestion = "q1";

if (currentQuestion == "q1")
{
toolbox.WriteCentered(" ");
toolbox.WriteCentered("Question 1:");
toolbox.WriteCentered("What is 14 + 19?");

string answer1 = toolbox.answer();

if (answer1 == "33"){
    points++;
    currentQuestion = "q2";
    Console.Clear();
}
else if (answer1 != "33"){
    currentQuestion = "q2";
    Console.Clear();
}
}

if (currentQuestion == "q2")
{
toolbox.WriteCentered(" ");
toolbox.WriteCentered("Question 2:");
toolbox.WriteCentered("What is 7 x 8?");

string answer1 = toolbox.answer();

if (answer1 == "56"){
    points++;
    currentQuestion = "q3";
    Console.Clear();
}
else if (answer1 != "56"){
    currentQuestion = "q3";
    Console.Clear();
}
}

if (currentQuestion == "q3")
{
toolbox.WriteCentered(" ");
toolbox.WriteCentered("Question 3:");
toolbox.WriteCentered("What is 24 - 14?");

string answer1 = toolbox.answer();

if (answer1 == "10"){
    points++;
    currentQuestion = "q4";
    Console.Clear();
}
else if (answer1 != "10"){
    currentQuestion = "q4";
    Console.Clear();
}
}

if (currentQuestion == "q4")
{
toolbox.WriteCentered(" ");
toolbox.WriteCentered("Question 4:");
toolbox.WriteCentered("What is 20 / 4?");

string answer1 = toolbox.answer();

if (answer1 == "5"){
    points++;
    currentQuestion = "q5";
    Console.Clear();
}
else if (answer1 != "5"){
    currentQuestion = "q5";
    Console.Clear();
}
}

if (currentQuestion == "q5")
{
toolbox.WriteCentered(" ");
toolbox.WriteCentered("Question 5:");
toolbox.WriteCentered("What is 16 + 42?");

string answer1 = toolbox.answer();

if (answer1 == "58"){
    points++;
    currentQuestion = "q6";
    Console.Clear();
}
else if (answer1 != "58"){
    currentQuestion = "q6";
    Console.Clear();
}
}





     

toolbox.WriteCentered("The Quiz is finally over!");
toolbox.WriteCentered($"You got {points} points! (max 10 points)");
Console.ReadLine();

toolbox.WriteCentered("Thanks for Playing!");
Console.ReadLine();