using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
    public class Hash:IHashMap
    {
        public HashEnter[] table;
        public int size { get; set; }
        public Hash(int tableSize)
        {
            size = tableSize;
            table = new HashEnter[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                table[i] = null;
            }
        }

        public object ara(string key)
        {
            int hash = HashValue(key) % size;
            if (table[hash] != null)
            {
                HashEnter node = table[hash];
                while (node.next != null)
                {
                    if (node.key == key)
                    {
                        break;
                    }
                    node = node.next;
                }
                return node.deger;
            }
            else
                return null;

        }

        private int HashValue(string key)
        {
            int HashValue = 0;
            for (int i = 0; i < key.Length; i++)
            {
                HashValue += key[i];
            }
            return HashValue;
        }

        public void add(string key, object value)
        {
            int hash = HashValue(key) % size;
            if (table[hash] != null)
            {
                HashEnter node = table[hash];
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = new HashEnter(key, value);
            }
            else
                table[hash] = new HashEnter(key, value);

        }

        public int hashValue(string key)
        {
            throw new NotImplementedException();
        }
    }
}
