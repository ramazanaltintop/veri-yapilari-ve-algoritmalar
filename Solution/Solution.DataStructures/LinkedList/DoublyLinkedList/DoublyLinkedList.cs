﻿using System.Collections;

namespace Solution.DataStructures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyLinkedListNode<T>? Head { get; set; }
        public DoublyLinkedListNode<T>? Tail { get; set; }

        private bool isHeadNull => Head is null;

        public DoublyLinkedList()
        {

        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                AddLast(item);
        }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;
            newNode.Prev = null;

            if (Head is null)
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

            if (Tail is null)
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
                throw new ArgumentException("Reference node is not found.");

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
            // Aradığımız referans olmayabilir.
            if (refNode is null)
                throw new ArgumentException("Reference node is not found.");

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

            // En az 2 elemanlıysa
            // Listenin başına ekleme yapılmak isteniyorsa
            if (refNode == Head && Tail is not null)
            {
                newNode.Next = refNode;
                newNode.Prev = null;

                refNode.Prev = newNode;

                Head = newNode;
                return;
            }

            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;

            refNode.Prev.Next = newNode;
            refNode.Prev = newNode;
        }

        public void AddBefore(DoublyLinkedListNode<T> refNode, T value)
        {
            // Aradığımız referans olmayabilir. Bu istisnayı kontrol ettik.
            if (refNode is null)
                throw new ArgumentException("Reference node is not found.");

            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;
            newNode.Prev = null;

            // Listede tek bir eleman varsa durumunu kontrol edelim.
            if (refNode == Head && refNode == Tail)
            {
                newNode.Next = refNode;
                newNode.Prev = null;

                refNode.Prev = newNode;
                refNode.Next = null;

                Head = newNode;
                return;
            }

            // En başa eleman ekleyeceksek
            if (refNode == Head && Tail is not null)
            {
                newNode.Next = refNode;
                newNode.Prev = null;

                refNode.Prev = newNode;

                Head = newNode;
                return;
            }

            // Aksi halde ekleyeceğimiz eleman araya ekleme olacaktır.
            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;

            refNode.Prev.Next = newNode;
            refNode.Prev = newNode;
        }

        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current is not null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new ArgumentException("No node found to remove.");
            var firstValue = Head.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            return firstValue;
        }
    }
}
