using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace OJT_KGB_NO1_DoublyLinkedList
{
    /// <summary>
    /// LinkedList class
    /// </summary>
    public class LinkedList : IEnumerable<Node>    
    {
        /// <summary> Node의 headNode</summary>
        private Node head;
        /// <summary> Node의 tailNode</summary>
        private Node tail;
        /// <summary> headNode For Reverse</summary>
        private Node headForReverse;
        
        /// <summary>
        /// Node의 총 Length 
        /// </summary>
        public int Length { get; private set; }
        /// <summary>
        /// 데이터 set 
        /// </summary>
        /// <returns> 호출자에게 yield 리턴 </returns>
        public IEnumerator<Node> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return GetEnumerator();
        }
        /// <summary>
        /// tail이 null 일시 current 의 이전 노드를 set 한다
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetEnumeratorReserse()
        {
            Node current = tail;
            while(current != null)
            {
                yield return current;
                current = current.Previous;
            }
        }
        /// <summary>
        /// Add data into a doubly LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void Add(string data)
        {
            Node newNode = new Node(data);
            if(tail == null)
            {
                head = newNode;
                headForReverse = newNode;
            }
            else
            { // 두 노드 사이 연결 Previous And Next
                newNode.Previous = tail;
                tail.Next = newNode;
            }
            // set new tail
            tail = newNode;
            Length++;
        }
        /// <summary>
        /// Add first data into a doubly LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddFirst(string data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            if (head == null)
            {
                tail = newNode; // set Tail
            }
            else
            {
                head.Previous = newNode;
                headForReverse = newNode;
            }

            head = newNode; // set Head
            headForReverse = newNode; 
            Length++;
        }

        /// <summary>
        /// Find Next Node
        /// </summary>
        /// <param name="value"></param>
        /// <returns>현재 노드</returns>
        public Node NextFind(string value)
        {
            Node current;
            current = head;
            while( current != null)
            {
                if(current.Data == value)
                {
                    head = current.Next;
                    tail = current;
                    return current;
                }
                current = current.Previous;
               
            }
            return null;
        }

        /// <summary>
        /// Find Previous Node
        /// </summary>
        /// <param name="value"></param>
        /// <returns>현재노드</returns>
        public Node PreFind(string value)
        {
            Node current; 
            current = tail;
 
            while (current != null)
            {
                if (current.Next.Data == value)
                {
                    tail = current.Previous;
                    return current;
                }
                return current;
            }
            return null;
        }

        /// <summary>
        /// Reverse the order of Node in LinkedList
        /// </summary>
        /// <returns>반대로 정렬된 이름 string array</returns>
        public string [] Reverse()
        { 
            Node temp = null;
            Node current = headForReverse;

            var result = new string[Length];
            int i = Length - 1;
            while (current != null)
            {
                result[i] = current.Data;
                temp = current.Previous;
                current.Previous = current.Next;
                current.Next = temp;
                current = current.Previous;
                i--;
            }
            
            if (temp != null)
                headForReverse = temp.Previous;
            return result;
        }

        /*
        public bool Contains(string value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Node FindLast(string value)
        {
            Node current = tail;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return current;
                }
                current = current.Previous;
            }
            return null;
        }
        */
    }
}