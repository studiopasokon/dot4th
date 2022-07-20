using System.Linq;
using Xunit;

namespace dot4thshell.tests;

public class InputHandlerTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("    ")]
    public void ReadingTokens_WithNullEmptyOrWhitespaceInput_ReturnEmptyArray(string? input)
    {
        var tokens = InputHandler.ReadTokens(s => _ = s, () => input);
        Assert.Empty(tokens);
    }

    [Theory]
    [InlineData("this is input for tokens", 5)]
    [InlineData("an string with, several : strange \" characters.", 8)]
    public void ReadingTokens_WithInput_ReturnCollectionOfTokens(string input, int numberOfExpectedTokens)
    {
        var tokens = InputHandler.ReadTokens(s => _ = s, () => input).ToList();
        Assert.NotEmpty(tokens);
        Assert.Equal(numberOfExpectedTokens, tokens.Count);
    }
}