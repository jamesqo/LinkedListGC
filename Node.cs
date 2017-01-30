namespace Demo
{
    public class Node<T>
    {
        public Node(Node<T> previous, T element)
        {
            Element = element;
            Previous = previous;
        }

        public T Element { get; }

        public Node<T> Previous { get; }
    }
}