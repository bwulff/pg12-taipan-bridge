namespace TainPan_StockDataLoader
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.feldAufloesung = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.suchenButton = new System.Windows.Forms.Button();
            this.bisDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.titelAnzeige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vonDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDatenSchreiben = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDbTable = new System.Windows.Forms.TextBox();
            this.textDbNamespace = new System.Windows.Forms.TextBox();
            this.textDbHostname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkDSAuszugAnzeigen = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feldAufloesung)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.feldAufloesung);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.suchenButton);
            this.groupBox1.Controls.Add(this.bisDatum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titelAnzeige);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vonDatum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datensatz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sekunden";
            // 
            // feldAufloesung
            // 
            this.feldAufloesung.Location = new System.Drawing.Point(69, 106);
            this.feldAufloesung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.feldAufloesung.Name = "feldAufloesung";
            this.feldAufloesung.Size = new System.Drawing.Size(121, 20);
            this.feldAufloesung.TabIndex = 8;
            this.feldAufloesung.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Auflösung:";
            // 
            // suchenButton
            // 
            this.suchenButton.Location = new System.Drawing.Point(258, 26);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(75, 23);
            this.suchenButton.TabIndex = 6;
            this.suchenButton.Text = "Suchen";
            this.suchenButton.UseVisualStyleBackColor = true;
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // bisDatum
            // 
            this.bisDatum.Location = new System.Drawing.Point(52, 80);
            this.bisDatum.Name = "bisDatum";
            this.bisDatum.Size = new System.Drawing.Size(200, 20);
            this.bisDatum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bis:";
            // 
            // titelAnzeige
            // 
            this.titelAnzeige.Location = new System.Drawing.Point(52, 28);
            this.titelAnzeige.Name = "titelAnzeige";
            this.titelAnzeige.Size = new System.Drawing.Size(200, 20);
            this.titelAnzeige.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Von:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel:";
            // 
            // vonDatum
            // 
            this.vonDatum.Location = new System.Drawing.Point(52, 54);
            this.vonDatum.Name = "vonDatum";
            this.vonDatum.Size = new System.Drawing.Size(200, 20);
            this.vonDatum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDatenSchreiben);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textDbTable);
            this.groupBox2.Controls.Add(this.textDbNamespace);
            this.groupBox2.Controls.Add(this.textDbHostname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(361, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datenbank";
            // 
            // checkDatenSchreiben
            // 
            this.checkDatenSchreiben.AutoSize = true;
            this.checkDatenSchreiben.Location = new System.Drawing.Point(79, 109);
            this.checkDatenSchreiben.Name = "checkDatenSchreiben";
            this.checkDatenSchreiben.Size = new System.Drawing.Size(104, 17);
            this.checkDatenSchreiben.TabIndex = 6;
            this.checkDatenSchreiben.Text = "Daten schreiben";
            this.checkDatenSchreiben.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tabelle:";
            // 
            // textDbTable
            // 
            this.textDbTable.Location = new System.Drawing.Point(79, 83);
            this.textDbTable.Name = "textDbTable";
            this.textDbTable.Size = new System.Drawing.Size(299, 20);
            this.textDbTable.TabIndex = 4;
            this.textDbTable.Text = "QuotesBySymbol";
            // 
            // textDbNamespace
            // 
            this.textDbNamespace.Location = new System.Drawing.Point(79, 57);
            this.textDbNamespace.Name = "textDbNamespace";
            this.textDbNamespace.Size = new System.Drawing.Size(299, 20);
            this.textDbNamespace.TabIndex = 3;
            this.textDbNamespace.Text = "bridgetest";
            // 
            // textDbHostname
            // 
            this.textDbHostname.Location = new System.Drawing.Point(79, 28);
            this.textDbHostname.Name = "textDbHostname";
            this.textDbHostname.Size = new System.Drawing.Size(299, 20);
            this.textDbHostname.TabIndex = 2;
            this.textDbHostname.Text = "diplom09.informatik.uni-osnabrueck.de";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Namespace:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "URI:";
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(12, 166);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(733, 309);
            this.logText.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Importieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkDSAuszugAnzeigen
            // 
            this.checkDSAuszugAnzeigen.AutoSize = true;
            this.checkDSAuszugAnzeigen.Location = new System.Drawing.Point(12, 485);
            this.checkDSAuszugAnzeigen.Name = "checkDSAuszugAnzeigen";
            this.checkDSAuszugAnzeigen.Size = new System.Drawing.Size(154, 17);
            this.checkDSAuszugAnzeigen.TabIndex = 7;
            this.checkDSAuszugAnzeigen.Text = "Datensatzauszug anzeigen";
            this.checkDSAuszugAnzeigen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 516);
            this.Controls.Add(this.checkDSAuszugAnzeigen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "TaiPan-Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feldAufloesung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.DateTimePicker bisDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titelAnzeige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker vonDatum;
        private System.Windows.Forms.TextBox textDbNamespace;
        private System.Windows.Forms.TextBox textDbHostname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkDSAuszugAnzeigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDbTable;
        private System.Windows.Forms.NumericUpDown feldAufloesung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkDatenSchreiben;
        private System.Windows.Forms.Label label8;

    }
}

