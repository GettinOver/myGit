using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Rechner {
	public partial class Form1 : Form {
		double BMI, heightQ;
		bool genderCk;

		public Form1() {
			InitializeComponent();

			tbHeight.Minimum = 100;
			tbHeight.Maximum = 210;
			tbHeight.TickFrequency = 5;

			tbWeight.Minimum = 30;
			tbWeight.Maximum = 140;
			tbWeight.TickFrequency = 5;			
		}
		
		private void tbHeight_Scroll(object sender, EventArgs e) {
			lblDisplayHeight.Text = tbHeight.Value.ToString() + " cm";
			heightQ = (tbHeight.Value * 0.01) * (tbHeight.Value * 0.01);			
			BMI = tbWeight.Value / heightQ;
			BMI = Math.Round(BMI, 2);
			lblBMI.Text = "Ihr BMI lautet: " + BMI.ToString();
			
			if (genderCk == true) {
				if (BMI < 15) {
					lblDiag.Text = "Sie haben starkes Untergewicht";
				} else if (BMI > 15 && BMI < 17.5) {
					lblDiag.Text = "Sie haben mäßiges Untergewicht";
				} else if (BMI > 17.5 && BMI < 20) {
					lblDiag.Text = "Sie haben leichtes Untergewicht";
				} else if (BMI > 20 && BMI < 24) {
					lblDiag.Text = "Sie haben Normalgewicht";
				} else if (BMI > 24 && BMI < 29) {
					lblDiag.Text = "Sie haben Präadipositas";
				} else if (BMI > 29 && BMI < 34) {
					lblDiag.Text = "Sie haben Adipositas Grad I";
				} else if (BMI > 34 && BMI < 39) {
					lblDiag.Text = "Sie haben Adipositas Grad II";
				} else if (BMI > 39) {
					lblDiag.Text = "Sie haben Adipositas Grad III";
				}
			}			

			if (genderCk == false) {
				if (BMI < 16) {
					lblDiag.Text = "Sie haben starkes Untergewicht";
				} else if (BMI > 16 && BMI < 17) {
					lblDiag.Text = "Sie haben mäßiges Untergewicht";
				} else if (BMI > 17 && BMI < 20) {
					lblDiag.Text = "Sie haben leichtes Untergewicht";
				} else if (BMI > 20 && BMI < 25) {
					lblDiag.Text = "Sie haben Normalgewicht";
				} else if (BMI > 25 && BMI < 30) {
					lblDiag.Text = "Sie haben Präadipositas";
				} else if (BMI > 30 && BMI < 35) {
					lblDiag.Text = "Sie haben Adipositas Grad I";
				} else if (BMI > 35 && BMI < 40) {
					lblDiag.Text = "Sie haben Adipositas Grad II";
				} else if (BMI > 40) {
					lblDiag.Text = "Sie haben Adipositas Grad III";
				}
			}

		}

		private void tbWeight_Scroll(object sender, EventArgs e) {
			lblDisplayWeight.Text = tbWeight.Value.ToString() + " kg";
			BMI = tbWeight.Value / heightQ;
			BMI = Math.Round(BMI, 2);
			lblBMI.Text = "Ihr BMI lautet " + BMI.ToString();

			if (genderCk == true) {
				if (BMI < 15) {
					lblDiag.Text = "Sie haben starkes Untergewicht";
				} else if (BMI > 15 && BMI < 17.5) {
					lblDiag.Text = "Sie haben mäßiges Untergewicht";
				} else if (BMI > 17.5 && BMI < 20) {
					lblDiag.Text = "Sie haben leichtes Untergewicht";
				} else if (BMI > 20 && BMI < 24) {
					lblDiag.Text = "Sie haben Normalgewicht";
				} else if (BMI > 24 && BMI < 29) {
					lblDiag.Text = "Sie haben Präadipositas";
				} else if (BMI > 29 && BMI < 34) {
					lblDiag.Text = "Sie haben Adipositas Grad I";
				} else if (BMI > 34 && BMI < 39) {
					lblDiag.Text = "Sie haben Adipositas Grad II";
				} else if (BMI > 39) {
					lblDiag.Text = "Sie haben Adipositas Grad III";
				}
			}

			if (genderCk == false) {
				if (BMI < 16) {
					lblDiag.Text = "Sie haben starkes Untergewicht";
				} else if (BMI > 16 && BMI < 17) {
					lblDiag.Text = "Sie haben mäßiges Untergewicht";
				} else if (BMI > 17 && BMI < 20) {
					lblDiag.Text = "Sie haben leichtes Untergewicht";
				} else if (BMI > 20 && BMI < 25) {
					lblDiag.Text = "Sie haben Normalgewicht";
				} else if (BMI > 25 && BMI < 30) {
					lblDiag.Text = "Sie haben Präadipositas";
				} else if (BMI > 30 && BMI < 35) {
					lblDiag.Text = "Sie haben Adipositas Grad I";
				} else if (BMI > 35 && BMI < 40) {
					lblDiag.Text = "Sie haben Adipositas Grad II";
				} else if (BMI > 40) {
					lblDiag.Text = "Sie haben Adipositas Grad III";
				}
			}
		}
		private void rBtnFemale_CheckedChanged(object sender, EventArgs e) {
			genderCk = true;
		}

		private void rBtnMale_CheckedChanged(object sender, EventArgs e) {
			genderCk = false;
		}
	}
}
