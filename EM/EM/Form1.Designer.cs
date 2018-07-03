namespace EM {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.gbAnztafel = new System.Windows.Forms.GroupBox();
			this.tbGast = new System.Windows.Forms.Label();
			this.tbHeim = new System.Windows.Forms.Label();
			this.labelTimer = new System.Windows.Forms.Label();
			this.labelDP = new System.Windows.Forms.Label();
			this.labelGastTore = new System.Windows.Forms.Label();
			this.labelHeimTore = new System.Windows.Forms.Label();
			this.gbSteuerung = new System.Windows.Forms.GroupBox();
			this.btnGastDef = new System.Windows.Forms.Button();
			this.btnHeimDef = new System.Windows.Forms.Button();
			this.tbHeimDef = new System.Windows.Forms.TextBox();
			this.tbGastDef = new System.Windows.Forms.TextBox();
			this.btnTorHeim = new System.Windows.Forms.Button();
			this.btnTorGast = new System.Windows.Forms.Button();
			this.btnAbpfiff = new System.Windows.Forms.Button();
			this.btnAnpfiff = new System.Windows.Forms.Button();
			this.timerGame = new System.Windows.Forms.Timer(this.components);
			this.gbAnztafel.SuspendLayout();
			this.gbSteuerung.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbAnztafel
			// 
			this.gbAnztafel.Controls.Add(this.tbGast);
			this.gbAnztafel.Controls.Add(this.tbHeim);
			this.gbAnztafel.Controls.Add(this.labelTimer);
			this.gbAnztafel.Controls.Add(this.labelDP);
			this.gbAnztafel.Controls.Add(this.labelGastTore);
			this.gbAnztafel.Controls.Add(this.labelHeimTore);
			this.gbAnztafel.Location = new System.Drawing.Point(12, 12);
			this.gbAnztafel.Name = "gbAnztafel";
			this.gbAnztafel.Size = new System.Drawing.Size(267, 158);
			this.gbAnztafel.TabIndex = 0;
			this.gbAnztafel.TabStop = false;
			this.gbAnztafel.Text = "Anzeigetafel";
			// 
			// tbGast
			// 
			this.tbGast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tbGast.Location = new System.Drawing.Point(145, 19);
			this.tbGast.Name = "tbGast";
			this.tbGast.Size = new System.Drawing.Size(116, 23);
			this.tbGast.TabIndex = 15;
			this.tbGast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbHeim
			// 
			this.tbHeim.BackColor = System.Drawing.SystemColors.Control;
			this.tbHeim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tbHeim.Location = new System.Drawing.Point(6, 19);
			this.tbHeim.Name = "tbHeim";
			this.tbHeim.Size = new System.Drawing.Size(116, 23);
			this.tbHeim.TabIndex = 14;
			this.tbHeim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTimer
			// 
			this.labelTimer.AutoSize = true;
			this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelTimer.Location = new System.Drawing.Point(99, 101);
			this.labelTimer.Name = "labelTimer";
			this.labelTimer.Size = new System.Drawing.Size(62, 25);
			this.labelTimer.TabIndex = 13;
			this.labelTimer.Text = "00:00";
			// 
			// labelDP
			// 
			this.labelDP.AutoSize = true;
			this.labelDP.Location = new System.Drawing.Point(128, 22);
			this.labelDP.Name = "labelDP";
			this.labelDP.Size = new System.Drawing.Size(10, 13);
			this.labelDP.TabIndex = 12;
			this.labelDP.Text = ":";
			// 
			// labelGastTore
			// 
			this.labelGastTore.AutoSize = true;
			this.labelGastTore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGastTore.Location = new System.Drawing.Point(180, 59);
			this.labelGastTore.Name = "labelGastTore";
			this.labelGastTore.Size = new System.Drawing.Size(42, 46);
			this.labelGastTore.TabIndex = 11;
			this.labelGastTore.Text = "0";
			// 
			// labelHeimTore
			// 
			this.labelHeimTore.AutoSize = true;
			this.labelHeimTore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHeimTore.Location = new System.Drawing.Point(42, 59);
			this.labelHeimTore.Name = "labelHeimTore";
			this.labelHeimTore.Size = new System.Drawing.Size(42, 46);
			this.labelHeimTore.TabIndex = 10;
			this.labelHeimTore.Text = "0";
			// 
			// gbSteuerung
			// 
			this.gbSteuerung.Controls.Add(this.btnGastDef);
			this.gbSteuerung.Controls.Add(this.btnHeimDef);
			this.gbSteuerung.Controls.Add(this.tbHeimDef);
			this.gbSteuerung.Controls.Add(this.tbGastDef);
			this.gbSteuerung.Controls.Add(this.btnTorHeim);
			this.gbSteuerung.Controls.Add(this.btnTorGast);
			this.gbSteuerung.Controls.Add(this.btnAbpfiff);
			this.gbSteuerung.Controls.Add(this.btnAnpfiff);
			this.gbSteuerung.Location = new System.Drawing.Point(12, 176);
			this.gbSteuerung.Name = "gbSteuerung";
			this.gbSteuerung.Size = new System.Drawing.Size(267, 109);
			this.gbSteuerung.TabIndex = 1;
			this.gbSteuerung.TabStop = false;
			this.gbSteuerung.Text = "Steuerung";
			// 
			// btnGastDef
			// 
			this.btnGastDef.Location = new System.Drawing.Point(134, 81);
			this.btnGastDef.Name = "btnGastDef";
			this.btnGastDef.Size = new System.Drawing.Size(128, 23);
			this.btnGastDef.TabIndex = 9;
			this.btnGastDef.Text = "Gastmannschaft setzen";
			this.btnGastDef.UseVisualStyleBackColor = true;
			// 
			// btnHeimDef
			// 
			this.btnHeimDef.Location = new System.Drawing.Point(134, 54);
			this.btnHeimDef.Name = "btnHeimDef";
			this.btnHeimDef.Size = new System.Drawing.Size(128, 23);
			this.btnHeimDef.TabIndex = 8;
			this.btnHeimDef.Text = "Heimmannschaft setzen";
			this.btnHeimDef.UseVisualStyleBackColor = true;
			// 
			// tbHeimDef
			// 
			this.tbHeimDef.AcceptsReturn = true;
			this.tbHeimDef.Location = new System.Drawing.Point(6, 57);
			this.tbHeimDef.Name = "tbHeimDef";
			this.tbHeimDef.Size = new System.Drawing.Size(116, 20);
			this.tbHeimDef.TabIndex = 7;
			// 
			// tbGastDef
			// 
			this.tbGastDef.AcceptsReturn = true;
			this.tbGastDef.Location = new System.Drawing.Point(6, 83);
			this.tbGastDef.Name = "tbGastDef";
			this.tbGastDef.Size = new System.Drawing.Size(116, 20);
			this.tbGastDef.TabIndex = 6;
			// 
			// btnTorHeim
			// 
			this.btnTorHeim.Location = new System.Drawing.Point(73, 19);
			this.btnTorHeim.Name = "btnTorHeim";
			this.btnTorHeim.Size = new System.Drawing.Size(58, 23);
			this.btnTorHeim.TabIndex = 5;
			this.btnTorHeim.Text = "Tor Heim";
			this.btnTorHeim.UseVisualStyleBackColor = true;
			// 
			// btnTorGast
			// 
			this.btnTorGast.Location = new System.Drawing.Point(137, 19);
			this.btnTorGast.Name = "btnTorGast";
			this.btnTorGast.Size = new System.Drawing.Size(60, 23);
			this.btnTorGast.TabIndex = 4;
			this.btnTorGast.Text = "Tor Gast";
			this.btnTorGast.UseVisualStyleBackColor = true;
			// 
			// btnAbpfiff
			// 
			this.btnAbpfiff.Location = new System.Drawing.Point(216, 19);
			this.btnAbpfiff.Name = "btnAbpfiff";
			this.btnAbpfiff.Size = new System.Drawing.Size(46, 23);
			this.btnAbpfiff.TabIndex = 3;
			this.btnAbpfiff.Text = "Abpfiff";
			this.btnAbpfiff.UseVisualStyleBackColor = true;
			// 
			// btnAnpfiff
			// 
			this.btnAnpfiff.Location = new System.Drawing.Point(6, 19);
			this.btnAnpfiff.Name = "btnAnpfiff";
			this.btnAnpfiff.Size = new System.Drawing.Size(45, 23);
			this.btnAnpfiff.TabIndex = 2;
			this.btnAnpfiff.Text = "Anpfiff";
			this.btnAnpfiff.UseVisualStyleBackColor = true;
			// 
			// timerGame
			// 
			this.timerGame.Interval = 1000;
			this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 295);
			this.Controls.Add(this.gbSteuerung);
			this.Controls.Add(this.gbAnztafel);
			this.Name = "Form1";
			this.Text = "EM-Anzeige";
			this.gbAnztafel.ResumeLayout(false);
			this.gbAnztafel.PerformLayout();
			this.gbSteuerung.ResumeLayout(false);
			this.gbSteuerung.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbAnztafel;
		private System.Windows.Forms.GroupBox gbSteuerung;
		private System.Windows.Forms.Button btnHeimDef;
		private System.Windows.Forms.TextBox tbHeimDef;
		private System.Windows.Forms.TextBox tbGastDef;
		private System.Windows.Forms.Button btnTorHeim;
		private System.Windows.Forms.Button btnTorGast;
		private System.Windows.Forms.Button btnAbpfiff;
		private System.Windows.Forms.Button btnAnpfiff;
		private System.Windows.Forms.Button btnGastDef;
		private System.Windows.Forms.Label labelHeimTore;
		private System.Windows.Forms.Label labelGastTore;
		private System.Windows.Forms.Label labelTimer;
		private System.Windows.Forms.Label labelDP;
		private System.Windows.Forms.Label tbHeim;
		private System.Windows.Forms.Label tbGast;
		private System.Windows.Forms.Timer timerGame;
	}
}

