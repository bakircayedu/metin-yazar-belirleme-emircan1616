using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
    public interface IHashMap
    {
        object ara(string key);

        void add(string key, object value);

        int hashValue(string key);


    }
}
