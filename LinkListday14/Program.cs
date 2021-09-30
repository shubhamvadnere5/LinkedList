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
            //UC3 Append
            customLinkList.Append(56);
            customLinkList.Append(30);
            customLinkList.Append(70);
            Console.ReadLine();
        }
    }
}
