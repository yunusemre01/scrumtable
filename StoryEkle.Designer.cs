namespace ScrumTable
{
    partial class StoryEkle
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
            this.BtnStryKaydet = new System.Windows.Forms.Button();
            this.txtStoryAdi = new System.Windows.Forms.TextBox();
            this.DTPStryBaslngic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.txtStryAciklama = new System.Windows.Forms.TextBox();
            this.DTPStryBitis = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnStryKaydet
            // 
            this.BtnStryKaydet.Location = new System.Drawing.Point(89, 286);
            this.BtnStryKaydet.Name = "BtnStryKaydet";
            this.BtnStryKaydet.Size = new System.Drawing.Size(89, 30);
            this.BtnStryKaydet.TabIndex = 0;
            this.BtnStryKaydet.Text = "Kaydet";
            this.BtnStryKaydet.UseVisualStyleBackColor = true;
            this.BtnStryKaydet.Click += new System.EventHandler(this.BtnStryKaydet_Click);
            // 
            // txtStoryAdi
            // 
            this.txtStoryAdi.Location = new System.Drawing.Point(176, 43);
            this.txtStoryAdi.Name = "txtStoryAdi";
            this.txtStoryAdi.Size = new System.Drawing.Size(100, 20);
            this.txtStoryAdi.TabIndex = 1;
            // 
            // DTPStryBaslngic
            // 
            this.DTPStryBaslngic.Location = new System.Drawing.Point(176, 128);
            this.DTPStryBaslngic.Name = "DTPStryBaslngic";
            this.DTPStryBaslngic.Size = new System.Drawing.Size(200, 20);
            this.DTPStryBaslngic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Story Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Başlangıç Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bitiş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Oluşturan Kişi :";
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(176, 215);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(100, 20);
            this.txtKisi.TabIndex = 1;
            // 
            // txtStryAciklama
            // 
            this.txtStryAciklama.Location = new System.Drawing.Point(176, 80);
            this.txtStryAciklama.Name = "txtStryAciklama";
            this.txtStryAciklama.Size = new System.Drawing.Size(100, 20);
            this.txtStryAciklama.TabIndex = 1;
            // 
            // DTPStryBitis
            // 
            this.DTPStryBitis.Location = new System.Drawing.Point(176, 169);
            this.DTPStryBitis.Name = "DTPStryBitis";
            this.DTPStryBitis.Size = new System.Drawing.Size(200, 20);
            this.DTPStryBitis.TabIndex = 2;
            // 
            // StoryEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStryAciklama);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.DTPStryBitis);
            this.Controls.Add(this.DTPStryBaslngic);
            this.Controls.Add(this.txtStoryAdi);
            this.Controls.Add(this.BtnStryKaydet);
            this.Name = "StoryEkle";
            this.Text = "StoryEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStryKaydet;
        private System.Windows.Forms.TextBox txtStoryAdi;
        private System.Windows.Forms.DateTimePicker DTPStryBaslngic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.TextBox txtStryAciklama;
        private System.Windows.Forms.DateTimePicker DTPStryBitis;
    }
}