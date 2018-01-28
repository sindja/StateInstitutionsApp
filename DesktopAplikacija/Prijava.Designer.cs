namespace DesktopAplikacija
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.radioButtonSud = new System.Windows.Forms.RadioButton();
            this.radioButtonTuzilac = new System.Windows.Forms.RadioButton();
            this.radioButtonInspektorat = new System.Windows.Forms.RadioButton();
            this.radioButtonUnos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKorisnickoIme
            // 
            resources.ApplyResources(this.textBoxKorisnickoIme, "textBoxKorisnickoIme");
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            // 
            // textBoxLozinka
            // 
            resources.ApplyResources(this.textBoxLozinka, "textBoxLozinka");
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // labelKorisnickoIme
            // 
            resources.ApplyResources(this.labelKorisnickoIme, "labelKorisnickoIme");
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            // 
            // labelLozinka
            // 
            resources.ApplyResources(this.labelLozinka, "labelLozinka");
            this.labelLozinka.Name = "labelLozinka";
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrijava.FlatAppearance.BorderSize = 2;
            this.buttonPrijava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.buttonPrijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.buttonPrijava, "buttonPrijava");
            this.buttonPrijava.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // radioButtonSud
            // 
            resources.ApplyResources(this.radioButtonSud, "radioButtonSud");
            this.radioButtonSud.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.radioButtonSud.FlatAppearance.BorderSize = 4;
            this.radioButtonSud.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButtonSud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButtonSud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.radioButtonSud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonSud.Name = "radioButtonSud";
            this.radioButtonSud.TabStop = true;
            this.radioButtonSud.UseVisualStyleBackColor = true;
            // 
            // radioButtonTuzilac
            // 
            resources.ApplyResources(this.radioButtonTuzilac, "radioButtonTuzilac");
            this.radioButtonTuzilac.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonTuzilac.FlatAppearance.BorderSize = 4;
            this.radioButtonTuzilac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonTuzilac.Name = "radioButtonTuzilac";
            this.radioButtonTuzilac.TabStop = true;
            this.radioButtonTuzilac.UseVisualStyleBackColor = true;
            // 
            // radioButtonInspektorat
            // 
            resources.ApplyResources(this.radioButtonInspektorat, "radioButtonInspektorat");
            this.radioButtonInspektorat.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.radioButtonInspektorat.FlatAppearance.BorderSize = 4;
            this.radioButtonInspektorat.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButtonInspektorat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButtonInspektorat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.radioButtonInspektorat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonInspektorat.Name = "radioButtonInspektorat";
            this.radioButtonInspektorat.TabStop = true;
            this.radioButtonInspektorat.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnos
            // 
            resources.ApplyResources(this.radioButtonUnos, "radioButtonUnos");
            this.radioButtonUnos.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.radioButtonUnos.FlatAppearance.BorderSize = 4;
            this.radioButtonUnos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButtonUnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButtonUnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.radioButtonUnos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonUnos.Name = "radioButtonUnos";
            this.radioButtonUnos.TabStop = true;
            this.radioButtonUnos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Prijava
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonUnos);
            this.Controls.Add(this.radioButtonInspektorat);
            this.Controls.Add(this.radioButtonTuzilac);
            this.Controls.Add(this.radioButtonSud);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.RadioButton radioButtonSud;
        private System.Windows.Forms.RadioButton radioButtonTuzilac;
        private System.Windows.Forms.RadioButton radioButtonInspektorat;
        private System.Windows.Forms.RadioButton radioButtonUnos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

