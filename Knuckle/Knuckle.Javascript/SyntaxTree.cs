namespace Knuckle.Javascript
{
    internal class SyntaxTree
    {
        public Node<Grammer> Root { get; private set; }

        public SyntaxTree(Node<Grammer> root)
        {
            Root = root;
        }

        public void AddChildren(Node<Grammer> child)
        {
            Root.AddChild(child);
        }

        // Need method to identify where to add a child
    }
}
