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
            //UC1 insertLast
            customLinkList.InsertLast(56);
            customLinkList.InsertLast(30);
            customLinkList.InsertLast(70);
            Console.ReadLine();
        }
    }
}
