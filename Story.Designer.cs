namespace ScrumTable
{
    partial class Story
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTaskKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPBitis = new System.Windows.Forms.DateTimePicker();
            this.dTPBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtTaskAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Story";
            // 
            // BtnTaskKaydet
            // 
            this.BtnTaskKaydet.Location = new System.Drawing.Point(92, 257);
            this.BtnTaskKaydet.Name = "BtnTaskKaydet";
            this.BtnTaskKaydet.Size = new System.Drawing.Size(113, 42);
            this.BtnTaskKaydet.TabIndex = 2;
            this.BtnTaskKaydet.Text = "Kaydet";
            this.BtnTaskKaydet.UseVisualStyleBackColor = true;
            this.BtnTaskKaydet.Click += new System.EventHandler(this.BtnTaskKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Task Adı :";
            // 
            // txtTaskAciklama
            // 
            this.txtTaskAciklama.Location = new System.Drawing.Point(375, 87);
            this.txtTaskAciklama.Name = "txtTaskAciklama";
            this.txtTaskAciklama.Size = new System.Drawing.Size(100, 20);
            this.txtTaskAciklama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aciklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Baslangic Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bitis Tarihi :";
            // 
            // dTPBitis
            // 
            this.dTPBitis.Location = new System.Drawing.Point(375, 184);
            this.dTPBitis.Name = "dTPBitis";
            this.dTPBitis.Size = new System.Drawing.Size(200, 20);
            this.dTPBitis.TabIndex = 5;
            // 
            // dTPBaslangic
            // 
            this.dTPBaslangic.Location = new System.Drawing.Point(375, 136);
            this.dTPBaslangic.Name = "dTPBaslangic";
            this.dTPBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dTPBaslangic.TabIndex = 5;
            // 
            // txtTaskAdi
            // 
            this.txtTaskAdi.Location = new System.Drawing.Point(375, 38);
            this.txtTaskAdi.Name = "txtTaskAdi";
            this.txtTaskAdi.Size = new System.Drawing.Size(100, 20);
            this.txtTaskAdi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oluşturan Kişi :";
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(375, 225);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(100, 20);
            this.txtKisi.TabIndex = 1;
            // 
            // txtStory
            // 
            this.txtStory.Location = new System.Drawing.Point(123, 38);
            this.txtStory.Name = "txtStory";
            this.txtStory.Size = new System.Drawing.Size(100, 20);
            this.txtStory.TabIndex = 1;
            // 
            // Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 353);
            this.Controls.Add(this.dTPBaslangic);
            this.Controls.Add(this.dTPBitis);
            this.Controls.Add(this.BtnTaskKaydet);
            this.Controls.Add(this.txtStory);
            this.Controls.Add(this.txtTaskAdi);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.txtTaskAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Story";
            this.Text = "Story";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTaskKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPBitis;
        private System.Windows.Forms.DateTimePicker dTPBaslangic;
        private System.Windows.Forms.TextBox txtTaskAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.TextBox txtStory;
    }
}