using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ScrumTable
{
    public partial class Story : Form
    {
        string baglantiCumlesi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\SrumTable.accdb;Persist Security Info=False;";

        OleDbCommand veri = new OleDbCommand();

        public OleDbConnection baglanti;

        public Story()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(baglantiCumlesi);
        }

        private void BtnTaskKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            veri.Connection = baglanti;
            veri.CommandText = "INSERT INTO  Story (Aciklama,Baslangic_Tarihi, Bitis_tarihi,Kisi,StoryId) VALUES (@Aciklama,@Baslangic_Tarihi, @Bitis_tarihi,@Kisi,@StoryId)";
            veri.Parameters.AddWithValue("Aciklama", txtTaskAciklama.Text.ToString());
            veri.Parameters.AddWithValue("Baslangic_Tarihi", Convert.ToDateTime(dTPBaslangic));
            veri.Parameters.AddWithValue("Bitis_tarihi", Convert.ToDateTime(dTPBitis));
            veri.Parameters.AddWithValue("Kisi", txtKisi.Text.ToString());
            veri.Parameters.AddWithValue("StoryId", txtStory.Text.ToString());
            veri.ExecuteNonQuery();

            MessageBox.Show("Kayıt Tamamlandı");
            baglanti.Close();

            Form1 Frm = new Form1();
            Frm.Show();
            this.Hide();
        }
    }
}
