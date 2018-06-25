using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
			int[] bspArray = new int[5] { 3, 6, 9, 12, 15 };
			int[] bspArray1 = new int[5] { 2, 3, 5, 8, 12 };
			int[] bspArray2 = new int[5] { 2, 5, 11, 23, 47 };
			int input = 0, fail = 0;
			bool gueltig;

			/*for (int i = 0; i < bspArray.Length; i++) {
                bspArray[i] = i+3;
            }*/

			//first array
			do {
				Console.Clear();
				Console.WriteLine("Bitte geben Sie den fehlenden Wert ein: ");

				Console.Write(bspArray[0] + ", ");
				Console.Write(bspArray[1] + ", ");
				Console.Write(bspArray[2] + ", ");
				Console.Write(bspArray[3] + ", ");
				gueltig = int.TryParse(Console.ReadLine(), out input);

				if (!gueltig) {
					Console.Clear();
					Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
					Console.ReadLine();
				}
			} while (!gueltig);

			if (input != bspArray[4]) {
				Console.Clear();
				Console.WriteLine("Die Eingabe ist falsch!");
				fail++;
			} else if (input == bspArray[4]) {
				Console.WriteLine("Die Eingabe ist korrekt!");
			}
			Console.ReadLine();

			//second array
			do {
				Console.Clear();
				Console.WriteLine("Bitte geben Sie den fehlenden Wert ein: ");
				Console.Write(bspArray1[0] + ", ");
				Console.Write(bspArray1[1] + ", ");
				Console.Write(bspArray1[2] + ", ");
				Console.Write(bspArray1[3] + ", ");
				gueltig = int.TryParse(Console.ReadLine(), out input);

				if (!gueltig) {
					Console.Clear();
					Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
					Console.ReadLine();
				}
			} while (!gueltig);

			if (input != bspArray1[4]) {
				Console.Clear();
				Console.WriteLine("Die Eingabe ist falsch!");
				fail++;
			} else if (input == bspArray1[4]) {
				Console.WriteLine("Die Eingabe ist korrekt!");
			}
			Console.ReadLine();

			//third array
			do {
				Console.Clear();
				Console.WriteLine("Bitte geben Sie den fehlenden Wert ein: ");
				Console.Write(bspArray2[0] + ", ");
				Console.Write(bspArray2[1] + ", ");
				Console.Write(bspArray2[2] + ", ");
				Console.Write(bspArray2[3] + ", ");
				gueltig = int.TryParse(Console.ReadLine(), out input);

				if (!gueltig) {
					Console.Clear();
					Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
					Console.ReadLine();
				}
			} while (!gueltig);

			if (input != bspArray2[4]) {
				Console.Clear();
				Console.WriteLine("Die Eingabe ist falsch!");
				fail++;
			} else if (input == bspArray2[4]) {
				Console.WriteLine("Die Eingabe ist korrekt!");
			}

			Console.Clear();
			Console.WriteLine("Sie haben " + fail + " Fehler gemacht.");

			Console.ReadLine();
		}

    }
}
