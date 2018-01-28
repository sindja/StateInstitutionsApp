namespace DesktopAplikacija
{
    partial class DodavanjePrestupa
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDodaj = new System.Windows.Forms.TabPage();
            this.labelNazivPrestupa = new System.Windows.Forms.Label();
            this.textBoxNazivPrestupa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFizickoLice = new System.Windows.Forms.RadioButton();
            this.radioButtonPravnoLice = new System.Windows.Forms.RadioButton();
            this.groupBoxKategorijaPrestupa = new System.Windows.Forms.GroupBox();
            this.radioButtonPrekrsaj = new System.Windows.Forms.RadioButton();
            this.radioButtonPrivredniPrekrsaj = new System.Windows.Forms.RadioButton();
            this.radioButtonKrivicnoDelo = new System.Windows.Forms.RadioButton();
            this.buttonSacuvajPrestup = new System.Windows.Forms.Button();
            this.labelPocinilacId = new System.Windows.Forms.Label();
            this.labelDatumPrestupa = new System.Windows.Forms.Label();
            this.dateTimePickerDatumPrestupa = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxOpisPrestupa = new System.Windows.Forms.RichTextBox();
            this.labelOpstinaPrestupa = new System.Windows.Forms.Label();
            this.labelAdresaPrestupa = new System.Windows.Forms.Label();
            this.textBoxOpstina = new System.Windows.Forms.TextBox();
            this.textBoxAdresaPrestupa = new System.Windows.Forms.TextBox();
            this.labelOpisPrestupa = new System.Windows.Forms.Label();
            this.textBoxPocinilacId = new System.Windows.Forms.TextBox();
            this.tabPagePrikaz = new System.Windows.Forms.TabPage();
            this.labelNeplaćene = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIDPočinioca = new System.Windows.Forms.Label();
            this.NeplaceneKazne = new System.Windows.Forms.ListBox();
            this.Prestupi = new System.Windows.Forms.ListBox();
            this.labelTelefonP = new System.Windows.Forms.Label();
            this.textBoxTelefonP = new System.Windows.Forms.TextBox();
            this.textBoxAdresaP = new System.Windows.Forms.TextBox();
            this.labelAdresaP = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelnacionaklnost = new System.Windows.Forms.Label();
            this.textBoxNacionalnost = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDatumRodjenj = new System.Windows.Forms.Label();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.groupBoxEntitet = new System.Windows.Forms.GroupBox();
            this.radioButtonPravnoL = new System.Windows.Forms.RadioButton();
            this.radioButtonFizickoL = new System.Windows.Forms.RadioButton();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPageDodaj.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxKategorijaPrestupa.SuspendLayout();
            this.tabPagePrikaz.SuspendLayout();
            this.groupBoxEntitet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDodaj);
            this.tabControl1.Controls.Add(this.tabPagePrikaz);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 446);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDodaj
            // 
            this.tabPageDodaj.Controls.Add(this.labelNazivPrestupa);
            this.tabPageDodaj.Controls.Add(this.textBoxNazivPrestupa);
            this.tabPageDodaj.Controls.Add(this.groupBox1);
            this.tabPageDodaj.Controls.Add(this.groupBoxKategorijaPrestupa);
            this.tabPageDodaj.Controls.Add(this.buttonSacuvajPrestup);
            this.tabPageDodaj.Controls.Add(this.labelPocinilacId);
            this.tabPageDodaj.Controls.Add(this.labelDatumPrestupa);
            this.tabPageDodaj.Controls.Add(this.dateTimePickerDatumPrestupa);
            this.tabPageDodaj.Controls.Add(this.richTextBoxOpisPrestupa);
            this.tabPageDodaj.Controls.Add(this.labelOpstinaPrestupa);
            this.tabPageDodaj.Controls.Add(this.labelAdresaPrestupa);
            this.tabPageDodaj.Controls.Add(this.textBoxOpstina);
            this.tabPageDodaj.Controls.Add(this.textBoxAdresaPrestupa);
            this.tabPageDodaj.Controls.Add(this.labelOpisPrestupa);
            this.tabPageDodaj.Controls.Add(this.textBoxPocinilacId);
            this.tabPageDodaj.Location = new System.Drawing.Point(4, 22);
            this.tabPageDodaj.Name = "tabPageDodaj";
            this.tabPageDodaj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDodaj.Size = new System.Drawing.Size(740, 420);
            this.tabPageDodaj.TabIndex = 0;
            this.tabPageDodaj.Text = "Dodaj";
            this.tabPageDodaj.UseVisualStyleBackColor = true;
            // 
            // labelNazivPrestupa
            // 
            this.labelNazivPrestupa.AutoSize = true;
            this.labelNazivPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivPrestupa.Location = new System.Drawing.Point(35, 11);
            this.labelNazivPrestupa.Name = "labelNazivPrestupa";
            this.labelNazivPrestupa.Size = new System.Drawing.Size(116, 16);
            this.labelNazivPrestupa.TabIndex = 20;
            this.labelNazivPrestupa.Text = "Naziv prestupa:";
            // 
            // textBoxNazivPrestupa
            // 
            this.textBoxNazivPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazivPrestupa.Location = new System.Drawing.Point(38, 30);
            this.textBoxNazivPrestupa.Name = "textBoxNazivPrestupa";
            this.textBoxNazivPrestupa.Size = new System.Drawing.Size(223, 24);
            this.textBoxNazivPrestupa.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFizickoLice);
            this.groupBox1.Controls.Add(this.radioButtonPravnoLice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entitet";
            // 
            // radioButtonFizickoLice
            // 
            this.radioButtonFizickoLice.AutoSize = true;
            this.radioButtonFizickoLice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFizickoLice.Location = new System.Drawing.Point(0, 19);
            this.radioButtonFizickoLice.Name = "radioButtonFizickoLice";
            this.radioButtonFizickoLice.Size = new System.Drawing.Size(112, 22);
            this.radioButtonFizickoLice.TabIndex = 10;
            this.radioButtonFizickoLice.TabStop = true;
            this.radioButtonFizickoLice.Text = "Fizičko lice";
            this.radioButtonFizickoLice.UseVisualStyleBackColor = true;
            // 
            // radioButtonPravnoLice
            // 
            this.radioButtonPravnoLice.AutoSize = true;
            this.radioButtonPravnoLice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPravnoLice.Location = new System.Drawing.Point(146, 18);
            this.radioButtonPravnoLice.Name = "radioButtonPravnoLice";
            this.radioButtonPravnoLice.Size = new System.Drawing.Size(110, 22);
            this.radioButtonPravnoLice.TabIndex = 11;
            this.radioButtonPravnoLice.TabStop = true;
            this.radioButtonPravnoLice.Text = "Pravno lice";
            this.radioButtonPravnoLice.UseVisualStyleBackColor = true;
            // 
            // groupBoxKategorijaPrestupa
            // 
            this.groupBoxKategorijaPrestupa.Controls.Add(this.radioButtonPrekrsaj);
            this.groupBoxKategorijaPrestupa.Controls.Add(this.radioButtonPrivredniPrekrsaj);
            this.groupBoxKategorijaPrestupa.Controls.Add(this.radioButtonKrivicnoDelo);
            this.groupBoxKategorijaPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKategorijaPrestupa.Location = new System.Drawing.Point(38, 246);
            this.groupBoxKategorijaPrestupa.Name = "groupBoxKategorijaPrestupa";
            this.groupBoxKategorijaPrestupa.Size = new System.Drawing.Size(227, 111);
            this.groupBoxKategorijaPrestupa.TabIndex = 17;
            this.groupBoxKategorijaPrestupa.TabStop = false;
            this.groupBoxKategorijaPrestupa.Text = "Kategorija prestupa";
            // 
            // radioButtonPrekrsaj
            // 
            this.radioButtonPrekrsaj.AutoSize = true;
            this.radioButtonPrekrsaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrekrsaj.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPrekrsaj.Name = "radioButtonPrekrsaj";
            this.radioButtonPrekrsaj.Size = new System.Drawing.Size(89, 22);
            this.radioButtonPrekrsaj.TabIndex = 12;
            this.radioButtonPrekrsaj.TabStop = true;
            this.radioButtonPrekrsaj.Text = "Prekršaj";
            this.radioButtonPrekrsaj.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrivredniPrekrsaj
            // 
            this.radioButtonPrivredniPrekrsaj.AutoSize = true;
            this.radioButtonPrivredniPrekrsaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrivredniPrekrsaj.Location = new System.Drawing.Point(6, 52);
            this.radioButtonPrivredniPrekrsaj.Name = "radioButtonPrivredniPrekrsaj";
            this.radioButtonPrivredniPrekrsaj.Size = new System.Drawing.Size(158, 22);
            this.radioButtonPrivredniPrekrsaj.TabIndex = 13;
            this.radioButtonPrivredniPrekrsaj.TabStop = true;
            this.radioButtonPrivredniPrekrsaj.Text = "Privredni prekršaj";
            this.radioButtonPrivredniPrekrsaj.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrivicnoDelo
            // 
            this.radioButtonKrivicnoDelo.AutoSize = true;
            this.radioButtonKrivicnoDelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrivicnoDelo.Location = new System.Drawing.Point(6, 83);
            this.radioButtonKrivicnoDelo.Name = "radioButtonKrivicnoDelo";
            this.radioButtonKrivicnoDelo.Size = new System.Drawing.Size(124, 22);
            this.radioButtonKrivicnoDelo.TabIndex = 14;
            this.radioButtonKrivicnoDelo.TabStop = true;
            this.radioButtonKrivicnoDelo.Text = "Krivično delo";
            this.radioButtonKrivicnoDelo.UseVisualStyleBackColor = true;
            // 
            // buttonSacuvajPrestup
            // 
            this.buttonSacuvajPrestup.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSacuvajPrestup.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonSacuvajPrestup.FlatAppearance.BorderSize = 0;
            this.buttonSacuvajPrestup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonSacuvajPrestup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonSacuvajPrestup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacuvajPrestup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSacuvajPrestup.Location = new System.Drawing.Point(511, 364);
            this.buttonSacuvajPrestup.Name = "buttonSacuvajPrestup";
            this.buttonSacuvajPrestup.Size = new System.Drawing.Size(121, 45);
            this.buttonSacuvajPrestup.TabIndex = 16;
            this.buttonSacuvajPrestup.Text = "Sačuvaj";
            this.buttonSacuvajPrestup.UseVisualStyleBackColor = false;
            this.buttonSacuvajPrestup.Click += new System.EventHandler(this.buttonSacuvajPrestup_Click);
            // 
            // labelPocinilacId
            // 
            this.labelPocinilacId.AutoSize = true;
            this.labelPocinilacId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPocinilacId.Location = new System.Drawing.Point(394, 11);
            this.labelPocinilacId.Name = "labelPocinilacId";
            this.labelPocinilacId.Size = new System.Drawing.Size(211, 16);
            this.labelPocinilacId.TabIndex = 9;
            this.labelPocinilacId.Text = "Identifikacioni broj počinioca:";
            // 
            // labelDatumPrestupa
            // 
            this.labelDatumPrestupa.AutoSize = true;
            this.labelDatumPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumPrestupa.Location = new System.Drawing.Point(35, 178);
            this.labelDatumPrestupa.Name = "labelDatumPrestupa";
            this.labelDatumPrestupa.Size = new System.Drawing.Size(121, 16);
            this.labelDatumPrestupa.TabIndex = 8;
            this.labelDatumPrestupa.Text = "Datum prestupa:";
            // 
            // dateTimePickerDatumPrestupa
            // 
            this.dateTimePickerDatumPrestupa.Location = new System.Drawing.Point(38, 197);
            this.dateTimePickerDatumPrestupa.Name = "dateTimePickerDatumPrestupa";
            this.dateTimePickerDatumPrestupa.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerDatumPrestupa.TabIndex = 7;
            // 
            // richTextBoxOpisPrestupa
            // 
            this.richTextBoxOpisPrestupa.Location = new System.Drawing.Point(382, 147);
            this.richTextBoxOpisPrestupa.Name = "richTextBoxOpisPrestupa";
            this.richTextBoxOpisPrestupa.Size = new System.Drawing.Size(256, 199);
            this.richTextBoxOpisPrestupa.TabIndex = 6;
            this.richTextBoxOpisPrestupa.Text = "";
            // 
            // labelOpstinaPrestupa
            // 
            this.labelOpstinaPrestupa.AutoSize = true;
            this.labelOpstinaPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpstinaPrestupa.Location = new System.Drawing.Point(35, 119);
            this.labelOpstinaPrestupa.Name = "labelOpstinaPrestupa";
            this.labelOpstinaPrestupa.Size = new System.Drawing.Size(130, 16);
            this.labelOpstinaPrestupa.TabIndex = 5;
            this.labelOpstinaPrestupa.Text = "Opština prestupa:";
            // 
            // labelAdresaPrestupa
            // 
            this.labelAdresaPrestupa.AutoSize = true;
            this.labelAdresaPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresaPrestupa.Location = new System.Drawing.Point(35, 65);
            this.labelAdresaPrestupa.Name = "labelAdresaPrestupa";
            this.labelAdresaPrestupa.Size = new System.Drawing.Size(127, 16);
            this.labelAdresaPrestupa.TabIndex = 4;
            this.labelAdresaPrestupa.Text = "Adresa prestupa:";
            // 
            // textBoxOpstina
            // 
            this.textBoxOpstina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpstina.Location = new System.Drawing.Point(38, 138);
            this.textBoxOpstina.Name = "textBoxOpstina";
            this.textBoxOpstina.Size = new System.Drawing.Size(227, 24);
            this.textBoxOpstina.TabIndex = 3;
            // 
            // textBoxAdresaPrestupa
            // 
            this.textBoxAdresaPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresaPrestupa.Location = new System.Drawing.Point(38, 84);
            this.textBoxAdresaPrestupa.Name = "textBoxAdresaPrestupa";
            this.textBoxAdresaPrestupa.Size = new System.Drawing.Size(224, 24);
            this.textBoxAdresaPrestupa.TabIndex = 2;
            // 
            // labelOpisPrestupa
            // 
            this.labelOpisPrestupa.AutoSize = true;
            this.labelOpisPrestupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisPrestupa.Location = new System.Drawing.Point(379, 122);
            this.labelOpisPrestupa.Name = "labelOpisPrestupa";
            this.labelOpisPrestupa.Size = new System.Drawing.Size(109, 16);
            this.labelOpisPrestupa.TabIndex = 1;
            this.labelOpisPrestupa.Text = "Opis prestupa:";
            // 
            // textBoxPocinilacId
            // 
            this.textBoxPocinilacId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPocinilacId.Location = new System.Drawing.Point(382, 30);
            this.textBoxPocinilacId.Name = "textBoxPocinilacId";
            this.textBoxPocinilacId.Size = new System.Drawing.Size(256, 24);
            this.textBoxPocinilacId.TabIndex = 0;
            // 
            // tabPagePrikaz
            // 
            this.tabPagePrikaz.Controls.Add(this.labelNeplaćene);
            this.tabPagePrikaz.Controls.Add(this.label1);
            this.tabPagePrikaz.Controls.Add(this.labelIDPočinioca);
            this.tabPagePrikaz.Controls.Add(this.NeplaceneKazne);
            this.tabPagePrikaz.Controls.Add(this.Prestupi);
            this.tabPagePrikaz.Controls.Add(this.labelTelefonP);
            this.tabPagePrikaz.Controls.Add(this.textBoxTelefonP);
            this.tabPagePrikaz.Controls.Add(this.textBoxAdresaP);
            this.tabPagePrikaz.Controls.Add(this.labelAdresaP);
            this.tabPagePrikaz.Controls.Add(this.textBoxIme);
            this.tabPagePrikaz.Controls.Add(this.labelIme);
            this.tabPagePrikaz.Controls.Add(this.labelnacionaklnost);
            this.tabPagePrikaz.Controls.Add(this.textBoxNacionalnost);
            this.tabPagePrikaz.Controls.Add(this.textBoxTelefon);
            this.tabPagePrikaz.Controls.Add(this.labelTelefon);
            this.tabPagePrikaz.Controls.Add(this.labelDatumRodjenj);
            this.tabPagePrikaz.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.tabPagePrikaz.Controls.Add(this.labelAdresa);
            this.tabPagePrikaz.Controls.Add(this.textBoxAdresa);
            this.tabPagePrikaz.Controls.Add(this.labelPrezime);
            this.tabPagePrikaz.Controls.Add(this.labelNaziv);
            this.tabPagePrikaz.Controls.Add(this.textBoxPrezime);
            this.tabPagePrikaz.Controls.Add(this.textBoxNaziv);
            this.tabPagePrikaz.Controls.Add(this.groupBoxEntitet);
            this.tabPagePrikaz.Controls.Add(this.textBoxId);
            this.tabPagePrikaz.Controls.Add(this.buttonPrikazi);
            this.tabPagePrikaz.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrikaz.Name = "tabPagePrikaz";
            this.tabPagePrikaz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrikaz.Size = new System.Drawing.Size(740, 420);
            this.tabPagePrikaz.TabIndex = 1;
            this.tabPagePrikaz.Text = "Prikaz";
            this.tabPagePrikaz.UseVisualStyleBackColor = true;
            // 
            // labelNeplaćene
            // 
            this.labelNeplaćene.AutoSize = true;
            this.labelNeplaćene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeplaćene.Location = new System.Drawing.Point(418, 15);
            this.labelNeplaćene.Name = "labelNeplaćene";
            this.labelNeplaćene.Size = new System.Drawing.Size(133, 16);
            this.labelNeplaćene.TabIndex = 26;
            this.labelNeplaćene.Text = "Neplaćene kazne:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Prestupi:";
            // 
            // labelIDPočinioca
            // 
            this.labelIDPočinioca.AutoSize = true;
            this.labelIDPočinioca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPočinioca.Location = new System.Drawing.Point(35, 15);
            this.labelIDPočinioca.Name = "labelIDPočinioca";
            this.labelIDPočinioca.Size = new System.Drawing.Size(211, 16);
            this.labelIDPočinioca.TabIndex = 24;
            this.labelIDPočinioca.Text = "Identifikacioni broj počinioca:";
            // 
            // NeplaceneKazne
            // 
            this.NeplaceneKazne.FormattingEnabled = true;
            this.NeplaceneKazne.Location = new System.Drawing.Point(421, 34);
            this.NeplaceneKazne.Name = "NeplaceneKazne";
            this.NeplaceneKazne.Size = new System.Drawing.Size(296, 160);
            this.NeplaceneKazne.TabIndex = 23;
            this.NeplaceneKazne.SelectedIndexChanged += new System.EventHandler(this.NeplaceneKazne_SelectedIndexChanged);
            // 
            // Prestupi
            // 
            this.Prestupi.FormattingEnabled = true;
            this.Prestupi.Location = new System.Drawing.Point(421, 227);
            this.Prestupi.Name = "Prestupi";
            this.Prestupi.Size = new System.Drawing.Size(296, 147);
            this.Prestupi.TabIndex = 22;
            // 
            // labelTelefonP
            // 
            this.labelTelefonP.AutoSize = true;
            this.labelTelefonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonP.Location = new System.Drawing.Point(67, 211);
            this.labelTelefonP.Name = "labelTelefonP";
            this.labelTelefonP.Size = new System.Drawing.Size(65, 16);
            this.labelTelefonP.TabIndex = 21;
            this.labelTelefonP.Text = "Telefon:";
            this.labelTelefonP.Visible = false;
            // 
            // textBoxTelefonP
            // 
            this.textBoxTelefonP.Location = new System.Drawing.Point(145, 211);
            this.textBoxTelefonP.Name = "textBoxTelefonP";
            this.textBoxTelefonP.Size = new System.Drawing.Size(211, 20);
            this.textBoxTelefonP.TabIndex = 20;
            this.textBoxTelefonP.Visible = false;
            // 
            // textBoxAdresaP
            // 
            this.textBoxAdresaP.Location = new System.Drawing.Point(145, 185);
            this.textBoxAdresaP.Name = "textBoxAdresaP";
            this.textBoxAdresaP.Size = new System.Drawing.Size(211, 20);
            this.textBoxAdresaP.TabIndex = 19;
            this.textBoxAdresaP.Visible = false;
            // 
            // labelAdresaP
            // 
            this.labelAdresaP.AutoSize = true;
            this.labelAdresaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresaP.Location = new System.Drawing.Point(74, 185);
            this.labelAdresaP.Name = "labelAdresaP";
            this.labelAdresaP.Size = new System.Drawing.Size(62, 16);
            this.labelAdresaP.TabIndex = 18;
            this.labelAdresaP.Text = "Adresa:";
            this.labelAdresaP.Visible = false;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(146, 164);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(210, 20);
            this.textBoxIme.TabIndex = 17;
            this.textBoxIme.Visible = false;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(94, 165);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(37, 16);
            this.labelIme.TabIndex = 16;
            this.labelIme.Text = "Ime:";
            this.labelIme.Visible = false;
            // 
            // labelnacionaklnost
            // 
            this.labelnacionaklnost.AutoSize = true;
            this.labelnacionaklnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnacionaklnost.Location = new System.Drawing.Point(33, 295);
            this.labelnacionaklnost.Name = "labelnacionaklnost";
            this.labelnacionaklnost.Size = new System.Drawing.Size(103, 16);
            this.labelnacionaklnost.TabIndex = 14;
            this.labelnacionaklnost.Text = "Nacionalnost:";
            this.labelnacionaklnost.Visible = false;
            // 
            // textBoxNacionalnost
            // 
            this.textBoxNacionalnost.Location = new System.Drawing.Point(145, 295);
            this.textBoxNacionalnost.Name = "textBoxNacionalnost";
            this.textBoxNacionalnost.Size = new System.Drawing.Size(211, 20);
            this.textBoxNacionalnost.TabIndex = 13;
            this.textBoxNacionalnost.Visible = false;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(145, 267);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(211, 20);
            this.textBoxTelefon.TabIndex = 12;
            this.textBoxTelefon.Visible = false;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.Location = new System.Drawing.Point(70, 268);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(65, 16);
            this.labelTelefon.TabIndex = 11;
            this.labelTelefon.Text = "Telefon:";
            this.labelTelefon.Visible = false;
            // 
            // labelDatumRodjenj
            // 
            this.labelDatumRodjenj.AutoSize = true;
            this.labelDatumRodjenj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumRodjenj.Location = new System.Drawing.Point(19, 241);
            this.labelDatumRodjenj.Name = "labelDatumRodjenj";
            this.labelDatumRodjenj.Size = new System.Drawing.Size(117, 16);
            this.labelDatumRodjenj.TabIndex = 10;
            this.labelDatumRodjenj.Text = "Datum rodjenja:";
            this.labelDatumRodjenj.Visible = false;
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(145, 237);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerDatumRodjenja.TabIndex = 9;
            this.dateTimePickerDatumRodjenja.Visible = false;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresa.Location = new System.Drawing.Point(70, 211);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(62, 16);
            this.labelAdresa.TabIndex = 8;
            this.labelAdresa.Text = "Adresa:";
            this.labelAdresa.Visible = false;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(145, 210);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(208, 20);
            this.textBoxAdresa.TabIndex = 7;
            this.textBoxAdresa.Visible = false;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrezime.Location = new System.Drawing.Point(67, 189);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(64, 16);
            this.labelPrezime.TabIndex = 6;
            this.labelPrezime.Text = "Prezime";
            this.labelPrezime.Visible = false;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(80, 165);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(51, 16);
            this.labelNaziv.TabIndex = 5;
            this.labelNaziv.Text = "Naziv:";
            this.labelNaziv.Visible = false;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(145, 188);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(210, 20);
            this.textBoxPrezime.TabIndex = 4;
            this.textBoxPrezime.Visible = false;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(145, 163);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(210, 20);
            this.textBoxNaziv.TabIndex = 3;
            this.textBoxNaziv.Visible = false;
            // 
            // groupBoxEntitet
            // 
            this.groupBoxEntitet.Controls.Add(this.radioButtonPravnoL);
            this.groupBoxEntitet.Controls.Add(this.radioButtonFizickoL);
            this.groupBoxEntitet.Location = new System.Drawing.Point(33, 64);
            this.groupBoxEntitet.Name = "groupBoxEntitet";
            this.groupBoxEntitet.Size = new System.Drawing.Size(234, 49);
            this.groupBoxEntitet.TabIndex = 2;
            this.groupBoxEntitet.TabStop = false;
            this.groupBoxEntitet.Text = "Entitet";
            // 
            // radioButtonPravnoL
            // 
            this.radioButtonPravnoL.AutoSize = true;
            this.radioButtonPravnoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPravnoL.Location = new System.Drawing.Point(130, 19);
            this.radioButtonPravnoL.Name = "radioButtonPravnoL";
            this.radioButtonPravnoL.Size = new System.Drawing.Size(104, 20);
            this.radioButtonPravnoL.TabIndex = 1;
            this.radioButtonPravnoL.TabStop = true;
            this.radioButtonPravnoL.Text = "Pravno lice";
            this.radioButtonPravnoL.UseVisualStyleBackColor = true;
            // 
            // radioButtonFizickoL
            // 
            this.radioButtonFizickoL.AutoSize = true;
            this.radioButtonFizickoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFizickoL.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFizickoL.Name = "radioButtonFizickoL";
            this.radioButtonFizickoL.Size = new System.Drawing.Size(104, 20);
            this.radioButtonFizickoL.TabIndex = 0;
            this.radioButtonFizickoL.TabStop = true;
            this.radioButtonFizickoL.Text = "Fizicko lice";
            this.radioButtonFizickoL.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(33, 38);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(234, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrikazi.FlatAppearance.BorderSize = 3;
            this.buttonPrikazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonPrikazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazi.Location = new System.Drawing.Point(145, 119);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(122, 35);
            this.buttonPrikazi.TabIndex = 0;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // DodavanjePrestupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "DodavanjePrestupa";
            this.Text = "Dodavanje prestupa";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDodaj.ResumeLayout(false);
            this.tabPageDodaj.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxKategorijaPrestupa.ResumeLayout(false);
            this.groupBoxKategorijaPrestupa.PerformLayout();
            this.tabPagePrikaz.ResumeLayout(false);
            this.tabPagePrikaz.PerformLayout();
            this.groupBoxEntitet.ResumeLayout(false);
            this.groupBoxEntitet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDodaj;
        private System.Windows.Forms.Label labelOpisPrestupa;
        private System.Windows.Forms.TextBox textBoxPocinilacId;
        private System.Windows.Forms.TabPage tabPagePrikaz;
        private System.Windows.Forms.Label labelOpstinaPrestupa;
        private System.Windows.Forms.Label labelAdresaPrestupa;
        private System.Windows.Forms.TextBox textBoxOpstina;
        private System.Windows.Forms.TextBox textBoxAdresaPrestupa;
        private System.Windows.Forms.Label labelDatumPrestupa;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPrestupa;
        private System.Windows.Forms.RichTextBox richTextBoxOpisPrestupa;
        private System.Windows.Forms.RadioButton radioButtonPravnoLice;
        private System.Windows.Forms.RadioButton radioButtonFizickoLice;
        private System.Windows.Forms.Label labelPocinilacId;
        private System.Windows.Forms.Button buttonSacuvajPrestup;
        private System.Windows.Forms.RadioButton radioButtonKrivicnoDelo;
        private System.Windows.Forms.RadioButton radioButtonPrivredniPrekrsaj;
        private System.Windows.Forms.RadioButton radioButtonPrekrsaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxKategorijaPrestupa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxEntitet;
        private System.Windows.Forms.RadioButton radioButtonPravnoL;
        private System.Windows.Forms.RadioButton radioButtonFizickoL;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Label labelDatumRodjenj;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelnacionaklnost;
        private System.Windows.Forms.TextBox textBoxNacionalnost;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelTelefonP;
        private System.Windows.Forms.TextBox textBoxTelefonP;
        private System.Windows.Forms.TextBox textBoxAdresaP;
        private System.Windows.Forms.Label labelAdresaP;
        private System.Windows.Forms.ListBox Prestupi;
        private System.Windows.Forms.ListBox NeplaceneKazne;
        private System.Windows.Forms.Label labelNazivPrestupa;
        private System.Windows.Forms.TextBox textBoxNazivPrestupa;
        private System.Windows.Forms.Label labelNeplaćene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIDPočinioca;
    }
}