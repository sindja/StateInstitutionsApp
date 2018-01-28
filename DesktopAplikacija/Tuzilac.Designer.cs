namespace DesktopAplikacija
{
    partial class Tuzilac
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
            this.listBoxPrekrsaji = new System.Windows.Forms.ListBox();
            this.listBoxPrivredniPrestupi = new System.Windows.Forms.ListBox();
            this.listBoxKrivicnaDela = new System.Windows.Forms.ListBox();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.richTextBoxOptuznica = new System.Windows.Forms.RichTextBox();
            this.buttonPokreniProceduru = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUnos = new System.Windows.Forms.TabPage();
            this.labelOptuznica = new System.Windows.Forms.Label();
            this.labelKrivicnaDela = new System.Windows.Forms.Label();
            this.labelPrivredniPrestupi = new System.Windows.Forms.Label();
            this.labelPrekrsaji = new System.Windows.Forms.Label();
            this.labelImeSudije = new System.Windows.Forms.Label();
            this.textBoxImeSudije = new System.Windows.Forms.TextBox();
            this.textBoxImeSud = new System.Windows.Forms.TextBox();
            this.labelImeSud = new System.Windows.Forms.Label();
            this.labelDatumPrestupa = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelOpisPrestupa = new System.Windows.Forms.Label();
            this.labelAdresaPrestupa = new System.Windows.Forms.Label();
            this.richTextBoxOpisPrestupa = new System.Windows.Forms.RichTextBox();
            this.textBoxAdresaPrestupa = new System.Windows.Forms.TextBox();
            this.tabPagePretraga = new System.Windows.Forms.TabPage();
            this.labelOptuznicaIzmeni = new System.Windows.Forms.Label();
            this.labelProcedure = new System.Windows.Forms.Label();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.richTextBoxPromenaOptuznice = new System.Windows.Forms.RichTextBox();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.listBoxProcedure = new System.Windows.Forms.ListBox();
            this.labelImeSuda = new System.Windows.Forms.Label();
            this.textBoxImeSuda = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageUnos.SuspendLayout();
            this.tabPagePretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPrekrsaji
            // 
            this.listBoxPrekrsaji.FormattingEnabled = true;
            this.listBoxPrekrsaji.Location = new System.Drawing.Point(15, 23);
            this.listBoxPrekrsaji.Name = "listBoxPrekrsaji";
            this.listBoxPrekrsaji.Size = new System.Drawing.Size(271, 121);
            this.listBoxPrekrsaji.TabIndex = 0;
            this.listBoxPrekrsaji.SelectedIndexChanged += new System.EventHandler(this.listBoxPrekrsaji_SelectedIndexChanged);
            // 
            // listBoxPrivredniPrestupi
            // 
            this.listBoxPrivredniPrestupi.FormattingEnabled = true;
            this.listBoxPrivredniPrestupi.Location = new System.Drawing.Point(15, 173);
            this.listBoxPrivredniPrestupi.Name = "listBoxPrivredniPrestupi";
            this.listBoxPrivredniPrestupi.Size = new System.Drawing.Size(271, 121);
            this.listBoxPrivredniPrestupi.TabIndex = 1;
            this.listBoxPrivredniPrestupi.SelectedIndexChanged += new System.EventHandler(this.listBoxPrivredniPrestupi_SelectedIndexChanged);
            // 
            // listBoxKrivicnaDela
            // 
            this.listBoxKrivicnaDela.FormattingEnabled = true;
            this.listBoxKrivicnaDela.Location = new System.Drawing.Point(15, 327);
            this.listBoxKrivicnaDela.Name = "listBoxKrivicnaDela";
            this.listBoxKrivicnaDela.Size = new System.Drawing.Size(271, 121);
            this.listBoxKrivicnaDela.TabIndex = 2;
            this.listBoxKrivicnaDela.SelectedIndexChanged += new System.EventHandler(this.listBoxKrivicnaDela_SelectedIndexChanged);
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOtvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtvori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOtvori.Location = new System.Drawing.Point(172, 450);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(114, 49);
            this.buttonOtvori.TabIndex = 3;
            this.buttonOtvori.Text = "Otvori";
            this.buttonOtvori.UseVisualStyleBackColor = false;
            this.buttonOtvori.Click += new System.EventHandler(this.buttonOtvori_Click);
            // 
            // richTextBoxOptuznica
            // 
            this.richTextBoxOptuznica.Location = new System.Drawing.Point(333, 327);
            this.richTextBoxOptuznica.Name = "richTextBoxOptuznica";
            this.richTextBoxOptuznica.Size = new System.Drawing.Size(444, 117);
            this.richTextBoxOptuznica.TabIndex = 4;
            this.richTextBoxOptuznica.Text = "";
            // 
            // buttonPokreniProceduru
            // 
            this.buttonPokreniProceduru.BackColor = System.Drawing.Color.Red;
            this.buttonPokreniProceduru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPokreniProceduru.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPokreniProceduru.Location = new System.Drawing.Point(596, 450);
            this.buttonPokreniProceduru.Name = "buttonPokreniProceduru";
            this.buttonPokreniProceduru.Size = new System.Drawing.Size(181, 49);
            this.buttonPokreniProceduru.TabIndex = 5;
            this.buttonPokreniProceduru.Text = "Pokreni proceduru";
            this.buttonPokreniProceduru.UseVisualStyleBackColor = false;
            this.buttonPokreniProceduru.Click += new System.EventHandler(this.buttonPokreniProceduru_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUnos);
            this.tabControl1.Controls.Add(this.tabPagePretraga);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 533);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageUnos
            // 
            this.tabPageUnos.Controls.Add(this.labelOptuznica);
            this.tabPageUnos.Controls.Add(this.labelKrivicnaDela);
            this.tabPageUnos.Controls.Add(this.labelPrivredniPrestupi);
            this.tabPageUnos.Controls.Add(this.labelPrekrsaji);
            this.tabPageUnos.Controls.Add(this.labelImeSudije);
            this.tabPageUnos.Controls.Add(this.textBoxImeSudije);
            this.tabPageUnos.Controls.Add(this.textBoxImeSud);
            this.tabPageUnos.Controls.Add(this.labelImeSud);
            this.tabPageUnos.Controls.Add(this.labelDatumPrestupa);
            this.tabPageUnos.Controls.Add(this.dateTimePicker1);
            this.tabPageUnos.Controls.Add(this.labelOpisPrestupa);
            this.tabPageUnos.Controls.Add(this.labelAdresaPrestupa);
            this.tabPageUnos.Controls.Add(this.richTextBoxOpisPrestupa);
            this.tabPageUnos.Controls.Add(this.textBoxAdresaPrestupa);
            this.tabPageUnos.Controls.Add(this.listBoxPrekrsaji);
            this.tabPageUnos.Controls.Add(this.buttonPokreniProceduru);
            this.tabPageUnos.Controls.Add(this.listBoxPrivredniPrestupi);
            this.tabPageUnos.Controls.Add(this.buttonOtvori);
            this.tabPageUnos.Controls.Add(this.richTextBoxOptuznica);
            this.tabPageUnos.Controls.Add(this.listBoxKrivicnaDela);
            this.tabPageUnos.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnos.Name = "tabPageUnos";
            this.tabPageUnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnos.Size = new System.Drawing.Size(840, 507);
            this.tabPageUnos.TabIndex = 0;
            this.tabPageUnos.Text = "Pokretanje";
            this.tabPageUnos.UseVisualStyleBackColor = true;
            // 
            // labelOptuznica
            // 
            this.labelOptuznica.AutoSize = true;
            this.labelOptuznica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptuznica.Location = new System.Drawing.Point(330, 298);
            this.labelOptuznica.Name = "labelOptuznica";
            this.labelOptuznica.Size = new System.Drawing.Size(76, 17);
            this.labelOptuznica.TabIndex = 20;
            this.labelOptuznica.Text = "Optužnica:";
            // 
            // labelKrivicnaDela
            // 
            this.labelKrivicnaDela.AutoSize = true;
            this.labelKrivicnaDela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKrivicnaDela.Location = new System.Drawing.Point(12, 307);
            this.labelKrivicnaDela.Name = "labelKrivicnaDela";
            this.labelKrivicnaDela.Size = new System.Drawing.Size(93, 17);
            this.labelKrivicnaDela.TabIndex = 19;
            this.labelKrivicnaDela.Text = "Krivična dela:";
            // 
            // labelPrivredniPrestupi
            // 
            this.labelPrivredniPrestupi.AutoSize = true;
            this.labelPrivredniPrestupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivredniPrestupi.Location = new System.Drawing.Point(12, 154);
            this.labelPrivredniPrestupi.Name = "labelPrivredniPrestupi";
            this.labelPrivredniPrestupi.Size = new System.Drawing.Size(123, 17);
            this.labelPrivredniPrestupi.TabIndex = 18;
            this.labelPrivredniPrestupi.Text = "Privredni prestupi:";
            // 
            // labelPrekrsaji
            // 
            this.labelPrekrsaji.AutoSize = true;
            this.labelPrekrsaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrekrsaji.Location = new System.Drawing.Point(12, 3);
            this.labelPrekrsaji.Name = "labelPrekrsaji";
            this.labelPrekrsaji.Size = new System.Drawing.Size(67, 17);
            this.labelPrekrsaji.TabIndex = 17;
            this.labelPrekrsaji.Text = "Prekršaji:";
            // 
            // labelImeSudije
            // 
            this.labelImeSudije.AutoSize = true;
            this.labelImeSudije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeSudije.Location = new System.Drawing.Point(556, 241);
            this.labelImeSudije.Name = "labelImeSudije";
            this.labelImeSudije.Size = new System.Drawing.Size(75, 17);
            this.labelImeSudije.TabIndex = 16;
            this.labelImeSudije.Text = "Ime sudije:";
            // 
            // textBoxImeSudije
            // 
            this.textBoxImeSudije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeSudije.Location = new System.Drawing.Point(559, 270);
            this.textBoxImeSudije.Name = "textBoxImeSudije";
            this.textBoxImeSudije.Size = new System.Drawing.Size(218, 24);
            this.textBoxImeSudije.TabIndex = 15;
            // 
            // textBoxImeSud
            // 
            this.textBoxImeSud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeSud.Location = new System.Drawing.Point(333, 270);
            this.textBoxImeSud.Name = "textBoxImeSud";
            this.textBoxImeSud.Size = new System.Drawing.Size(203, 24);
            this.textBoxImeSud.TabIndex = 14;
            // 
            // labelImeSud
            // 
            this.labelImeSud.AutoSize = true;
            this.labelImeSud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeSud.Location = new System.Drawing.Point(330, 241);
            this.labelImeSud.Name = "labelImeSud";
            this.labelImeSud.Size = new System.Drawing.Size(69, 17);
            this.labelImeSud.TabIndex = 13;
            this.labelImeSud.Text = "Ime suda:";
            // 
            // labelDatumPrestupa
            // 
            this.labelDatumPrestupa.AutoSize = true;
            this.labelDatumPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumPrestupa.Location = new System.Drawing.Point(330, 174);
            this.labelDatumPrestupa.Name = "labelDatumPrestupa";
            this.labelDatumPrestupa.Size = new System.Drawing.Size(109, 17);
            this.labelDatumPrestupa.TabIndex = 11;
            this.labelDatumPrestupa.Text = "Datum prestupa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // labelOpisPrestupa
            // 
            this.labelOpisPrestupa.AutoSize = true;
            this.labelOpisPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisPrestupa.Location = new System.Drawing.Point(330, 50);
            this.labelOpisPrestupa.Name = "labelOpisPrestupa";
            this.labelOpisPrestupa.Size = new System.Drawing.Size(101, 17);
            this.labelOpisPrestupa.TabIndex = 9;
            this.labelOpisPrestupa.Text = "Opis prestupa:";
            // 
            // labelAdresaPrestupa
            // 
            this.labelAdresaPrestupa.AutoSize = true;
            this.labelAdresaPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresaPrestupa.Location = new System.Drawing.Point(330, 3);
            this.labelAdresaPrestupa.Name = "labelAdresaPrestupa";
            this.labelAdresaPrestupa.Size = new System.Drawing.Size(117, 17);
            this.labelAdresaPrestupa.TabIndex = 8;
            this.labelAdresaPrestupa.Text = "Adresa prestupa:";
            // 
            // richTextBoxOpisPrestupa
            // 
            this.richTextBoxOpisPrestupa.Enabled = false;
            this.richTextBoxOpisPrestupa.Location = new System.Drawing.Point(333, 75);
            this.richTextBoxOpisPrestupa.Name = "richTextBoxOpisPrestupa";
            this.richTextBoxOpisPrestupa.Size = new System.Drawing.Size(355, 96);
            this.richTextBoxOpisPrestupa.TabIndex = 7;
            this.richTextBoxOpisPrestupa.Text = "";
            // 
            // textBoxAdresaPrestupa
            // 
            this.textBoxAdresaPrestupa.Enabled = false;
            this.textBoxAdresaPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresaPrestupa.Location = new System.Drawing.Point(333, 23);
            this.textBoxAdresaPrestupa.Name = "textBoxAdresaPrestupa";
            this.textBoxAdresaPrestupa.Size = new System.Drawing.Size(355, 24);
            this.textBoxAdresaPrestupa.TabIndex = 6;
            // 
            // tabPagePretraga
            // 
            this.tabPagePretraga.Controls.Add(this.labelOptuznicaIzmeni);
            this.tabPagePretraga.Controls.Add(this.labelProcedure);
            this.tabPagePretraga.Controls.Add(this.buttonIzmeni);
            this.tabPagePretraga.Controls.Add(this.richTextBoxPromenaOptuznice);
            this.tabPagePretraga.Controls.Add(this.buttonTrazi);
            this.tabPagePretraga.Controls.Add(this.listBoxProcedure);
            this.tabPagePretraga.Controls.Add(this.labelImeSuda);
            this.tabPagePretraga.Controls.Add(this.textBoxImeSuda);
            this.tabPagePretraga.Location = new System.Drawing.Point(4, 22);
            this.tabPagePretraga.Name = "tabPagePretraga";
            this.tabPagePretraga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePretraga.Size = new System.Drawing.Size(840, 507);
            this.tabPagePretraga.TabIndex = 1;
            this.tabPagePretraga.Text = "Pretraga";
            this.tabPagePretraga.UseVisualStyleBackColor = true;
            // 
            // labelOptuznicaIzmeni
            // 
            this.labelOptuznicaIzmeni.AutoSize = true;
            this.labelOptuznicaIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptuznicaIzmeni.Location = new System.Drawing.Point(284, 108);
            this.labelOptuznicaIzmeni.Name = "labelOptuznicaIzmeni";
            this.labelOptuznicaIzmeni.Size = new System.Drawing.Size(76, 17);
            this.labelOptuznicaIzmeni.TabIndex = 7;
            this.labelOptuznicaIzmeni.Text = "Optuznica:";
            // 
            // labelProcedure
            // 
            this.labelProcedure.AutoSize = true;
            this.labelProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcedure.Location = new System.Drawing.Point(30, 108);
            this.labelProcedure.Name = "labelProcedure";
            this.labelProcedure.Size = new System.Drawing.Size(78, 17);
            this.labelProcedure.TabIndex = 6;
            this.labelProcedure.Text = "Procedure:";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIzmeni.Location = new System.Drawing.Point(584, 257);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(109, 38);
            this.buttonIzmeni.TabIndex = 5;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // richTextBoxPromenaOptuznice
            // 
            this.richTextBoxPromenaOptuznice.Location = new System.Drawing.Point(287, 128);
            this.richTextBoxPromenaOptuznice.Name = "richTextBoxPromenaOptuznice";
            this.richTextBoxPromenaOptuznice.Size = new System.Drawing.Size(406, 96);
            this.richTextBoxPromenaOptuznice.TabIndex = 4;
            this.richTextBoxPromenaOptuznice.Text = "";
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.BackColor = System.Drawing.Color.Gold;
            this.buttonTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrazi.ForeColor = System.Drawing.Color.Snow;
            this.buttonTrazi.Location = new System.Drawing.Point(126, 64);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(109, 38);
            this.buttonTrazi.TabIndex = 3;
            this.buttonTrazi.Text = "Trazi";
            this.buttonTrazi.UseVisualStyleBackColor = false;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // listBoxProcedure
            // 
            this.listBoxProcedure.FormattingEnabled = true;
            this.listBoxProcedure.Location = new System.Drawing.Point(33, 128);
            this.listBoxProcedure.Name = "listBoxProcedure";
            this.listBoxProcedure.Size = new System.Drawing.Size(202, 342);
            this.listBoxProcedure.TabIndex = 2;
            this.listBoxProcedure.SelectedIndexChanged += new System.EventHandler(this.listBoxProcedure_SelectedIndexChanged);
            // 
            // labelImeSuda
            // 
            this.labelImeSuda.AutoSize = true;
            this.labelImeSuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeSuda.Location = new System.Drawing.Point(30, 14);
            this.labelImeSuda.Name = "labelImeSuda";
            this.labelImeSuda.Size = new System.Drawing.Size(69, 17);
            this.labelImeSuda.TabIndex = 1;
            this.labelImeSuda.Text = "Ime suda:";
            // 
            // textBoxImeSuda
            // 
            this.textBoxImeSuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeSuda.Location = new System.Drawing.Point(33, 34);
            this.textBoxImeSuda.Name = "textBoxImeSuda";
            this.textBoxImeSuda.Size = new System.Drawing.Size(202, 24);
            this.textBoxImeSuda.TabIndex = 0;
            // 
            // Tuzilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tuzilac";
            this.Text = "Tuzilac";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUnos.ResumeLayout(false);
            this.tabPageUnos.PerformLayout();
            this.tabPagePretraga.ResumeLayout(false);
            this.tabPagePretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPrekrsaji;
        private System.Windows.Forms.ListBox listBoxPrivredniPrestupi;
        private System.Windows.Forms.ListBox listBoxKrivicnaDela;
        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.RichTextBox richTextBoxOptuznica;
        private System.Windows.Forms.Button buttonPokreniProceduru;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUnos;
        private System.Windows.Forms.TabPage tabPagePretraga;
        private System.Windows.Forms.RichTextBox richTextBoxOpisPrestupa;
        private System.Windows.Forms.TextBox textBoxAdresaPrestupa;
        private System.Windows.Forms.Label labelOpisPrestupa;
        private System.Windows.Forms.Label labelAdresaPrestupa;
        private System.Windows.Forms.Label labelDatumPrestupa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelImeSuda;
        private System.Windows.Forms.TextBox textBoxImeSuda;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.RichTextBox richTextBoxPromenaOptuznice;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.ListBox listBoxProcedure;
        private System.Windows.Forms.Label labelImeSudije;
        private System.Windows.Forms.TextBox textBoxImeSudije;
        private System.Windows.Forms.TextBox textBoxImeSud;
        private System.Windows.Forms.Label labelImeSud;
        private System.Windows.Forms.Label labelOptuznica;
        private System.Windows.Forms.Label labelKrivicnaDela;
        private System.Windows.Forms.Label labelPrivredniPrestupi;
        private System.Windows.Forms.Label labelPrekrsaji;
        private System.Windows.Forms.Label labelOptuznicaIzmeni;
        private System.Windows.Forms.Label labelProcedure;
    }
}