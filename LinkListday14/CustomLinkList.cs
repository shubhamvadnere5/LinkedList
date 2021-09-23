using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListday14
{
    class CustomLinkList
    {
        public Node head;
        ///</summary>
        ///UC1 insert at last
        ///</summary>
        ///<param  name= "New data" ></param>
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list:" + new_node.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
