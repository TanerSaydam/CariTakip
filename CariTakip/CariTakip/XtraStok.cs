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
    public partial class XtraStok : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Data\db.mdb");

        public XtraStok st;
        public XtraAnaSayfa af;
        public XtraCari ca;       
        public XtraStok()
        {
            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraStok_Load(object sender, EventArgs e)
        {
            göster();
            TxtStokAdı.Focus();
        }

        void göster()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLSTOK order by STOK", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);

            gridControl1.DataSource = da;
            kaydet = true;
            g_id = 0;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (kaydet == true)
            {
                OleDbCommand kontrol = new OleDbCommand("Select * From TBLSTOK where STOK='" + TxtStokAdı.Text + "'", baglanti);
                OleDbDataReader dr;
                baglanti.Open();
                dr = kontrol.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu stok adı daha önce kaydedilmiş.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                    TxtStokAdı.Focus();
                    return;
                }
                baglanti.Close();

                if (MessageBox.Show("Stok adını kaydetmek istiyor musunuz?", "Kaydet?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbCommand kmt = new OleDbCommand("insert into TBLSTOK(STOK,GELIRGIDER,TUTAR) VALUES(@STOK,@GELIRGIDER,@TUTAR)", baglanti);
                    kmt.Parameters.AddWithValue("@STOK", TxtStokAdı.Text);
                    if (rbGelir.Checked == true)
                    {
                        kmt.Parameters.AddWithValue("@GELIRGIDER", "GELIR");
                    }
                    else
                    {
                        kmt.Parameters.AddWithValue("@GELIRGIDER", "GIDER");
                    }

                    kmt.Parameters.AddWithValue("@TUTAR", Convert.ToDouble(TxtBirimFiyat.Text));
                    baglanti.Open();
                    kmt.ExecuteNonQuery();
                    baglanti.Close();


                    TxtStokAdı.Text = "";
                    TxtBirimFiyat.Text = "0";
                    TxtStokAdı.Focus();
                    göster();
                }                
            }
            else
            {
                if (MessageBox.Show("Stok kaydını güncellemek istiyor musunuz?", "Kaydet?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbCommand kmt = new OleDbCommand("update TBLSTOK set STOK=@STOK,GELIRGIDER=@GELIRGIDER,TUTAR=@TUTAR where ID=" + g_id + "", baglanti);
                    kmt.Parameters.AddWithValue("@STOK", TxtStokAdı.Text);
                    if (rbGelir.Checked == true)
                    {
                        kmt.Parameters.AddWithValue("@GELIRGIDER", "GELIR");
                    }
                    else
                    {
                        kmt.Parameters.AddWithValue("@GELIRGIDER", "GIDER");
                    }

                    kmt.Parameters.AddWithValue("@TUTAR", Convert.ToDouble(TxtBirimFiyat.Text));
                    baglanti.Open();
                    kmt.ExecuteNonQuery();
                    baglanti.Close();
                    temizle();
                    göster();
                }
            }

        }
        
        void temizle()
        {
            TxtStokAdı.Text = "";
            TxtBirimFiyat.Text = "0";
            TxtStokAdı.Focus();
            kaydet = true;
            BtnTemizle.Enabled = false;
        }

        private void TxtStokAdı_Leave(object sender, EventArgs e)
        {
            TxtStokAdı.Text = TxtStokAdı.Text.ToUpper();
        }

        private void BtnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Stok kaydını silmek istiyor musunuz?","Sil?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
                OleDbCommand sil = new OleDbCommand("delete from TBLSTOK where ID=" + id + "", baglanti);
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();

                göster();
            }
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

        int g_id = 0;
        bool kaydet = true;
        private void BtnGüncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            g_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
            TxtStokAdı.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            TxtBirimFiyat.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            string gg = gridView1.GetFocusedRowCellValue("GELIRGIDER").ToString();
            if (gg == "GELIR")
            {
                rbGelir.Checked = true;
            }
            else
            {
                rbGider.Checked = true;
            }
            TxtStokAdı.Focus();
            BtnTemizle.Enabled = true;
            kaydet = false;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
