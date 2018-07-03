using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM {
	public partial class Form1 : Form {
		int countHeim, countGast, timeSec, timeMin = 0;		

		// buttons bekommen funktionen
		public Form1() {
			InitializeComponent();

			btnTorHeim.Click += ButtonClickedHeim;
			btnTorGast.Click += ButtonClickedGast;
			btnHeimDef.Click += ButtonClickedHeimDef;
			btnGastDef.Click += ButtonClickedGastDef;
			btnAnpfiff.Click += ButtonClickedAnpfiff; // start timer
			btnAbpfiff.Click += ButtonClickedAbpfiff; // stop timer

			btnTorHeim.Enabled = false;
			btnTorGast.Enabled = false;
			btnAbpfiff.Enabled = false;
		}

		#region button funktionen
		// button tor heim
		void ButtonClickedHeim(object sender, EventArgs e) {			
			countHeim++;
			labelHeimTore.Text = countHeim.ToString();			
		}

		// button tor gast
		void ButtonClickedGast(object sender, EventArgs e) {
			countGast++;
			labelGastTore.Text = countGast.ToString();				
		}

		// button heim definierung
		void ButtonClickedHeimDef(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(tbHeimDef.Text)) {
				MessageBox.Show("Bitte geben Sie eine Heimmanschaft an");
			} else if (tbHeimDef.Text.Length < 5) {
				MessageBox.Show("Ihre Eingabe war zu kurz");
			} else {
				tbHeim.Text = tbHeimDef.Text;
				tbHeimDef.Clear();
				btnHeimDef.Enabled = false;
				tbHeimDef.Enabled = false;
			}
		}

		// button gast definierung
		void ButtonClickedGastDef(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(tbGastDef.Text)) {
				MessageBox.Show("Bitte geben Sie eine Gastmannschaft an");
			} else if (tbGastDef.Text.Length < 5) {
				MessageBox.Show("Ihre Eingabe war zu kurz");
			} else if (tbHeim.Text == tbGastDef.Text) {
				MessageBox.Show("Bitte geben Sie zwei unterschiedliche Länder ein");
			} else {
				tbGast.Text = tbGastDef.Text;
				tbGastDef.Clear();
				btnGastDef.Enabled = false;
				tbGastDef.Enabled = false;
			}
		}

		private void timerGame_Tick(object sender, EventArgs e) {
			timeSec++;
			labelTimer.Text = timeMin.ToString() + " : " + timeSec.ToString();
			if (timeSec == 60) {
				timeSec = 0;
				timeMin++;
			}

			if (timeMin < 10 && timeSec < 10) {
				labelTimer.Text = "0" + timeMin.ToString() + ":" + "0" + timeSec.ToString();
			} else if (timeMin < 10) {
				labelTimer.Text = "0" + timeMin.ToString() + ":" + timeSec.ToString();
			} else if (timeSec < 10) {
				labelTimer.Text = timeMin.ToString() + ":" + "0" + timeSec.ToString();
			}
		}

		// button anpfiff
		void ButtonClickedAnpfiff(object sender, EventArgs e) {
			if (btnHeimDef.Enabled == false && btnGastDef.Enabled == false) {
				timerGame.Start();
				btnAnpfiff.Enabled = false;
				btnTorHeim.Enabled = true;
				btnTorGast.Enabled = true;
				btnAbpfiff.Enabled = true;				
			} else {
				MessageBox.Show("Bitte geben Sie eine Heim- und eine Gastmannschaft an");
			}
		}

		// button abpfiff
		void ButtonClickedAbpfiff(object sender, EventArgs e) {			
				timerGame.Stop();					
		}
		#endregion button funktionen
	}
}