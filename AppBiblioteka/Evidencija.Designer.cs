namespace AppBiblioteka.Forme
{
    partial class Evidencija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evidencija));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxEvidencijaIDKorisnika = new System.Windows.Forms.TextBox();
            this.txtBoxEvidencijaIDKnjige = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumVracanja = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatumPosudbe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnosEvidencija = new System.Windows.Forms.Button();
            this.btnEvidencijaObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEvidencijaObrisi);
            this.groupBox1.Controls.Add(this.btnUnosEvidencija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerDatumPosudbe);
            this.groupBox1.Controls.Add(this.dateTimePickerDatumVracanja);
            this.groupBox1.Controls.Add(this.txtBoxEvidencijaIDKnjige);
            this.groupBox1.Controls.Add(this.txtBoxEvidencijaIDKorisnika);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(163, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evidencija";
            // 
            // txtBoxEvidencijaIDKorisnika
            // 
            this.txtBoxEvidencijaIDKorisnika.Location = new System.Drawing.Point(6, 88);
            this.txtBoxEvidencijaIDKorisnika.Name = "txtBoxEvidencijaIDKorisnika";
            this.txtBoxEvidencijaIDKorisnika.Size = new System.Drawing.Size(200, 30);
            this.txtBoxEvidencijaIDKorisnika.TabIndex = 0;
            // 
            // txtBoxEvidencijaIDKnjige
            // 
            this.txtBoxEvidencijaIDKnjige.Location = new System.Drawing.Point(6, 174);
            this.txtBoxEvidencijaIDKnjige.Name = "txtBoxEvidencijaIDKnjige";
            this.txtBoxEvidencijaIDKnjige.Size = new System.Drawing.Size(200, 30);
            this.txtBoxEvidencijaIDKnjige.TabIndex = 1;
            // 
            // dateTimePickerDatumVracanja
            // 
            this.dateTimePickerDatumVracanja.Location = new System.Drawing.Point(263, 174);
            this.dateTimePickerDatumVracanja.Name = "dateTimePickerDatumVracanja";
            this.dateTimePickerDatumVracanja.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerDatumVracanja.TabIndex = 2;
            // 
            // dateTimePickerDatumPosudbe
            // 
            this.dateTimePickerDatumPosudbe.Location = new System.Drawing.Point(263, 88);
            this.dateTimePickerDatumPosudbe.Name = "dateTimePickerDatumPosudbe";
            this.dateTimePickerDatumPosudbe.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerDatumPosudbe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Korisnika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Knjige:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum Vracanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum Posudbe:";
            // 
            // btnUnosEvidencija
            // 
            this.btnUnosEvidencija.BackColor = System.Drawing.Color.LawnGreen;
            this.btnUnosEvidencija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnosEvidencija.Location = new System.Drawing.Point(30, 226);
            this.btnUnosEvidencija.Name = "btnUnosEvidencija";
            this.btnUnosEvidencija.Size = new System.Drawing.Size(159, 45);
            this.btnUnosEvidencija.TabIndex = 8;
            this.btnUnosEvidencija.Text = "Unos";
            this.btnUnosEvidencija.UseVisualStyleBackColor = false;
            // 
            // btnEvidencijaObrisi
            // 
            this.btnEvidencijaObrisi.BackColor = System.Drawing.Color.Red;
            this.btnEvidencijaObrisi.Location = new System.Drawing.Point(283, 226);
            this.btnEvidencijaObrisi.Name = "btnEvidencijaObrisi";
            this.btnEvidencijaObrisi.Size = new System.Drawing.Size(159, 45);
            this.btnEvidencijaObrisi.TabIndex = 9;
            this.btnEvidencijaObrisi.Text = "Obriši";
            this.btnEvidencijaObrisi.UseVisualStyleBackColor = false;
            // 
            // Evidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Evidencija";
            this.Text = "Evidencija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEvidencijaObrisi;
        private System.Windows.Forms.Button btnUnosEvidencija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPosudbe;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumVracanja;
        private System.Windows.Forms.TextBox txtBoxEvidencijaIDKnjige;
        private System.Windows.Forms.TextBox txtBoxEvidencijaIDKorisnika;
    }
}