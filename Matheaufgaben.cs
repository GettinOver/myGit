using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
			Random rdm = new Random();
			int zahl1, zahl2, input, ergebnis = 0, count = 0, tryCount = 0;
			bool gueltig;
			char[] operators = { '+', '-', '*' };
			DateTime startTime = DateTime.Now;
			string longDateString = startTime.ToLongDateString();

			for (int i = 0; i <= 10; i++) {
				zahl1 = rdm.Next(1, 11);
				zahl2 = rdm.Next(1, 11);
				char rdmNbr = operators[rdm.Next(0, operators.Length)];

				if (rdmNbr == '+') {
					ergebnis = zahl1 + zahl2;
				} else if (rdmNbr == '-') {
					ergebnis = zahl1 - zahl2;
				} else if (rdmNbr == '*') {
					ergebnis = zahl1 * zahl2;
				}

				do {
					Console.Clear();
					Console.WriteLine("Wie viel ist " + zahl1 + " " + rdmNbr + " " + zahl2 + "?");
					gueltig = int.TryParse(Console.ReadLine(), out input);

					if (!gueltig) {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
						Console.ReadLine();
					}

				} while (!gueltig);

				while (input != ergebnis) {
					Console.Clear();
					Console.WriteLine("Das Ergebnis ist falsch!");
					Console.ReadLine();
					do {
						Console.Clear();
						Console.WriteLine("Wie viel ist " + zahl1 + " " + rdmNbr + " " + zahl2 + "?");
						gueltig = int.TryParse(Console.ReadLine(), out input);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
							Console.ReadLine();
						}

					} while (!gueltig);

					tryCount++;
				}
				count++;

				if (count == 10) {
					Console.Clear();
					DateTime endTime = DateTime.Now;
					string longDateString2 = endTime.ToLongDateString();
					TimeSpan timer = endTime.Subtract(startTime);

					Console.WriteLine("Sie haben alle zehn Aufgaben gelöst und dafür " + timer.Minutes + " Minuten und " + timer.Seconds + " Sekunden benötigt.");
					Console.WriteLine("Ihre Fehleranzahl lag bei " + tryCount);

					break;
				}
			}

			Console.ReadLine();
		}

    }
}
