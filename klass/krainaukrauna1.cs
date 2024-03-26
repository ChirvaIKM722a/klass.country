using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krainaukrauna1
{
    public class krainaukrauna1
    {
        private string nazva; // названіє
        private string GandY; // гос устройство
        private long nasel; // насєленіє
        private string val; // валюта
        private string stol; // столиця
        private string language; // язік

        public krainaukrauna1(string nazva, string gandY, long nasel, string val, string stol, string language)
        {
            this.nazva = nazva;
            GandY = gandY;
            this.nasel = nasel;
            this.val = val;
            this.stol = stol;
            this.language = language;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nazva: {nazva}");
            Console.WriteLine($"Gos Ustriq: {GandY}");
            Console.WriteLine($"Naselennya: {nasel}");
            Console.WriteLine($"Valuta: {val}");
            Console.WriteLine($"Solucya: {stol}");
            Console.WriteLine($"Mova: {language}");
        }

        public void Updatenasel(long nasel)
        {
            this.nasel = nasel;
            Console.WriteLine("Naselenie izmenilos");
        }

        public bool ProverkaNaselenia()
        {
            return nasel < 290000000;
        }

    }
}
