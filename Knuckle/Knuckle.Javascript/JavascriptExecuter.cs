namespace Knuckle.Javascript
{
    public static class JavascriptExecuter
    {
        public static Node<Grammer> Execute(string code)
        {
            var lexer = new LexicalAnalyzer();
            return lexer.Lex(code);
        }
    }
}
