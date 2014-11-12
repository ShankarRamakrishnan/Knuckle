using Knuckle.Javascript;

namespace Knuckle.Javascript
{
    internal class LexicalAnalyzer
    {
        private readonly Node<Grammer> _syntaxTree;

        public LexicalAnalyzer()
        {
            var rootGrammer = new Grammer
                              {
                                  Name="Root"
                              };
            _syntaxTree = new Node<Grammer>(rootGrammer, null);
        }

        public Node<Grammer> Lex(string javascriptCode)
        {
            var token = string.Empty;
            foreach (var c in javascriptCode)
            {
                token = string.Concat(token, c);
                if (token.IsGrammer())
                {
                    CreateGrammerObjectAndAdd2SyntaxTree(token, true);
                    token = string.Empty;
                    continue;
                }
                if (char.IsWhiteSpace(c))
                {
                    CreateGrammerObjectAndAdd2SyntaxTree(token, false);
                }
                else
                {
                    var allSpaces = token.Substring(0, token.Length-1);
                    token = token.Substring(token.Length - 1, token.Length);
                    CreateGrammerObjectAndAdd2SyntaxTree(token, false);
                }

            }
            return _syntaxTree;
        }

        private void CreateGrammerObjectAndAdd2SyntaxTree(string token, bool javascriptKeyword)
        {
            if (string.IsNullOrWhiteSpace(token))
                return;
            var tokenGrammer = new Grammer { Name = token, JavascriptKeyword = javascriptKeyword };
            _syntaxTree.AddChild(new Node<Grammer>(tokenGrammer, null));
        }
    }
}

public static class SomeClass
{
    public static bool IsGrammer(this string token)
    {
        // Check the condition for grammer
        return JsGrammer.Keywords.Contains(token);

    }
}