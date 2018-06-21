using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
            double gewicht, gesamt = 0, preis1 = 0, preisAusg = 0;
            char zusatz;
            bool gueltig;

            do {
                Console.Clear();
                Console.WriteLine("Bitte geben Sie ein Gewicht an");
                gueltig = double.TryParse(Console.ReadLine(), out gewicht);

                if (!gueltig) {
                    Console.Clear();
                    Console.WriteLine("Bitte geben Sie eine Ganzzahl oder eine Dezimalzahl ein!");
                    Console.ReadLine();
                }

            } while (!gueltig);

            //ermittlung erstes gewicht
            if (gewicht < 5) {
                Console.Clear();
                preis1 = 2;
                Console.WriteLine("Die Versandkosten betragen " + preis1 + " Euro");
            } else if (gewicht == 5 || gewicht < 10) {
                Console.Clear();
                preis1 = 5;
                Console.WriteLine("Die Versandkosten betragen " + preis1 + " Euro");
            } else if (gewicht >= 10) {
                Console.Clear();
                preis1 = 10;
                Console.WriteLine("Die Versandkosten betragen " + preis1 + " Euro");
            }

            //ermittlung zusatz-pakete
            Console.WriteLine("Zum Hinzufügen eines weiteren Paketes, bitte \"y\", oder zur Ausgabe des Gesamtbetrages \"n\" eingeben");
            zusatz = Convert.ToChar(Console.ReadLine());

            if (zusatz == 'n') {
                //endesumme
                gesamt = preis1;
                Console.Clear();
                Console.WriteLine("Der Gesammtbetrag beträgt " + gesamt + " Euro");
            }

            while (zusatz == 'y') {
                do {
                    Console.Clear();
                    Console.WriteLine("Geben Sie bitte ein weiteres Gewicht an");
                    gueltig = double.TryParse(Console.ReadLine(), out gewicht);

                    if (!gueltig) {
                        Console.Clear();
                        Console.WriteLine("Bitte geben Sie eine Ganzzahl oder eine Dezimalzahl ein!");
                        Console.ReadLine();
                    }
                } while(!gueltig);

                if (gewicht < 5) {
                    Console.Clear();
                    preisAusg = 2;
                } else if (gewicht == 5 || gewicht < 10) {
                    Console.Clear();
                    preisAusg = 5;
                } else if (gewicht >= 10) {
                    Console.Clear();
                    preisAusg = 10;
                }
                preis1 = preis1 + preisAusg;
                Console.WriteLine("Zum Hinzufügen eines weiteren Paketes, bitte \"y\", oder zur Ausgabe des Gesamtbetrages \"n\" eingeben");
                zusatz = Convert.ToChar(Console.ReadLine());

                if (zusatz == 'n') {
                    //endesumme
                    gesamt = preis1;
                    Console.Clear();
                    Console.WriteLine("Der Gesammtbetrag beträgt " + gesamt + " Euro");
                }
            }

            Console.ReadLine();
        }

    }
}
