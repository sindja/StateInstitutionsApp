namespace DesktopAplikacija
{
    partial class DodajZapisnik
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
            this.labelDatumSudjenja = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelZapisnik = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatumSudjenja
            // 
            this.labelDatumSudjenja.AutoSize = true;
            this.labelDatumSudjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumSudjenja.Location = new System.Drawing.Point(12, 36);
            this.labelDatumSudjenja.Name = "labelDatumSudjenja";
            this.labelDatumSudjenja.Size = new System.Drawing.Size(119, 16);
            this.labelDatumSudjenja.TabIndex = 0;
            this.labelDatumSudjenja.Text = "Datum sudjenja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(327, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(137, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 267);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // labelZapisnik
            // 
            this.labelZapisnik.AutoSize = true;
            this.labelZapisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZapisnik.Location = new System.Drawing.Point(60, 79);
            this.labelZapisnik.Name = "labelZapisnik";
            this.labelZapisnik.Size = new System.Drawing.Size(71, 16);
            this.labelZapisnik.TabIndex = 3;
            this.labelZapisnik.Text = "Zapisnik:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.Snow;
            this.buttonDodaj.Location = new System.Drawing.Point(248, 373);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(118, 40);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // DodajZapisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 443);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelZapisnik);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDatumSudjenja);
            this.Name = "DodajZapisnik";
            this.Text = "Dodaj zapisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatumSudjenja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelZapisnik;
        private System.Windows.Forms.Button buttonDodaj;
    }
}