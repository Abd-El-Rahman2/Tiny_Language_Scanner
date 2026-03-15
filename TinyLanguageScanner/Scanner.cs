using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scanner
{
    static string[] keywords =
    {
        "int","float","string","read","write",
        "repeat","until","if","elseif",
        "else","then","return","endl"
    };

    public static List<Token> Scan(string code)
    {
        List<Token> tokens = new List<Token>();

        string pattern =
        @"(/\*.*?\*/)|("".*?"")|(:=)|(\|\|)|(&&)|(<>)|[+\-*/=<>]|[(),;{}]|[0-9]+(\.[0-9]+)?|[A-Za-z][A-Za-z0-9]*";

        MatchCollection matches = Regex.Matches(code, pattern);

        foreach (Match m in matches)
        {
            string value = m.Value;

            if (Regex.IsMatch(value, @"^[0-9]+(\.[0-9]+)?$"))
                tokens.Add(new Token("NUMBER", value));

            else if (Regex.IsMatch(value, "^\".*\"$"))
                tokens.Add(new Token("STRING", value));

            else if (System.Array.Exists(keywords, k => k == value))
                tokens.Add(new Token("KEYWORD", value));

            else if (Regex.IsMatch(value, @"^[A-Za-z][A-Za-z0-9]*$"))
                tokens.Add(new Token("IDENTIFIER", value));

            else if (value == ":=")
                tokens.Add(new Token("ASSIGN_OP", value));

            else if (Regex.IsMatch(value, @"[+\-*/]"))
                tokens.Add(new Token("ARITH_OP", value));

            else if (Regex.IsMatch(value, @"(<|>|=|<>)"))
                tokens.Add(new Token("COND_OP", value));

            else if (value == "&&" || value == "||")
                tokens.Add(new Token("BOOL_OP", value));

            else
                tokens.Add(new Token("SYMBOL", value));
        }

        return tokens;
    }
}