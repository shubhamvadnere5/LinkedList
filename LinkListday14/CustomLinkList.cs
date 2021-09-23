using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListday14
{
    class CustomLinkList
    {
        //UC2
        /// <summary>
        /// UC2 insert at front
        /// </summary>
        /// <param name="new_data"></param>

        public Node head;
        public void InsertFront(int new_data)
        {
            Node new_Node = new Node(new_data);
            new_Node.next = this.head;
            this.head = new_Node;
            Console.WriteLine("Inserted into list" + new_Node.data);
        }
    }
}
