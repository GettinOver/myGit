using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
			string[] menu = { "Bitte wählen Sie die gewünschte Option aus:", "(1) USD in EUR", "(2) EUR in USD", "(3) CHF in EUR", "(4) EUR in CHF", "(5) Programm beenden" };
			int input = 0;
			double betrag = 0, summe = 0;
			bool gueltig;

			do {
				Console.Clear();
				foreach (string option in menu) {
					Console.WriteLine(option);
				}
				gueltig = int.TryParse(Console.ReadLine(), out input);

				if (!gueltig) {
					Console.Clear();
					Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
					Console.ReadLine();
				}
			} while (!gueltig);

			switch (input) {
				case 1:
					do {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie den gewünschten Betrag ein");
						gueltig = double.TryParse(Console.ReadLine(), out betrag);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Ganzzahl oder eine Dezimalzahl ein");
							Console.ReadLine();
						}
					} while (!gueltig);

					summe = betrag * 1.168245;
					summe = Math.Round(summe, 2);
					Console.Clear();
					Console.WriteLine("Ihre Summe beträgt: " + summe + " Euro");
					Console.WriteLine("");

					do {
						foreach (string option in menu) {
							Console.WriteLine(option);
						}
						gueltig = int.TryParse(Console.ReadLine(), out input);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (input == 1) {
						goto case 1;
					} else if (input == 2) {
						goto case 2;
					} else if (input == 3) {
						goto case 3;
					} else if (input == 4) {
						goto case 4;
					} else if (input == 5) {
						goto case 5;
					}
					break;
				case 2:
					do {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie den gewünschten Betrag ein");
						gueltig = double.TryParse(Console.ReadLine(), out betrag);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Ganzzahl oder eine Dezimalzahl ein");
							Console.ReadLine();
						}
					} while (!gueltig);

					summe = betrag * 0.855984832;
					summe = Math.Round(summe, 2);
					Console.Clear();
					Console.WriteLine("Ihre Summe beträgt: " + summe + " US-Dollar");
					Console.WriteLine("");

					do {
						foreach (string option in menu) {
							Console.WriteLine(option);
						}
						gueltig = int.TryParse(Console.ReadLine(), out input);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (input == 1) {
						goto case 1;
					} else if (input == 2) {
						goto case 2;
					} else if (input == 3) {
						goto case 3;
					} else if (input == 4) {
						goto case 4;
					} else if (input == 5) {
						goto case 5;
					}
					break;
				case 3:
					do {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie den gewünschten Betrag ein");
						gueltig = double.TryParse(Console.ReadLine(), out betrag);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Ganzzahl oder eine Dezimalzahl ein");
							Console.ReadLine();
						}
					} while (!gueltig);

					summe = betrag * 1.1538792;
					summe = Math.Round(summe, 2);
					Console.Clear();
					Console.WriteLine("Ihre Summe beträgt: " + summe + " Euro");
					Console.WriteLine("");

					do {
						foreach (string option in menu) {
							Console.WriteLine(option);
						}
						gueltig = int.TryParse(Console.ReadLine(), out input);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (input == 1) {
						goto case 1;
					} else if (input == 2) {
						goto case 2;
					} else if (input == 3) {
						goto case 3;
					} else if (input == 4) {
						goto case 4;
					} else if (input == 5) {
						goto case 5;
					}
					break;
				case 4:
					do {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie den gewünschten Betrag ein");
						gueltig = double.TryParse(Console.ReadLine(), out betrag);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Ganzzahl oder eine Dezimalzahl ein");
							Console.ReadLine();
						}
					} while (!gueltig);

					summe = betrag * 0.866641843;
					summe = Math.Round(summe, 2);
					Console.Clear();
					Console.WriteLine("Ihre Summe beträgt: " + summe + " Schweizer Franken");
					Console.WriteLine("");

					do {
						foreach (string option in menu) {
							Console.WriteLine(option);
						}
						gueltig = int.TryParse(Console.ReadLine(), out input);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (input == 1) {
						goto case 1;
					} else if (input == 2) {
						goto case 2;
					} else if (input == 3) {
						goto case 3;
					} else if (input == 4) {
						goto case 4;
					} else if (input == 5) {
						goto case 5;
					}
					break;
				case 5:
					Environment.Exit(0);
					break;

			}

			Console.ReadLine();
		}

    }
}
