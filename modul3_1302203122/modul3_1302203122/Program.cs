using modul3_1302203122;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah anew = new KodeBuah();
            KodeBuah.namaBuah buah1 = KodeBuah.namaBuah.Apel;
            Console.WriteLine(buah1 + "  " + anew.getKodeBuah(buah1));

            PosisiKarakterGame posisiKarakter = new PosisiKarakterGame();
            Console.Write("Posisi Sedang:");
            Console.WriteLine(posisiKarakter.currentState);
            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.Write("Posisi Sedang:");
            Console.WriteLine(posisiKarakter.currentState);
            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolS);
            Console.Write("Posisi Sedang:");
            Console.WriteLine(posisiKarakter.currentState);
            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolS);
            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolS);
            Console.Write("Posisi Sedang:");
            Console.WriteLine(posisiKarakter.currentState);
        }
        
    }


}