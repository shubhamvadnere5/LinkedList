using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListday14
{
    class CustomLinkList
    {
        
        
        /// <summary>
        /// UC3 Append
        /// </summary>
        /// <param name="new_data"></param>

        public Node head;
        public void InsertLast(int new_data) //method for inserting element at Last in list
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
                Console.WriteLine("inserted Last into list " + new_node.data);

        }
        public Node GetLastNode() //method for getting last node
        {
            Node temp = this.head;
            while (temp.next != null) 
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Append(int new_data) //creating method for appending elemetns at last in list
        {
            InsertLast(new_data);
            
        }

    }
}
