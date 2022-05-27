using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
    public class Liste : Iliste
    {
        public Node head;
        int count = 0;
        
        public Liste()
        {
            this.head = null;
            
        }

        public bool BosMu()
        {
            return count==0 ? true : false;
        }

        
        public void ekle (string deger)
        {
            Node temp = this.head;
            if (BosMu())
            {
                head = deger;
            }

            else
            {
                head = new Node(deger)
                {
                    next = temp
                };
            }
            count++;
        }

        public object Peek()
        {
            if (BosMu())
            {
                return 0;
            }
            return head.data;
        }

        

        public override void bosMu()
        {
            throw new NotImplementedException();
        }

        public override void peek()
        {
            throw new NotImplementedException();
        }

        public override void sil()
        {
            throw new NotImplementedException();
        }

        public override void ekle()
        {
            throw new NotImplementedException();
        }
    }
}
