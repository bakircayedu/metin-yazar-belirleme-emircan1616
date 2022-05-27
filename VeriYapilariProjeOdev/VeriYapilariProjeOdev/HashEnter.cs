using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
    public class HashEnter
    {
        public HashEnter next { get; set; }
        public string key { get; set; }
        public object deger { get; set; }
        
        public HashEnter(string key, object value)
        {
            this.key = key;
            this.deger = value;
            this.next = null;
        }
    }
}
