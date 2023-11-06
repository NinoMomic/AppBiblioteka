namespace AppBiblioteka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxKnjige = new System.Windows.Forms.GroupBox();
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.btnPopisKnjige = new System.Windows.Forms.Button();
            this.btnObrisiKnjige = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnosKorisnici = new System.Windows.Forms.Button();
            this.btnObrisiKorisnici = new System.Windows.Forms.Button();
            this.btnKorisniciPopis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnosEvidencija = new System.Windows.Forms.Button();
            this.btnPopisEvidencija = new System.Windows.Forms.Button();
            this.btnObrišiEvidencija = new System.Windows.Forms.Button();
            this.groupBoxKnjige.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKnjige
            // 
            this.groupBoxKnjige.BackColor = System.Drawing.Color.White;
            this.groupBoxKnjige.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxKnjige.BackgroundImage")));
            this.groupBoxKnjige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxKnjige.Controls.Add(this.btnObrisiKnjige);
            this.groupBoxKnjige.Controls.Add(this.btnPopisKnjige);
            this.groupBoxKnjige.Controls.Add(this.btnUnosKnjige);
            this.groupBoxKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBoxKnjige.ForeColor = System.Drawing.Color.Indigo;
            this.groupBoxKnjige.Location = new System.Drawing.Point(128, 12);
            this.groupBoxKnjige.Name = "groupBoxKnjige";
            this.groupBoxKnjige.Size = new System.Drawing.Size(660, 128);
            this.groupBoxKnjige.TabIndex = 0;
            this.groupBoxKnjige.TabStop = false;
            this.groupBoxKnjige.Text = "Knjige";
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.Location = new System.Drawing.Point(6, 88);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(126, 34);
            this.btnUnosKnjige.TabIndex = 0;
            this.btnUnosKnjige.Text = "Unos";
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            // 
            // btnPopisKnjige
            // 
            this.btnPopisKnjige.Location = new System.Drawing.Point(528, 88);
            this.btnPopisKnjige.Name = "btnPopisKnjige";
            this.btnPopisKnjige.Size = new System.Drawing.Size(126, 34);
            this.btnPopisKnjige.TabIndex = 1;
            this.btnPopisKnjige.Text = "Popis";
            this.btnPopisKnjige.UseVisualStyleBackColor = true;
            // 
            // btnObrisiKnjige
            // 
            this.btnObrisiKnjige.Location = new System.Drawing.Point(279, 88);
            this.btnObrisiKnjige.Name = "btnObrisiKnjige";
            this.btnObrisiKnjige.Size = new System.Drawing.Size(126, 34);
            this.btnObrisiKnjige.TabIndex = 2;
            this.btnObrisiKnjige.Text = "Obriši";
            this.btnObrisiKnjige.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnKorisniciPopis);
            this.groupBox1.Controls.Add(this.btnObrisiKorisnici);
            this.groupBox1.Controls.Add(this.btnUnosKorisnici);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(128, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // btnUnosKorisnici
            // 
            this.btnUnosKorisnici.Location = new System.Drawing.Point(6, 89);
            this.btnUnosKorisnici.Name = "btnUnosKorisnici";
            this.btnUnosKorisnici.Size = new System.Drawing.Size(126, 33);
            this.btnUnosKorisnici.TabIndex = 3;
            this.btnUnosKorisnici.Text = "Unos";
            this.btnUnosKorisnici.UseVisualStyleBackColor = true;
            // 
            // btnObrisiKorisnici
            // 
            this.btnObrisiKorisnici.Location = new System.Drawing.Point(280, 89);
            this.btnObrisiKorisnici.Name = "btnObrisiKorisnici";
            this.btnObrisiKorisnici.Size = new System.Drawing.Size(125, 33);
            this.btnObrisiKorisnici.TabIndex = 4;
            this.btnObrisiKorisnici.Text = "Obriši";
            this.btnObrisiKorisnici.UseVisualStyleBackColor = true;
            // 
            // btnKorisniciPopis
            // 
            this.btnKorisniciPopis.Location = new System.Drawing.Point(528, 89);
            this.btnKorisniciPopis.Name = "btnKorisniciPopis";
            this.btnKorisniciPopis.Size = new System.Drawing.Size(126, 33);
            this.btnKorisniciPopis.TabIndex = 5;
            this.btnKorisniciPopis.Text = "Popis";
            this.btnKorisniciPopis.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btnObrišiEvidencija);
            this.groupBox2.Controls.Add(this.btnPopisEvidencija);
            this.groupBox2.Controls.Add(this.btnUnosEvidencija);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox2.Location = new System.Drawing.Point(128, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evidencija";
            // 
            // btnUnosEvidencija
            // 
            this.btnUnosEvidencija.Location = new System.Drawing.Point(7, 89);
            this.btnUnosEvidencija.Name = "btnUnosEvidencija";
            this.btnUnosEvidencija.Size = new System.Drawing.Size(125, 33);
            this.btnUnosEvidencija.TabIndex = 6;
            this.btnUnosEvidencija.Text = "Unos";
            this.btnUnosEvidencija.UseVisualStyleBackColor = true;
            // 
            // btnPopisEvidencija
            // 
            this.btnPopisEvidencija.Location = new System.Drawing.Point(528, 89);
            this.btnPopisEvidencija.Name = "btnPopisEvidencija";
            this.btnPopisEvidencija.Size = new System.Drawing.Size(125, 33);
            this.btnPopisEvidencija.TabIndex = 7;
            this.btnPopisEvidencija.Text = "Popis";
            this.btnPopisEvidencija.UseVisualStyleBackColor = true;
            // 
            // btnObrišiEvidencija
            // 
            this.btnObrišiEvidencija.Location = new System.Drawing.Point(280, 90);
            this.btnObrišiEvidencija.Name = "btnObrišiEvidencija";
            this.btnObrišiEvidencija.Size = new System.Drawing.Size(125, 33);
            this.btnObrišiEvidencija.TabIndex = 8;
            this.btnObrišiEvidencija.Text = "Obriši";
            this.btnObrišiEvidencija.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxKnjige);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxKnjige.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKnjige;
        private System.Windows.Forms.Button btnObrisiKnjige;
        private System.Windows.Forms.Button btnPopisKnjige;
        private System.Windows.Forms.Button btnUnosKnjige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKorisniciPopis;
        private System.Windows.Forms.Button btnObrisiKorisnici;
        private System.Windows.Forms.Button btnUnosKorisnici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrišiEvidencija;
        private System.Windows.Forms.Button btnPopisEvidencija;
        private System.Windows.Forms.Button btnUnosEvidencija;
    }
}

