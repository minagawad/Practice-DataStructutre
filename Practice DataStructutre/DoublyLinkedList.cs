using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataStructutre
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private int size = 0;
        private Node<T> head = null;
        private Node<T> tail = null;

        public DoublyLinkedList()
        {

        }

        public void Clear()
        {
            Node<T> trav = head;
            while (trav != null)
            {
                Node<T> next = trav.next;
                trav.next = trav.prev = null;
                trav.data = default;
                trav = next;


            }
            head = tail = trav = null;
            size = 0;
        }

        public int Size() => size;
        public bool IsEmpty() => Size() == 0;

        public void Add(T item)
        {
            AddLast(item);
        }

        private void AddLast(T? item)
        {

            if (IsEmpty())
            {
                head = tail = new Node<T>(item, null, null);
            }
            else
            {
                tail.next = new Node<T>(item, tail, null);
                tail = tail.next;
            }
            size++;


        }

        public T PeekFirst()
        {

            if (IsEmpty()) throw new Exception("Empty List");
            else
                return head.data;
        }

        public T PeekLast()
        {

            if (IsEmpty()) throw new Exception("Empty List");
            else
                return tail.data;
        }

        public T RemoveFirst()
        {
            if (IsEmpty()) throw new Exception("Empty List");
            T data = head.data;
            head = head.next;
            --size;

            if (IsEmpty()) tail = null;
            else
                head.prev = null;

            return data;


        }
        public T RemoveLast()
        {
            if (IsEmpty()) throw new Exception("Empty List");
            T data = tail.data;
            tail = tail.prev;
            --size;

            if (IsEmpty()) head = null;
            else
                tail.next = null;

            return data;


        }
        private void AddFirst(T? item)
        {

            if (IsEmpty())
                head = tail = new Node<T>(item, null, null);
            else
            {
                head.prev = new Node<T>(item, null, head);
                head = head.prev;
            }
            size++;

        }
        private T Remove(Node<T> node)
        {

            if(node.prev==null) return RemoveFirst();
            if(node.next==null) return RemoveLast();
            node.prev.next = node.next;
            node.next.prev = node.prev;

            T data = node.data;
            node = node.next = node.prev = null;
            --size;
            return data;
        }

        public T RemoveAt(int index)
        {
            if(index < 0|| index>=size)
            {
                throw new Exception("indexnot valid");

            }

            int i;
            Node<T> trav;
            if(index<size/2)

            {
                trav = head;
                for (i = 0;i != index; i++)
                {
                    trav = trav.next;


                }
            }
            else
            {
                trav = tail;
                for (i = size-1;i!=index; i--)
                {
                    trav = trav.prev;

                }
            }

            return Remove(trav);

        }


        public bool Remove(object obj)
        {
            Node<T> trav;
            if(obj==null)
            {
                for(trav=head; trav!=null; trav=trav.next)
                {
                    if(trav.data==null)
                    {
                        Remove(trav);
                        return true;
                    }

                }
            
            }
            else
            {
                for (trav = head; trav != null; trav = trav.next)
                {
                    if (obj.Equals(trav.data))
                    {
                        Remove(trav);
                        return true;
                    }

                }

            }

            return false;
        }


        public int IndexOf(object obj)
        {
            int index = 0;
            Node<T> trav;
            if (obj == null)
            {
                for (trav = head; trav != null; trav = trav.next, index++)
                {
                    if (trav.data == null)
                    {
                        return index;
                    }

                }

            }
            else
            {
                for (trav = head; trav != null; trav = trav.next, index++)
                {
                    if (obj.Equals(trav.data))
                    {
                        return index;
                    }

                }

            }

            return -1;
        }

        public bool Cotains(object ob)=> IndexOf(ob)!=-1;
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        private class Node<T>

        {
            public T? data;
            public Node<T>? next, prev;
            public Node(T? data, Node<T>? next, Node<T>? prev)
            {
                this.data = data;
                this.next = next;
                this.prev = prev;
            }
            public override string? ToString()
            {
                return data != null ? data.ToString() : "";
            }
        }
    }
}
