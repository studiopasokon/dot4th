Console.WriteLine("Welcome to dot4th, a simple Forth interpreter");
Console.WriteLine();

var running = true;
while (running)
{
    Console.Write(">>> ");
    var inputLine = Console.ReadLine();
    
    // TODO: replace this by a real processing of the Forth word 'bye'.
    if (inputLine is "bye")
        running = false;

    // Process the input.
    var tokens = inputLine?.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    if (tokens is not null)
        foreach (var token in tokens)
        {
            Console.WriteLine(token);
        }
    
    Console.WriteLine();
}