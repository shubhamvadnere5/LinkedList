using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListday14
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomLinkList customLinkList = new CustomLinkList();
            //UC5 deleting 1st element

            customLinkList.InsertLast(56);
            customLinkList.InsertLast(30);
            customLinkList.InsertLast(70);
            customLinkList.Display();
            Console.WriteLine("Deleted node is:" + customLinkList.DeleteFirstNode());
            customLinkList.Display();
            Console.ReadLine();
        }
    }
}
