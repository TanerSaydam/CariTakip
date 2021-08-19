using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariTakip
{
    public partial class XtraCariHareket : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Data\db.mdb");
        public XtraAnaSayfa af;
        public XtraCariHareket ch;
        public int id;
        bool kaydet = true;

        public XtraCariHareket()
        {
            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void bakiye_hesapla()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLCARIHAREKET where CARI_ID=" + id + "", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);
            int son = da.Rows.Count;
            double borc = 0;
            double alacak = 0;
            double bakiye = 0;
            
            for (int i = 0; i < son; i++)
            {
                int kid = Convert.ToInt32(da.Rows[i]["ID"].ToString());
                borc = Convert.ToDouble(da.Rows[i]["BORC"].ToString());
                alacak = Convert.ToDouble(da.Rows[i]["ALACAK"].ToString());
                bakiye = bakiye + (borc - alacak);
                OleDbCommand kmt = new OleDbCommand("update TBLCARIHAREKET set BAKIYE = '" + bakiye + "' where ID=" + kid + "", baglanti);
                baglanti.Open();
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        void göster()
        {
            bakiye_hesapla();
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLCARIHAREKET where CARI_ID=" + id + " order by TARIH desc ", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);
            gridControl1.DataSource = da;

            adp = new OleDbDataAdapter("Select * From TBLCARI where ID=" + id + "", baglanti);
            da = new DataTable();
            da.Clear();
            adp.Fill(da);

            TxtStok.Text = "";
            TxtAdet.Text = "1";
            TxtBF.Text = "0";
            TxtTutar.Text = "0";

            LBCari.Text = da.Rows[0]["ADISOYADI"].ToString();
            LbBakiye.Text = "Bakiye: " + da.Rows[0]["BAKIYE"].ToString();
            kaydet = true;
            BtnTemizle.Enabled = false;
            af.göster();
        }

        void stok_getir()
        {
            TxtStok.Properties.Items.Clear();

            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLSTOK order by STOK", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);
            int son = da.Rows.Count;
            for (int i = 0; i < son; i++)
            {
                TxtStok.Properties.Items.Add(da.Rows[i]["STOK"].ToString());
            }            
        }

        private void XtraCariHareket_Load(object sender, EventArgs e)
        {
            stok_getir();
            göster();
        }

        private void TxtStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            stok_seçimi();   
        }

        void stok_seçimi()
        {
            try
            {
                OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLSTOK WHERE STOK='" + TxtStok.Text + "'", baglanti);
                DataTable da = new DataTable();
                da.Clear();
                adp.Fill(da);

                string gg = da.Rows[0]["GELIRGIDER"].ToString();
                TxtBF.Text = da.Rows[0]["TUTAR"].ToString();
                if (gg == "GELIR")
                {
                    rbGelir.Checked = true;
                }
                else
                {
                    rbGider.Checked = true;
                }
            }
            catch
            {
               
            }
            
        }

        private void TxtAdet_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void TxtBF_EditValueChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        void hesapla()
        {
            try
            {
                if (TxtAdet.Text == "")
                {
                    TxtAdet.Text = "1";
                }

                if (TxtBF.Text == "")
                {
                    TxtBF.Text = "0";
                }

                double adet = Convert.ToDouble(TxtAdet.Text);
                double bf = Convert.ToDouble(TxtBF.Text);
                double tutar = bf * adet;
                TxtTutar.Text = tutar.ToString();
            }
            catch
            {
                TxtTutar.Text = "0";
            }
            
        }

        private void TxtStok_EditValueChanged(object sender, EventArgs e)
        {
            stok_seçimi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            double borc,alacak;
            borc = 0;
            alacak = 0;

            if (MessageBox.Show("Kaydetmek istiyor musunuz?","Kaydet",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                OleDbCommand kmt;
                kmt = new OleDbCommand("insert into TBLCARIHAREKET(CARI_ID,TARIH,STOK,ADET,BFIYAT,BORC,ALACAK) VALUES(@CARI_ID,@TARIH,@STOK,@ADET,@BFIYAT,@BORC,@ALACAK)",baglanti);
                kmt.Parameters.AddWithValue("CARI_ID", id);
                kmt.Parameters.AddWithValue("TARIH", DateTime.Now.ToShortDateString());
                kmt.Parameters.AddWithValue("STOK", TxtStok.Text);
                kmt.Parameters.AddWithValue("ADET", TxtAdet.Text);
                kmt.Parameters.AddWithValue("BFIYAT", Convert.ToDouble(TxtBF.Text));
                if (rbGelir.Checked==true)
                {
                    alacak = Convert.ToDouble(TxtTutar.Text);
                    kmt.Parameters.AddWithValue("BORC", 0);
                    kmt.Parameters.AddWithValue("ALACAK", Convert.ToDouble(TxtTutar.Text));
                }
                else
                {
                    borc = Convert.ToDouble(TxtTutar.Text);
                    kmt.Parameters.AddWithValue("BORC", Convert.ToDouble(TxtTutar.Text));
                    kmt.Parameters.AddWithValue("ALACAK", 0);
                }
                baglanti.Open();
                kmt.ExecuteNonQuery();
                baglanti.Close();

                OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLCARI where ID=" + id + "", baglanti);
                DataTable da = new DataTable();
                da.Clear();
                adp.Fill(da);

                double bakiye = Convert.ToDouble(da.Rows[0]["BAKIYE"].ToString());
                bakiye = bakiye + (borc - alacak);
                kmt = new OleDbCommand("update TBLCARI set BAKIYE=@BAKIYE where ID=" + id + "", baglanti);
                kmt.Parameters.AddWithValue("BAKIYE", bakiye);
                baglanti.Open();
                kmt.ExecuteNonQuery();
                baglanti.Close();

                göster();
            }
        }

        private void BtnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Kaydı silmek istiyor musunuz?","Sil?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                sil();
            }
        }

        void sil()
        {
            double borc, alacak;
            borc = 0;
            alacak = 0;
            int ch_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
            borc = Convert.ToDouble(gridView1.GetFocusedRowCellValue("BORC").ToString());
            alacak = Convert.ToDouble(gridView1.GetFocusedRowCellValue("ALACAK").ToString());

            OleDbCommand kmt;
            kmt = new OleDbCommand("delete from TBLCARIHAREKET where ID=" + ch_id + "", baglanti);            
            baglanti.Open();
            kmt.ExecuteNonQuery();
            baglanti.Close();

            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLCARI where ID=" + id + "", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);

            double bakiye = Convert.ToDouble(da.Rows[0]["BAKIYE"].ToString());
            bakiye = bakiye - (borc - alacak);
            kmt = new OleDbCommand("update TBLCARI set BAKIYE=@BAKIYE where ID=" + id + "", baglanti);
            kmt.Parameters.AddWithValue("BAKIYE", bakiye);
            baglanti.Open();
            kmt.ExecuteNonQuery();
            baglanti.Close();

            göster();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                var rowH = gridView1.FocusedRowHandle;
                var focusRowView = (DataRowView)gridView1.GetFocusedRow();
                if (focusRowView == null || focusRowView.IsNew) return;

                if (rowH >= 0)
                {
                    popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
        }
    }
}
