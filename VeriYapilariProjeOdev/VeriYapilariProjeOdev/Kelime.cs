using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
    public class Kelime
    {
        private string kelime { get; set; }
        private int kullanimSayisi { get; set; }
        public Kelime(string kelime, int kullanimSayisi)
        {
            this.kelime = kelime;
            this.kullanimSayisi = kullanimSayisi;
        }
    }
}
