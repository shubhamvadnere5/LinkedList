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
            //UC2 insert front
            customLinkList.InsertFront(70);
            customLinkList.InsertFront(30);
            customLinkList.InsertFront(56);
            Console.ReadLine();
        }
    }
}
