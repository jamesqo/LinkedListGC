namespace Demo
{
    public class SingleLinkedList<T>
    {
        private readonly Node<T> _node;

        private readonly int _count;

        public static SingleLinkedList<T> Empty { get; } = new SingleLinkedList<T>();

        private SingleLinkedList() { }

        private SingleLinkedList(SingleLinkedList<T> previous, T element)
        {
            _node = new Node<T>(previous._node, element);
            _count = previous._count + 1;
        }

        public int Count => _count;

        public SingleLinkedList<T> Add(T element) => new SingleLinkedList<T>(this, element);
    }
}