public class Token
{
    public string Type { get; set; }
    public string Lexeme { get; set; }

    public Token(string type, string lexeme)
    {
        Type = type;
        Lexeme = lexeme;
    }
}