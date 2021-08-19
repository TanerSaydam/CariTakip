using DevExpress.XtraEditors;
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
    public partial class XtraCari : DevExpress.XtraEditors.XtraForm
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Data\db.mdb");
        public XtraAnaSayfa af;
        public XtraCari ca;        
             
        public XtraCari()
        {
            InitializeComponent();
        }        

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            af.göster();
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (kaydet == true)
            {
                OleDbCommand kontrol = new OleDbCommand("Select * From TBLCARI where ADISOYADI='" + TxtAdıSoyadı.Text + "'", baglanti);
                OleDbDataReader dr;
                baglanti.Open();
                dr = kontrol.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu isimde kayıtlı bir cari var!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAdıSoyadı.Focus();
                    baglanti.Close();
                    return;
                }

                baglanti.Close();

                if (MessageBox.Show("Kaydetmek istiyor musunuz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbCommand kmt = new OleDbCommand("insert into TBLCARI(ADISOYADI,BORC,ALACAK,DURUM) values(@ADISOYADI,@BORC,@ALACAK,@DURUM)", baglanti);
                    kmt.Parameters.AddWithValue("@ADISOYADI", TxtAdıSoyadı.Text);
                    kmt.Parameters.AddWithValue("@BORC", 0);
                    kmt.Parameters.AddWithValue("@ALACAK", 0);
                    if (cBDurum.Checked == true)
                    {
                        kmt.Parameters.AddWithValue("@DURUM", true);
                    }
                    else
                    {
                        kmt.Parameters.AddWithValue("@DURUM", false);
                    }
                    baglanti.Open();
                    kmt.ExecuteNonQuery();
                    baglanti.Close();

                    göster();                    
                }
            }
            else
            {
                if (MessageBox.Show("Cari kaydı güncellemek istiyor musunuz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbCommand kmt = new OleDbCommand("update TBLCARI set ADISOYADI=@ADISOYADI,DURUM=@DURUM where ID=" + c_id + "", baglanti);
                    kmt.Parameters.AddWithValue("@ADISOYADI", TxtAdıSoyadı.Text);
                    if (cBDurum.Checked==true)
                    {
                        kmt.Parameters.AddWithValue("@DURUM", true);
                    }
                    else
                    {
                        kmt.Parameters.AddWithValue("@DURUM", false);
                    }
                    
                    baglanti.Open();
                    kmt.ExecuteNonQuery();
                    baglanti.Close();

                    göster();                    
                }
            }
            
            
        }

        private void TxtAdıSoyadı_Leave(object sender, EventArgs e)
        {
            TxtAdıSoyadı.Text = TxtAdıSoyadı.Text.ToUpper();
        }

        private void XtraCari_Load(object sender, EventArgs e)
        {
            göster();
        }
        bool kaydet = true;
        int c_id = 0;
        void göster()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLCARI order by ADISOYADI", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);

            kaydet = true;
            BtnTemizle.Enabled = false;
            TxtAdıSoyadı.Text = "";
            cBDurum.Checked = true;
            gC1.DataSource = da;
        }

        private void BtnGüncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            c_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
            TxtAdıSoyadı.Text = gridView1.GetFocusedRowCellValue("ADISOYADI").ToString();
            bool durum = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("DURUM").ToString());
            if (durum == true)
            {
                cBDurum.Checked = true;
            }
            else
            {
                cBDurum.Checked = false;
            }
            kaydet = false;
            TxtAdıSoyadı.Focus();
            BtnTemizle.Enabled = true;
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            göster();
        }

        private void XtraCari_Leave(object sender, EventArgs e)
        {
            af.göster();
        }

        private void XtraCari_FormClosing(object sender, FormClosingEventArgs e)
        {
            af.göster();
        }
    }
}