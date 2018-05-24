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
    public partial class Form1 : Form
    {
        OleDbDataAdapter adapter;
        //Veri TAbabnından Veri Çekmeye Yarıyor.

        string baglantiCumlesi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ScrumTable.accdb;Persist Security Info=False;";
        //access ile baglanti

        OleDbCommand veri = new OleDbCommand();
        
        public OleDbConnection baglanti;

        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(baglantiCumlesi);
        }




        private void button2_Click(object sender, EventArgs e)
        {
            StoryEkle Frm = new StoryEkle();
            Frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Story Frm = new Story();
            Frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            ds.Clear();
            adapter = new OleDbDataAdapter("SELECT Story.StoryId, Story.Aciklama, Story.Baslangic_Tarihi, Story.Bitis_Tarihi, Story.Kisi, Task.TaskId, Task.Aciklama, Task.Baslangic_Tarihi, Task.Bitis_Tarihi, Task.Kisi, Task.StoryId FROM Story INNER JOIN Task ON Story.StoryId = Task.StoryId", baglanti);
            adapter.Fill(ds);
            dGScrum.DataSource = ds.Tables[0].DefaultView;
            //düzenlenecek


        }
    }
}
