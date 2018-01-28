namespace DesktopAplikacija
{
    partial class Sud
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
            this.listBoxProcedure = new System.Windows.Forms.ListBox();
            this.textBoxImeSuda = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelProcedure = new System.Windows.Forms.Label();
            this.buttonOslobodi = new System.Windows.Forms.Button();
            this.buttonDodajRociste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.labelImeSudije = new System.Windows.Forms.Label();
            this.textBoxImeSudjije = new System.Windows.Forms.TextBox();
            this.textBoxNovoImeSuda = new System.Windows.Forms.TextBox();
            this.labelImeSuda = new System.Windows.Forms.Label();
            this.checkBoxPlaceno = new System.Windows.Forms.CheckBox();
            this.textBoxIznos = new System.Windows.Forms.TextBox();
            this.labelIznos = new System.Windows.Forms.Label();
            this.labelRokPlacanja = new System.Windows.Forms.Label();
            this.dateTimePickerRokPlacanja = new System.Windows.Forms.DateTimePicker();
            this.labelNazivKazne = new System.Windows.Forms.Label();
            this.textBoxNazivKazne = new System.Windows.Forms.TextBox();
            this.buttonKazna = new System.Windows.Forms.Button();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelDatumi = new System.Windows.Forms.Label();
            this.labelProcedureZap = new System.Windows.Forms.Label();
            this.labelZapisnik = new System.Windows.Forms.Label();
            this.richTextBoxZapisnik = new System.Windows.Forms.RichTextBox();
            this.listBoxZapisnici = new System.Windows.Forms.ListBox();
            this.listBoxProcedureZap = new System.Windows.Forms.ListBox();
            this.buttonTraziZap = new System.Windows.Forms.Button();
            this.textBoxImeSud = new System.Windows.Forms.TextBox();
            this.labelImeSud = new System.Windows.Forms.Label();
            this.richTextBoxOpt = new System.Windows.Forms.RichTextBox();
            this.labelOptuznica = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProcedure
            // 
            this.listBoxProcedure.FormattingEnabled = true;
            this.listBoxProcedure.Location = new System.Drawing.Point(30, 119);
            this.listBoxProcedure.Name = "listBoxProcedure";
            this.listBoxProcedure.Size = new System.Drawing.Size(256, 342);
            this.listBoxProcedure.TabIndex = 0;
            this.listBoxProcedure.SelectedIndexChanged += new System.EventHandler(this.listBoxProcedure_SelectedIndexChanged);
            // 
            // textBoxImeSuda
            // 
            this.textBoxImeSuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeSuda.Location = new System.Drawing.Point(29, 29);
            this.textBoxImeSuda.Name = "textBoxImeSuda";
            this.textBoxImeSuda.Size = new System.Drawing.Size(257, 23);
            this.textBoxImeSuda.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 496);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelOptuznica);
            this.tabPage1.Controls.Add(this.richTextBoxOpt);
            this.tabPage1.Controls.Add(this.labelProcedure);
            this.tabPage1.Controls.Add(this.buttonOslobodi);
            this.tabPage1.Controls.Add(this.buttonDodajRociste);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonIzmeni);
            this.tabPage1.Controls.Add(this.labelImeSudije);
            this.tabPage1.Controls.Add(this.textBoxImeSudjije);
            this.tabPage1.Controls.Add(this.textBoxNovoImeSuda);
            this.tabPage1.Controls.Add(this.labelImeSuda);
            this.tabPage1.Controls.Add(this.checkBoxPlaceno);
            this.tabPage1.Controls.Add(this.textBoxIznos);
            this.tabPage1.Controls.Add(this.labelIznos);
            this.tabPage1.Controls.Add(this.labelRokPlacanja);
            this.tabPage1.Controls.Add(this.dateTimePickerRokPlacanja);
            this.tabPage1.Controls.Add(this.labelNazivKazne);
            this.tabPage1.Controls.Add(this.textBoxNazivKazne);
            this.tabPage1.Controls.Add(this.buttonKazna);
            this.tabPage1.Controls.Add(this.buttonTrazi);
            this.tabPage1.Controls.Add(this.textBoxImeSuda);
            this.tabPage1.Controls.Add(this.listBoxProcedure);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelProcedure
            // 
            this.labelProcedure.AutoSize = true;
            this.labelProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcedure.Location = new System.Drawing.Point(26, 95);
            this.labelProcedure.Name = "labelProcedure";
            this.labelProcedure.Size = new System.Drawing.Size(74, 16);
            this.labelProcedure.TabIndex = 19;
            this.labelProcedure.Text = "Procedure:";
            // 
            // buttonOslobodi
            // 
            this.buttonOslobodi.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOslobodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOslobodi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOslobodi.Location = new System.Drawing.Point(550, 218);
            this.buttonOslobodi.Name = "buttonOslobodi";
            this.buttonOslobodi.Size = new System.Drawing.Size(85, 46);
            this.buttonOslobodi.TabIndex = 18;
            this.buttonOslobodi.Text = "Oslobodi";
            this.buttonOslobodi.UseVisualStyleBackColor = false;
            this.buttonOslobodi.Click += new System.EventHandler(this.buttonOslobodi_Click);
            // 
            // buttonDodajRociste
            // 
            this.buttonDodajRociste.BackColor = System.Drawing.Color.Gold;
            this.buttonDodajRociste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajRociste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDodajRociste.Location = new System.Drawing.Point(459, 218);
            this.buttonDodajRociste.Name = "buttonDodajRociste";
            this.buttonDodajRociste.Size = new System.Drawing.Size(85, 46);
            this.buttonDodajRociste.TabIndex = 17;
            this.buttonDodajRociste.Text = "Dodaj zapisnik";
            this.buttonDodajRociste.UseVisualStyleBackColor = false;
            this.buttonDodajRociste.Click += new System.EventHandler(this.buttonDodajRociste_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime suda:";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIzmeni.Location = new System.Drawing.Point(369, 218);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(85, 46);
            this.buttonIzmeni.TabIndex = 15;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // labelImeSudije
            // 
            this.labelImeSudije.AutoSize = true;
            this.labelImeSudije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeSudije.Location = new System.Drawing.Point(366, 58);
            this.labelImeSudije.Name = "labelImeSudije";
            this.labelImeSudije.Size = new System.Drawing.Size(72, 16);
            this.labelImeSudije.TabIndex = 14;
            this.labelImeSudije.Text = "Ime sudije:";
            // 
            // textBoxImeSudjije
            // 
            this.textBoxImeSudjije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeSudjije.Location = new System.Drawing.Point(369, 78);
            this.textBoxImeSudjije.Name = "textBoxImeSudjije";
            this.textBoxImeSudjije.Size = new System.Drawing.Size(266, 23);
            this.textBoxImeSudjije.TabIndex = 13;
            // 
            // textBoxNovoImeSuda
            // 
            this.textBoxNovoImeSuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovoImeSuda.Location = new System.Drawing.Point(369, 32);
            this.textBoxNovoImeSuda.Name = "textBoxNovoImeSuda";
            this.textBoxNovoImeSuda.Size = new System.Drawing.Size(266, 23);
            this.textBoxNovoImeSuda.TabIndex = 12;
            // 
            // labelImeSuda
            // 
            this.labelImeSuda.AutoSize = true;
            this.labelImeSuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeSuda.Location = new System.Drawing.Point(368, 13);
            this.labelImeSuda.Name = "labelImeSuda";
            this.labelImeSuda.Size = new System.Drawing.Size(66, 16);
            this.labelImeSuda.TabIndex = 11;
            this.labelImeSuda.Text = "Ime suda:";
            // 
            // checkBoxPlaceno
            // 
            this.checkBoxPlaceno.AutoSize = true;
            this.checkBoxPlaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPlaceno.Location = new System.Drawing.Point(369, 414);
            this.checkBoxPlaceno.Name = "checkBoxPlaceno";
            this.checkBoxPlaceno.Size = new System.Drawing.Size(78, 21);
            this.checkBoxPlaceno.TabIndex = 10;
            this.checkBoxPlaceno.Text = "Placeno";
            this.checkBoxPlaceno.UseVisualStyleBackColor = true;
            this.checkBoxPlaceno.Visible = false;
            // 
            // textBoxIznos
            // 
            this.textBoxIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIznos.Location = new System.Drawing.Point(369, 331);
            this.textBoxIznos.Name = "textBoxIznos";
            this.textBoxIznos.Size = new System.Drawing.Size(266, 23);
            this.textBoxIznos.TabIndex = 9;
            this.textBoxIznos.Visible = false;
            // 
            // labelIznos
            // 
            this.labelIznos.AutoSize = true;
            this.labelIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIznos.Location = new System.Drawing.Point(366, 312);
            this.labelIznos.Name = "labelIznos";
            this.labelIznos.Size = new System.Drawing.Size(114, 16);
            this.labelIznos.TabIndex = 8;
            this.labelIznos.Text = "Iznos za placanje:";
            this.labelIznos.Visible = false;
            // 
            // labelRokPlacanja
            // 
            this.labelRokPlacanja.AutoSize = true;
            this.labelRokPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRokPlacanja.Location = new System.Drawing.Point(366, 357);
            this.labelRokPlacanja.Name = "labelRokPlacanja";
            this.labelRokPlacanja.Size = new System.Drawing.Size(91, 16);
            this.labelRokPlacanja.TabIndex = 7;
            this.labelRokPlacanja.Text = "Rok placanja:";
            this.labelRokPlacanja.Visible = false;
            // 
            // dateTimePickerRokPlacanja
            // 
            this.dateTimePickerRokPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRokPlacanja.Location = new System.Drawing.Point(369, 385);
            this.dateTimePickerRokPlacanja.Name = "dateTimePickerRokPlacanja";
            this.dateTimePickerRokPlacanja.Size = new System.Drawing.Size(266, 23);
            this.dateTimePickerRokPlacanja.TabIndex = 6;
            this.dateTimePickerRokPlacanja.Visible = false;
            // 
            // labelNazivKazne
            // 
            this.labelNazivKazne.AutoSize = true;
            this.labelNazivKazne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivKazne.Location = new System.Drawing.Point(366, 267);
            this.labelNazivKazne.Name = "labelNazivKazne";
            this.labelNazivKazne.Size = new System.Drawing.Size(84, 16);
            this.labelNazivKazne.TabIndex = 5;
            this.labelNazivKazne.Text = "Naziv kazne:";
            this.labelNazivKazne.Visible = false;
            // 
            // textBoxNazivKazne
            // 
            this.textBoxNazivKazne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazivKazne.Location = new System.Drawing.Point(369, 286);
            this.textBoxNazivKazne.Name = "textBoxNazivKazne";
            this.textBoxNazivKazne.Size = new System.Drawing.Size(266, 23);
            this.textBoxNazivKazne.TabIndex = 4;
            this.textBoxNazivKazne.Visible = false;
            // 
            // buttonKazna
            // 
            this.buttonKazna.BackColor = System.Drawing.Color.Red;
            this.buttonKazna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKazna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKazna.Location = new System.Drawing.Point(544, 414);
            this.buttonKazna.Name = "buttonKazna";
            this.buttonKazna.Size = new System.Drawing.Size(91, 47);
            this.buttonKazna.TabIndex = 3;
            this.buttonKazna.Text = "Kazna";
            this.buttonKazna.UseVisualStyleBackColor = false;
            this.buttonKazna.Visible = false;
            this.buttonKazna.Click += new System.EventHandler(this.buttonKazna_Click);
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.BackColor = System.Drawing.Color.Gold;
            this.buttonTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrazi.Location = new System.Drawing.Point(176, 58);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(110, 43);
            this.buttonTrazi.TabIndex = 2;
            this.buttonTrazi.Text = "Trazi";
            this.buttonTrazi.UseVisualStyleBackColor = false;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelDatumi);
            this.tabPage2.Controls.Add(this.labelProcedureZap);
            this.tabPage2.Controls.Add(this.labelZapisnik);
            this.tabPage2.Controls.Add(this.richTextBoxZapisnik);
            this.tabPage2.Controls.Add(this.listBoxZapisnici);
            this.tabPage2.Controls.Add(this.listBoxProcedureZap);
            this.tabPage2.Controls.Add(this.buttonTraziZap);
            this.tabPage2.Controls.Add(this.textBoxImeSud);
            this.tabPage2.Controls.Add(this.labelImeSud);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zapisnici";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDatumi
            // 
            this.labelDatumi.AutoSize = true;
            this.labelDatumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumi.Location = new System.Drawing.Point(222, 82);
            this.labelDatumi.Name = "labelDatumi";
            this.labelDatumi.Size = new System.Drawing.Size(113, 17);
            this.labelDatumi.TabIndex = 8;
            this.labelDatumi.Text = "Datumi sudjenja:";
            // 
            // labelProcedureZap
            // 
            this.labelProcedureZap.AutoSize = true;
            this.labelProcedureZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcedureZap.Location = new System.Drawing.Point(25, 82);
            this.labelProcedureZap.Name = "labelProcedureZap";
            this.labelProcedureZap.Size = new System.Drawing.Size(78, 17);
            this.labelProcedureZap.TabIndex = 7;
            this.labelProcedureZap.Text = "Procedure:";
            // 
            // labelZapisnik
            // 
            this.labelZapisnik.AutoSize = true;
            this.labelZapisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZapisnik.Location = new System.Drawing.Point(388, 82);
            this.labelZapisnik.Name = "labelZapisnik";
            this.labelZapisnik.Size = new System.Drawing.Size(65, 17);
            this.labelZapisnik.TabIndex = 6;
            this.labelZapisnik.Text = "Zapisnik:";
            // 
            // richTextBoxZapisnik
            // 
            this.richTextBoxZapisnik.Location = new System.Drawing.Point(391, 104);
            this.richTextBoxZapisnik.Name = "richTextBoxZapisnik";
            this.richTextBoxZapisnik.Size = new System.Drawing.Size(324, 342);
            this.richTextBoxZapisnik.TabIndex = 5;
            this.richTextBoxZapisnik.Text = "";
            // 
            // listBoxZapisnici
            // 
            this.listBoxZapisnici.FormattingEnabled = true;
            this.listBoxZapisnici.Location = new System.Drawing.Point(225, 104);
            this.listBoxZapisnici.Name = "listBoxZapisnici";
            this.listBoxZapisnici.Size = new System.Drawing.Size(134, 342);
            this.listBoxZapisnici.TabIndex = 4;
            this.listBoxZapisnici.SelectedIndexChanged += new System.EventHandler(this.listBoxZapisnici_SelectedIndexChanged);
            // 
            // listBoxProcedureZap
            // 
            this.listBoxProcedureZap.FormattingEnabled = true;
            this.listBoxProcedureZap.Location = new System.Drawing.Point(28, 102);
            this.listBoxProcedureZap.Name = "listBoxProcedureZap";
            this.listBoxProcedureZap.Size = new System.Drawing.Size(170, 342);
            this.listBoxProcedureZap.TabIndex = 3;
            this.listBoxProcedureZap.SelectedIndexChanged += new System.EventHandler(this.listBoxProcedureZap_SelectedIndexChanged);
            // 
            // buttonTraziZap
            // 
            this.buttonTraziZap.BackColor = System.Drawing.Color.Gold;
            this.buttonTraziZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraziZap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTraziZap.Location = new System.Drawing.Point(109, 52);
            this.buttonTraziZap.Name = "buttonTraziZap";
            this.buttonTraziZap.Size = new System.Drawing.Size(89, 34);
            this.buttonTraziZap.TabIndex = 2;
            this.buttonTraziZap.Text = "Trazi";
            this.buttonTraziZap.UseVisualStyleBackColor = false;
            this.buttonTraziZap.Click += new System.EventHandler(this.buttonTraziZap_Click);
            // 
            // textBoxImeSud
            // 
            this.textBoxImeSud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeSud.Location = new System.Drawing.Point(28, 23);
            this.textBoxImeSud.Name = "textBoxImeSud";
            this.textBoxImeSud.Size = new System.Drawing.Size(170, 23);
            this.textBoxImeSud.TabIndex = 1;
            // 
            // labelImeSud
            // 
            this.labelImeSud.AutoSize = true;
            this.labelImeSud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeSud.Location = new System.Drawing.Point(25, 3);
            this.labelImeSud.Name = "labelImeSud";
            this.labelImeSud.Size = new System.Drawing.Size(69, 17);
            this.labelImeSud.TabIndex = 0;
            this.labelImeSud.Text = "Ime suda:";
            // 
            // richTextBoxOpt
            // 
            this.richTextBoxOpt.Location = new System.Drawing.Point(369, 125);
            this.richTextBoxOpt.Name = "richTextBoxOpt";
            this.richTextBoxOpt.Size = new System.Drawing.Size(266, 87);
            this.richTextBoxOpt.TabIndex = 20;
            this.richTextBoxOpt.Text = "";
            // 
            // labelOptuznica
            // 
            this.labelOptuznica.AutoSize = true;
            this.labelOptuznica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptuznica.Location = new System.Drawing.Point(366, 104);
            this.labelOptuznica.Name = "labelOptuznica";
            this.labelOptuznica.Size = new System.Drawing.Size(76, 17);
            this.labelOptuznica.TabIndex = 21;
            this.labelOptuznica.Text = "Optuznica:";
            // 
            // Sud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sud";
            this.Text = "Sud";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcedure;
        private System.Windows.Forms.TextBox textBoxImeSuda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelRokPlacanja;
        private System.Windows.Forms.DateTimePicker dateTimePickerRokPlacanja;
        private System.Windows.Forms.Label labelNazivKazne;
        private System.Windows.Forms.TextBox textBoxNazivKazne;
        private System.Windows.Forms.Button buttonKazna;
        private System.Windows.Forms.TextBox textBoxIznos;
        private System.Windows.Forms.Label labelIznos;
        private System.Windows.Forms.CheckBox checkBoxPlaceno;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Label labelImeSudije;
        private System.Windows.Forms.TextBox textBoxImeSudjije;
        private System.Windows.Forms.TextBox textBoxNovoImeSuda;
        private System.Windows.Forms.Label labelImeSuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodajRociste;
        private System.Windows.Forms.Button buttonOslobodi;
        private System.Windows.Forms.Label labelZapisnik;
        private System.Windows.Forms.RichTextBox richTextBoxZapisnik;
        private System.Windows.Forms.ListBox listBoxZapisnici;
        private System.Windows.Forms.ListBox listBoxProcedureZap;
        private System.Windows.Forms.Button buttonTraziZap;
        private System.Windows.Forms.TextBox textBoxImeSud;
        private System.Windows.Forms.Label labelImeSud;
        private System.Windows.Forms.Label labelProcedure;
        private System.Windows.Forms.Label labelDatumi;
        private System.Windows.Forms.Label labelProcedureZap;
        private System.Windows.Forms.Label labelOptuznica;
        private System.Windows.Forms.RichTextBox richTextBoxOpt;
    }
}