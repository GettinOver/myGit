using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
			Random rdm = new Random();
			int[] bspArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int anzahl, zahl = 0, eins = 0, zwei = 0, drei = 0, vier = 0, fuenf = 0, sechs = 0, sieben = 0, acht = 0, neun = 0, zehn = 0;

			Console.WriteLine("Wieviele Zufallszahlen möchten Sie generieren?");
			anzahl = Convert.ToInt16(Console.ReadLine());
			Console.Clear();

			for (int i = 0; i < anzahl; i++) {
				zahl = rdm.Next(1, 11);
				Console.WriteLine(zahl);


				if (zahl == 1) {
					eins++;
				}

				if (zahl == 2) {
					zwei++;
				}

				if (zahl == 3) {
					drei++;
				}

				if (zahl == 4) {
					vier++;
				}

				if (zahl == 5) {
					fuenf++;
				}

				if (zahl == 6) {
					sechs++;
				}

				if (zahl == 7) {
					sieben++;
				}

				if (zahl == 8) {
					acht++;
				}

				if (zahl == 9) {
					neun++;
				}

				if (zahl == 10) {
					zehn++;
				}
			}

			Console.Clear();

			Console.WriteLine(anzahl);
			Console.Write("Zahl: 1\t\t Anzahl: " + eins + "\t\t: ");
			for (int i = 0; i < eins; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 2\t\t Anzahl: " + zwei + "\t\t: ");
			for (int i = 0; i < zwei; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 3\t\t Anzahl: " + drei + "\t\t: ");
			for (int i = 0; i < drei; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 4\t\t Anzahl: " + vier + "\t\t: ");
			for (int i = 0; i < vier; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 5\t\t Anzahl: " + fuenf + "\t\t: ");
			for (int i = 0; i < fuenf; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 6\t\t Anzahl: " + sechs + "\t\t: ");
			for (int i = 0; i < sechs; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 7\t\t Anzahl: " + sieben + "\t\t: ");
			for (int i = 0; i < sieben; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 8\t\t Anzahl: " + acht + "\t\t: ");
			for (int i = 0; i < acht; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 9\t\t Anzahl: " + neun + "\t\t: ");
			for (int i = 0; i < neun; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.Write("Zahl: 10\t Anzahl: " + zehn + "\t\t: ");
			for (int i = 0; i < zehn; i++) {
				Console.Write("|");
			}
			Console.WriteLine("");

			Console.ReadLine();
		}

    }
}
