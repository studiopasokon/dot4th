using dot4thshell;

Console.WriteLine("Welcome to dot4th, a simple Forth interpreter written in C#");
Console.WriteLine();

var running = true;
while (running)
{
    var tokens = InputHandler.ReadTokens(Console.Write, Console.ReadLine);

    foreach (var token in tokens)
    {
        if (token == "bye")
        {
            running = false;
            break;
        }
        
        Console.WriteLine(token);
    }
}