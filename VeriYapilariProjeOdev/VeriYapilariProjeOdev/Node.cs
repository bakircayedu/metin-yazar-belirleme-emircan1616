using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
     public class Node
    {
        public string data;
        public Node next;

        public Node(string data)
        {
            this.data = data;
            next=null;
        }

        public static implicit operator Node(string v)
        {
            throw new NotImplementedException();
        }
    }

    
}
