namespace AppBiblioteka.Forme
{
    partial class Knjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Knjige));
            this.txtBoxIDKnjige = new System.Windows.Forms.TextBox();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.txtBoxNaslov = new System.Windows.Forms.TextBox();
            this.txtBoxIzdavac = new System.Windows.Forms.TextBox();
            this.txtBoxKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnesiKnjigu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxIDKnjige
            // 
            this.txtBoxIDKnjige.Location = new System.Drawing.Point(57, 112);
            this.txtBoxIDKnjige.Name = "txtBoxIDKnjige";
            this.txtBoxIDKnjige.Size = new System.Drawing.Size(100, 30);
            this.txtBoxIDKnjige.TabIndex = 0;
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Location = new System.Drawing.Point(57, 250);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(100, 30);
            this.txtBoxAutor.TabIndex = 1;
            // 
            // txtBoxNaslov
            // 
            this.txtBoxNaslov.Location = new System.Drawing.Point(57, 173);
            this.txtBoxNaslov.Name = "txtBoxNaslov";
            this.txtBoxNaslov.Size = new System.Drawing.Size(100, 30);
            this.txtBoxNaslov.TabIndex = 2;
            // 
            // txtBoxIzdavac
            // 
            this.txtBoxIzdavac.Location = new System.Drawing.Point(274, 140);
            this.txtBoxIzdavac.Name = "txtBoxIzdavac";
            this.txtBoxIzdavac.Size = new System.Drawing.Size(100, 30);
            this.txtBoxIzdavac.TabIndex = 3;
            // 
            // txtBoxKolicina
            // 
            this.txtBoxKolicina.Location = new System.Drawing.Point(274, 217);
            this.txtBoxKolicina.Name = "txtBoxKolicina";
            this.txtBoxKolicina.Size = new System.Drawing.Size(100, 30);
            this.txtBoxKolicina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(52, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(52, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Naslov:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(269, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Izdavač:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(269, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Količina:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUnesiKnjigu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxKolicina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxIDKnjige);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxIzdavac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxAutor);
            this.groupBox1.Controls.Add(this.txtBoxNaslov);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(193, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 383);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos knjiga";
            // 
            // btnUnesiKnjigu
            // 
            this.btnUnesiKnjigu.BackColor = System.Drawing.Color.LawnGreen;
            this.btnUnesiKnjigu.ForeColor = System.Drawing.Color.Black;
            this.btnUnesiKnjigu.Location = new System.Drawing.Point(231, 294);
            this.btnUnesiKnjigu.Name = "btnUnesiKnjigu";
            this.btnUnesiKnjigu.Size = new System.Drawing.Size(143, 58);
            this.btnUnesiKnjigu.TabIndex = 10;
            this.btnUnesiKnjigu.Text = "Unesi";
            this.btnUnesiKnjigu.UseVisualStyleBackColor = false;
            this.btnUnesiKnjigu.Click += new System.EventHandler(this.btnUnesiKnjigu_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIDKnjige;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.TextBox txtBoxNaslov;
        private System.Windows.Forms.TextBox txtBoxIzdavac;
        private System.Windows.Forms.TextBox txtBoxKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnesiKnjigu;
    }
}