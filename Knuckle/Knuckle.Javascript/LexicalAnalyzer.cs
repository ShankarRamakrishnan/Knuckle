namespace Knuckle.Javascript
{
    internal class LexicalAnalyzer
    {
        private readonly Node<Grammer> _syntaxTree;

        public LexicalAnalyzer()
        {
            var rootGrammer = new Grammer
                              {
                                  Keyword="Root"
                              };
            _syntaxTree = new Node<Grammer>(rootGrammer, null);
        }

        public Node<Grammer> Lex(string javascriptCode)
        {
            var token = string.Empty;
            foreach (var c in javascriptCode)
            {
                //if subsequent charters are part of the same
                if (char.IsWhiteSpace(c) && token != string.Empty)
                {
                    var tokenGrammer = new Grammer
                                       {
                                           Keyword = token
                                       };

                    var spaceTokenGrammer = new Grammer
                    {
                        Keyword = " "
                    };
                    var newNode = new Node<Grammer>(tokenGrammer, null);
                    _syntaxTree.AddChild(newNode);
                    newNode = new Node<Grammer>(spaceTokenGrammer, null);
                    _syntaxTree.AddChild(newNode);
                    token = string.Empty;
                }
                else
                    token = string.Concat(token, c);
            }
            return _syntaxTree;
        }
    }
}
