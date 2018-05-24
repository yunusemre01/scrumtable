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
    public partial class StoryEkle : Form
    {
        string baglantiCumlesi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\SrumTable.accdb;Persist Security Info=False;";
        //DataGridin Access ile bağlantı sağlıyor

        OleDbCommand veri = new OleDbCommand();

        public OleDbConnection baglanti;
        //Veri Tabanı icin Kullanılan sınıf

        public StoryEkle()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(baglantiCumlesi);
        }

        private void BtnStryKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            veri.Connection = baglanti;
            veri.CommandText = "INSERT INTO  Story (Aciklama,Baslangic_Tarihi, Bitis_tarihi,Kisi) VALUES (@Aciklama,@Baslangic_Tarihi, @Bitis_tarihi,@Kisi)";
            veri.Parameters.AddWithValue("Aciklama", txtStryAciklama.Text.ToString());
            veri.Parameters.AddWithValue("Baslangic_Tarihi", Convert.ToDateTime(DTPStryBaslngic));
            veri.Parameters.AddWithValue("Bitis_tarihi", Convert.ToDateTime(DTPStryBitis));
            veri.Parameters.AddWithValue("Kisi", txtKisi.Text.ToString());
            veri.ExecuteNonQuery();

            MessageBox.Show("Kayıt Tamamlandı");
            baglanti.Close();
            Form1 Frm = new Form1();
            Frm.Show();
            this.Hide();
        }
    }
}
