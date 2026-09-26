using STUDY.MathGame;
using static STUDY.MathGame.Enums;

Difficulty? difficulty = null;

for(int i=0;i<args.Length;i++)
{
    switch(args[i].ToLower())
    {
        case "--difficulty":
        case "-d":
            if (i + 1 < args.Length && Enum.TryParse<Difficulty>(args[i + 1], true, out var diff))
                difficulty = diff;
            else Console.WriteLine($"Invalid value for --difficulty: only allowed Easy, Medium and Hard. ");
            i++;
            break;
    }
}
UserInterface user = new UserInterface(difficulty);
user.MainMenu();




