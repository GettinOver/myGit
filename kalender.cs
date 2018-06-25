using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
			int atn = 0, atn2;
			bool gueltig;
			string termin;
			string[] days = new string[32];
			string[] menu = { "Wählen Sie die gewünschte Operation aus:", "(1) Kalender aufrufen", "(2) Termin hinzufügen", "(3) Termin löschen", "(4) Termin verschieben", "(5) Programm beenden" };

			for (int i = 1; i < days.Length; i++) {
				days[i] = "Tag " + i + ": ";
			}

			do {
				foreach (string operation in menu) {
					Console.WriteLine(operation);
				}
				gueltig = int.TryParse(Console.ReadLine(), out atn);

				if (!gueltig) {
					Console.Clear();
					Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
					Console.ReadLine();
				}
				Console.Clear();
			} while (!gueltig);

			switch (atn) {
				case 1:
					foreach (string day in days) {
						Console.WriteLine(day);
					}

					Console.WriteLine("");

					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 2:
					do {
						Console.Clear();
						Console.WriteLine("An welchem Tag wollen Sie einen Termin hinzufügen?");
						gueltig = int.TryParse(Console.ReadLine(), out atn2);
						Console.Clear();

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 31 ein");
							Console.ReadLine();
						}
					} while (!gueltig);

					Console.Clear();
					Console.WriteLine("Bitte bennen Sie Ihren Termin");
					termin = Convert.ToString(Console.ReadLine());

					for (int i = atn2; i == atn2; i++) {
						days[i] = days[i] + termin;
					}

					Console.Clear();
					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 3:
					do {
						Console.Clear();
						Console.WriteLine("An welchem Tag wollen Sie einen Termin entfernen?");
						gueltig = int.TryParse(Console.ReadLine(), out atn2);
						Console.Clear();

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 31 ein");
							Console.ReadLine();
						}
					} while (!gueltig);

					for (int i = atn2; i == atn2; i++) {
						days[i] = "Tag " + i + ": ";
					}

					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 4:
					do {
						Console.WriteLine("Diese Funktion muss noch implementiert werden. Bitte wählen Sie eine andere Operation aus");
						Console.WriteLine("");

						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadLine();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
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
