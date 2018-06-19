using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
            double dblSumme = 19.99, dblRueckgeld, dblGegeben = 0, dblObergrenze = 50, dblWenig;
            char yn;

            Console.WriteLine("Dies Summe beträgt: " + dblSumme + " Wieviel Geld geben Sie?");
            dblGegeben = Convert.ToDouble(Console.ReadLine());
            dblWenig = dblSumme - dblGegeben;
            dblWenig = System.Math.Round(dblWenig, 2);

            if (dblGegeben < dblSumme || dblGegeben > dblObergrenze) {
                while (dblGegeben < dblSumme || dblGegeben > dblObergrenze) {
                    if (dblGegeben < dblSumme) {
                        Console.Clear();
                        Console.WriteLine("Ihr Guthaben reicht nicht aus. Es fehlen noch " + dblWenig + " Euro");
                        Console.WriteLine("Wenn Sie einen neuen Betrag eingeben möchten, drücken Sie \"y\".");
                        yn = Convert.ToChar(Console.ReadLine());
                        Console.Clear();
                        if (yn == 'y') {
                            Console.WriteLine("Dies Summe beträgt: " + dblSumme + " Wieviel Geld geben Sie?");
                            dblGegeben = Convert.ToDouble(Console.ReadLine());
                            dblWenig = dblSumme - dblGegeben;
                            dblWenig = System.Math.Round(dblWenig, 2);
                            if (dblGegeben < dblSumme) {
                                Console.Clear();
                                Console.WriteLine("Ihr Guthaben reicht nicht aus. Es fehlen noch " + dblWenig);
                            } else if (dblGegeben > dblObergrenze) {
                                Console.Clear();
                                Console.WriteLine("Die Obergrenze wurde überschritten. Einen solchen Betrag nehmen wir nicht an.");
                            } else if (dblGegeben >= dblSumme && dblGegeben <= dblObergrenze) {
                                dblRueckgeld = dblGegeben - dblSumme;
                                dblRueckgeld = System.Math.Round(dblRueckgeld, 2);
                                Console.Clear();
                                Console.WriteLine("Summe: " + dblSumme + " Euro");
                                Console.WriteLine("Gegeben: " + dblGegeben + " Euro");
                                Console.WriteLine("Rückgeld: " + dblRueckgeld + " Euro");
                            }
                        }
                    } else if (dblGegeben > dblObergrenze) {
                        Console.Clear();
                        Console.WriteLine("Die Obergrenze wurde überschritten. Einen solchen Betrag nehmen wir nicht an.");
                        Console.WriteLine("Wenn Sie einen neuen Betrag eingeben möchten, drücken Sie \"y\".");
                        yn = Convert.ToChar(Console.ReadLine());
                        Console.Clear();
                        if (yn == 'y') {
                            Console.WriteLine("Dies Summe beträgt: " + dblSumme + " Wieviel Geld geben Sie?");
                            dblGegeben = Convert.ToDouble(Console.ReadLine());
                            dblWenig = dblSumme - dblGegeben;
                            dblWenig = System.Math.Round(dblWenig, 2);
                            if (dblGegeben < dblSumme) {
                                Console.Clear();
                                Console.WriteLine("Ihr Guthaben reicht nicht aus. Es fehlen noch " + dblWenig + " Euro");
                            } else if (dblGegeben > dblObergrenze) {
                                Console.Clear();
                                Console.WriteLine("Die Obergrenze wurde überschritten. Einen solchen Betrag nehmen wir nicht an.");
                            } else if (dblGegeben >= dblSumme && dblGegeben <= dblObergrenze) {
                                dblRueckgeld = dblGegeben - dblSumme;
                                dblRueckgeld = System.Math.Round(dblRueckgeld, 2);
                                Console.Clear();
                                Console.WriteLine("Summe: " + dblSumme + " Euro");
                                Console.WriteLine("Gegeben: " + dblGegeben + " Euro");
                                Console.WriteLine("Rückgeld: " + dblRueckgeld + " Euro");
                            }
                        }
                    }
                }
            } else {
                dblRueckgeld = dblGegeben - dblSumme;
                dblRueckgeld = System.Math.Round(dblRueckgeld, 2);
                Console.Clear();
                Console.WriteLine("Summe: " + dblSumme + " Euro");
                Console.WriteLine("Gegeben: " + dblGegeben + " Euro");
                Console.WriteLine("Rückgeld: " + dblRueckgeld + " Euro");
            }

            Console.ReadLine();
        }

    }
}
