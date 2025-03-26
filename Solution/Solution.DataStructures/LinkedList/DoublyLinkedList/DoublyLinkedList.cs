namespace Solution.DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;
            newNode.Prev = null;

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            Head.Prev = newNode;
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;
            newNode.Prev = null;

            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }

        public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode is null)
                throw new ArgumentNullException();

            // listede tek bir eleman varsa
            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev = refNode;
                newNode.Next = null;

                Tail = newNode;
                return;
            }

            // araya eleman ekliyoruz demektir
            if (refNode != Tail)
            {
                newNode.Prev = refNode;
                newNode.Next = refNode.Next;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            // son eleman; referans düğümümüz olursa
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddAfter(DoublyLinkedListNode<T> refNode, T value)
        {
            if (refNode is null)
                throw new ArgumentNullException();

            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;
            newNode.Prev = null;

            // Listede tek bir eleman bulunuyorsa ihtimalini değerlendiriyoruz.
            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Next = null;
                newNode.Prev = refNode;

                Tail = newNode;
                return;
            }

            // Listede araya eleman eklenmek isteniyorsa Tail ile refNode eşit olamaz.
            if (refNode != Tail)
            {
                newNode.Next = refNode.Next;
                newNode.Prev = refNode;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            // Listenin sonunu gösteren Tail; eğer bizim referans düğümümüz olursa listenin sonuna eleman eklemek istiyoruz demektir.
            else
            {
                refNode.Next = newNode;
                newNode.Prev = refNode;
                Tail = newNode;
            }
        }

        public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode is null)
                throw new ArgumentNullException();

            // Listede sadece 1 eleman bulunuyorsa
            if (refNode == Head && refNode == Tail)
            {
                refNode.Prev = newNode;
                refNode.Next = null;

                newNode.Next = refNode;
                newNode.Prev = null;

                Head = newNode;
                return;
            }

            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;

            refNode.Prev.Next = newNode;
            refNode.Prev = newNode;
        }
    }
}
