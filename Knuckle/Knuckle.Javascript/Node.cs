using System.Collections.Generic;

namespace Knuckle.Javascript
{
    public class Node<T>
    {
        public T Data {get; private set; }
        public List<Node<T>> Children { get; private set; }

        public Node(T data, List<Node<T>> children)
        {
            Data = data;
            if (children != null && children.Count > 0)
                Children = children;
            else
                Children = new List<Node<T>>();
        }

        public void AddChild(Node<T> child)
        {
            Children.Add(child);
        }
    }
}