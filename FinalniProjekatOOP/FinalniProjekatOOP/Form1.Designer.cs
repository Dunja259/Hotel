namespace FinalniProjekatOOP
{
    partial class Rezervacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervacija));
            this.Pozdrav = new System.Windows.Forms.Button();
            this.Informacije = new System.Windows.Forms.Button();
            this.OdabirSobe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ssoba = new System.Windows.Forms.RadioButton();
            this.psoba = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DSoba = new System.Windows.Forms.Button();
            this.radnovreme = new System.Windows.Forms.Button();
            this.Odjava = new System.Windows.Forms.Button();
            this.OdabirDatuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dodatnikrevet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pozdrav
            // 
            this.Pozdrav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pozdrav.BackColor = System.Drawing.Color.Coral;
            this.Pozdrav.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pozdrav.Location = new System.Drawing.Point(12, 12);
            this.Pozdrav.Name = "Pozdrav";
            this.Pozdrav.Size = new System.Drawing.Size(347, 35);
            this.Pozdrav.TabIndex = 1;
            this.Pozdrav.Text = "Pozdrav!";
            this.Pozdrav.UseVisualStyleBackColor = false;
            this.Pozdrav.Click += new System.EventHandler(this.Pozdrav_Click);
            // 
            // Informacije
            // 
            this.Informacije.BackColor = System.Drawing.Color.Coral;
            this.Informacije.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacije.ForeColor = System.Drawing.Color.Black;
            this.Informacije.Location = new System.Drawing.Point(106, 53);
            this.Informacije.Name = "Informacije";
            this.Informacije.Size = new System.Drawing.Size(156, 29);
            this.Informacije.TabIndex = 2;
            this.Informacije.Text = "Osnovne informacije";
            this.Informacije.UseVisualStyleBackColor = false;
            this.Informacije.Click += new System.EventHandler(this.Informacije_Click);
            // 
            // OdabirSobe
            // 
            this.OdabirSobe.Location = new System.Drawing.Point(12, 235);
            this.OdabirSobe.Name = "OdabirSobe";
            this.OdabirSobe.Size = new System.Drawing.Size(162, 20);
            this.OdabirSobe.TabIndex = 7;
            this.OdabirSobe.TextChanged += new System.EventHandler(this.OdabirSobeTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Koju sobu zelite? standardna/premium";
            // 
            // ssoba
            // 
            this.ssoba.AutoSize = true;
            this.ssoba.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssoba.Location = new System.Drawing.Point(12, 158);
            this.ssoba.Name = "ssoba";
            this.ssoba.Size = new System.Drawing.Size(118, 20);
            this.ssoba.TabIndex = 9;
            this.ssoba.TabStop = true;
            this.ssoba.Text = "Standardna soba";
            this.ssoba.UseVisualStyleBackColor = true;
            this.ssoba.CheckedChanged += new System.EventHandler(this.ssoba_CheckedChanged);
            // 
            // psoba
            // 
            this.psoba.AutoSize = true;
            this.psoba.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psoba.Location = new System.Drawing.Point(12, 184);
            this.psoba.Name = "psoba";
            this.psoba.Size = new System.Drawing.Size(106, 20);
            this.psoba.TabIndex = 10;
            this.psoba.TabStop = true;
            this.psoba.Text = "Premium soba";
            this.psoba.UseVisualStyleBackColor = true;
            this.psoba.CheckedChanged += new System.EventHandler(this.psoba_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kliknite za vise informacija.";
            // 
            // DSoba
            // 
            this.DSoba.BackColor = System.Drawing.Color.Gold;
            this.DSoba.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSoba.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DSoba.Location = new System.Drawing.Point(12, 98);
            this.DSoba.Name = "DSoba";
            this.DSoba.Size = new System.Drawing.Size(162, 25);
            this.DSoba.TabIndex = 12;
            this.DSoba.Text = "Dostupan broj soba";
            this.DSoba.UseVisualStyleBackColor = false;
            this.DSoba.Click += new System.EventHandler(this.DSobaClick_1);
            // 
            // radnovreme
            // 
            this.radnovreme.BackColor = System.Drawing.Color.Coral;
            this.radnovreme.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnovreme.Location = new System.Drawing.Point(253, 360);
            this.radnovreme.Name = "radnovreme";
            this.radnovreme.Size = new System.Drawing.Size(106, 28);
            this.radnovreme.TabIndex = 14;
            this.radnovreme.Text = "Kontakt Telefon";
            this.radnovreme.UseVisualStyleBackColor = false;
            this.radnovreme.Click += new System.EventHandler(this.radnovreme_Click);
            // 
            // Odjava
            // 
            this.Odjava.BackColor = System.Drawing.Color.Gold;
            this.Odjava.Location = new System.Drawing.Point(279, 394);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(75, 28);
            this.Odjava.TabIndex = 15;
            this.Odjava.Text = "Odjava";
            this.Odjava.UseVisualStyleBackColor = false;
            this.Odjava.Click += new System.EventHandler(this.Odjava_Click);
            // 
            // OdabirDatuma
            // 
            this.OdabirDatuma.Location = new System.Drawing.Point(12, 321);
            this.OdabirDatuma.Name = "OdabirDatuma";
            this.OdabirDatuma.Size = new System.Drawing.Size(162, 20);
            this.OdabirDatuma.TabIndex = 16;
            this.OdabirDatuma.TextChanged += new System.EventHandler(this.OdabirDatumaTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Izaberite dan rezervacije: ponedeljak/utorak.../nedelja";
            // 
            // Dodatnikrevet
            // 
            this.Dodatnikrevet.BackColor = System.Drawing.Color.Gold;
            this.Dodatnikrevet.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodatnikrevet.Location = new System.Drawing.Point(12, 261);
            this.Dodatnikrevet.Name = "Dodatnikrevet";
            this.Dodatnikrevet.Size = new System.Drawing.Size(118, 25);
            this.Dodatnikrevet.TabIndex = 18;
            this.Dodatnikrevet.Text = "Dodatni krevet";
            this.Dodatnikrevet.UseVisualStyleBackColor = false;
            this.Dodatnikrevet.Click += new System.EventHandler(this.Dodatnikrevet_Click);
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(371, 443);
            this.Controls.Add(this.Dodatnikrevet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OdabirDatuma);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.radnovreme);
            this.Controls.Add(this.DSoba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.psoba);
            this.Controls.Add(this.ssoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdabirSobe);
            this.Controls.Add(this.Informacije);
            this.Controls.Add(this.Pozdrav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(387, 482);
            this.MinimumSize = new System.Drawing.Size(387, 482);
            this.Name = "Rezervacija";
            this.Text = "Hotel ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pozdrav;
        private System.Windows.Forms.Button Informacije;
        private System.Windows.Forms.TextBox OdabirSobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ssoba;
        private System.Windows.Forms.RadioButton psoba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DSoba;
        private System.Windows.Forms.Button radnovreme;
        private System.Windows.Forms.Button Odjava;
        private System.Windows.Forms.TextBox OdabirDatuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dodatnikrevet;
    }
}

