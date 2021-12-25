namespace OJT_KGB_NO1_DoublyLinkedList
{
    /// <summary>
    /// Node 객체 
    /// </summary>
    public class Node
    {
        /// <summary> Node 의 Data </summary>
        private string _data;
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
        
        /// <summary> Node의 Next(Node) </summary>
        private Node _next;
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }

        /// <summary> Node의 Previous(Node) </summary>
        private Node _previous;
        public Node Previous
        {
            get { return _previous; }
            set { _previous = value; }
        }

        /// <summary>
        /// Node 생성자
        /// </summary>
        /// <param name="data"></param>
        public Node(string data)
        {
            Data = data;
        }

    }
}
