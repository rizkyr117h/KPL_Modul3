using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302203122
{
    internal class KodeBuah
    {
        public enum namaBuah { Apel , Aprikot, Alpukat , Pisang , Paprika , Blackberry , Ceri , Kelapa , Jagung , Kurma , Durian , Anggur , Melon , Semangka }

        public string getKodeBuah(namaBuah buah)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

            return kodeBuah[(int)buah];
        }
    }
}