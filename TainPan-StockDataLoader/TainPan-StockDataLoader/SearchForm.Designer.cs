namespace TainPan_StockDataLoader
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sucheText = new System.Windows.Forms.TextBox();
            this.suchenButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.handelsplatzSelect = new System.Windows.Forms.ComboBox();
            this.wpArtSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ergList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suchbegriff:";
            // 
            // sucheText
            // 
            this.sucheText.Location = new System.Drawing.Point(92, 15);
            this.sucheText.Name = "sucheText";
            this.sucheText.Size = new System.Drawing.Size(289, 20);
            this.sucheText.TabIndex = 1;
            // 
            // suchenButton
            // 
            this.suchenButton.Location = new System.Drawing.Point(387, 12);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(79, 23);
            this.suchenButton.TabIndex = 2;
            this.suchenButton.Text = "Suchen";
            this.suchenButton.UseVisualStyleBackColor = true;
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(355, 261);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(111, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Übernehmen";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Handelsplatz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wertpapierart:";
            // 
            // handelsplatzSelect
            // 
            this.handelsplatzSelect.FormattingEnabled = true;
            this.handelsplatzSelect.Location = new System.Drawing.Point(92, 41);
            this.handelsplatzSelect.Name = "handelsplatzSelect";
            this.handelsplatzSelect.Size = new System.Drawing.Size(289, 21);
            this.handelsplatzSelect.TabIndex = 8;
            // 
            // wpArtSelect
            // 
            this.wpArtSelect.FormattingEnabled = true;
            this.wpArtSelect.Location = new System.Drawing.Point(92, 68);
            this.wpArtSelect.Name = "wpArtSelect";
            this.wpArtSelect.Size = new System.Drawing.Size(289, 21);
            this.wpArtSelect.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ergList);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 146);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suchergebnis:";
            // 
            // ergList
            // 
            this.ergList.FormattingEnabled = true;
            this.ergList.Location = new System.Drawing.Point(6, 19);
            this.ergList.Name = "ergList";
            this.ergList.Size = new System.Drawing.Size(442, 121);
            this.ergList.TabIndex = 0;
            this.ergList.SelectedIndexChanged += new System.EventHandler(this.ergList_SelectedIndexChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wpArtSelect);
            this.Controls.Add(this.handelsplatzSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.suchenButton);
            this.Controls.Add(this.sucheText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchForm";
            this.Text = "Titel suchen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sucheText;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox handelsplatzSelect;
        private System.Windows.Forms.ComboBox wpArtSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ergList;
    }
}