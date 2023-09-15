using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zad2_1
{
    internal class Program
    {
        /*1. Definirajte klasu Biljka, te definirajte od nje izvedenu klasu Stablo sa sljedećim članicama:
• varijabla tipa bool opadajuListovi
• svojstvo OpadajuListovi
• konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli
opadajuListovi
Definirajte klasu Cvijet izvedenu iz klase Biljka.
Definirajte klase Bijelogoricno i Crnogoricno izvedene iz klase Stablo.
Klasama definirajte odgovarajuće konstruktore.
Definirajte dva objekta Hrast i Bor tipova Bijelogoricno i Crnogoricno, te ispišite vrijednosti
njihovih članica opadajuListovi.
*/
        class Biljka
        {

        }
        class Stablo : Biljka
        {
            bool opadajuListovi;
            public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }

                public Stablo(){}
        }
        class Cvijet : Biljka
        {

        }
        class Bijelogoricno : Stablo
        {
            public Bijelogoricno() {
                OpadajuListovi = true;
            }
            public Bijelogoricno(bool opadajuListovi)
            {
                this.OpadajuListovi = opadajuListovi;
            }
        }
        class Crnogoricno : Stablo
        {
            public Crnogoricno() {
                OpadajuListovi = false;
            }
            public Crnogoricno(bool opadajuListovi)
            {
                this.OpadajuListovi = opadajuListovi;
            }
            
            

        }
        static void Main(string[] args)
        {
            Bijelogoricno hrast = new Bijelogoricno();
            Crnogoricno bor = new Crnogoricno();
            Console.WriteLine(hrast.OpadajuListovi);
            Console.WriteLine(bor.OpadajuListovi);
            Console.ReadKey();
        }
    }
}
