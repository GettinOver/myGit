using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
            double durchmesser = 0, flaeche, pi = System.Math.PI, fixkosten = 2.00, varKostenQcm = 0.01, varKosten, preis, gesPres = 0, prozent = 50;
			Console.WriteLine("Pizzapreisberechnung");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("");

			Console.Write("Druchmesser der Pizza in cm (max. 255): ");
			durchmesser = Convert.ToInt16(Console.ReadLine());


			flaeche = durchmesser * durchmesser * pi / 4;
			flaeche = Math.Round(flaeche, 2);

			varKosten = flaeche * varKostenQcm;
			varKosten = Math.Round(varKosten, 2);

			preis = varKosten + fixkosten;

			gesPres = preis + preis * 0.5;
			gesPres = Math.Round(gesPres, 2);

			Console.WriteLine("Die Pizza mit " + durchmesser + " cm Durchmesser kostet " + gesPres + " EUR. ");

			Console.WriteLine("");
			Console.WriteLine("Zusammensetzung");
			Console.WriteLine("Fixkosten       :		" + fixkosten + ",00 EUR");
			Console.WriteLine("var. Kosten/qcm :		" + varKostenQcm + " EUR");
			Console.WriteLine("Gewinnaufschlag :		" + prozent + " %");
			Console.WriteLine("Fläche		:		" + flaeche + " qcm");
			Console.WriteLine("Variable Kosten :		" + varKosten + " EUR");
			Console.WriteLine("Gesamtkosten	:		" + preis + " EUR");

			Console.ReadKey();
		}
    }
}
