namespace DesktopAplikacija
{
    partial class Inspektorat
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
            this.Prekrsaji = new System.Windows.Forms.ListBox();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.PrivredniPrestupi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prekrsaji
            // 
            this.Prekrsaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prekrsaji.FormattingEnabled = true;
            this.Prekrsaji.ItemHeight = 16;
            this.Prekrsaji.Location = new System.Drawing.Point(11, 33);
            this.Prekrsaji.Name = "Prekrsaji";
            this.Prekrsaji.Size = new System.Drawing.Size(384, 148);
            this.Prekrsaji.TabIndex = 0;
            this.Prekrsaji.SelectedIndexChanged += new System.EventHandler(this.Prekrsaji_SelectedIndexChanged);
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOtvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtvori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOtvori.Location = new System.Drawing.Point(123, 368);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(173, 48);
            this.buttonOtvori.TabIndex = 1;
            this.buttonOtvori.Text = "Otvori";
            this.buttonOtvori.UseVisualStyleBackColor = false;
            this.buttonOtvori.Click += new System.EventHandler(this.buttonOtvori_Click);
            // 
            // PrivredniPrestupi
            // 
            this.PrivredniPrestupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivredniPrestupi.FormattingEnabled = true;
            this.PrivredniPrestupi.ItemHeight = 16;
            this.PrivredniPrestupi.Location = new System.Drawing.Point(11, 214);
            this.PrivredniPrestupi.Name = "PrivredniPrestupi";
            this.PrivredniPrestupi.Size = new System.Drawing.Size(383, 148);
            this.PrivredniPrestupi.TabIndex = 2;
            this.PrivredniPrestupi.SelectedIndexChanged += new System.EventHandler(this.PrivredniPrestupi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prekršaji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Privredni prestupi:";
            // 
            // Inspektorat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrivredniPrestupi);
            this.Controls.Add(this.buttonOtvori);
            this.Controls.Add(this.Prekrsaji);
            this.Name = "Inspektorat";
            this.Text = "Inspektorat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Prekrsaji;
        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.ListBox PrivredniPrestupi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}