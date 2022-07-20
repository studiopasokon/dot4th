namespace dot4thshell;

/// <summary>
/// Contains several functions processing input from whatever source.
/// </summary>
internal static class InputHandler
{
    /// <summary>
    /// Reads an input string and converts it into tokens.
    /// </summary>
    /// <param name="writePrompt">Function that writes a string to a device of some sorts (most likely the console).</param>
    /// <param name="readInput">Function that returns a string.</param>
    /// <returns>List of tokens found in the input. Can be empty.</returns>
    public static IEnumerable<string> ReadTokens(Action<string?> writePrompt, Func<string?> readInput)
    {
        writePrompt("");
        writePrompt(">>> ");
        var inputLine = readInput();
        
        var tokens = inputLine?.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            ?? Array.Empty<string>();

        return tokens;
    }
}