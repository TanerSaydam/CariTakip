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
    public partial class XtraAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Data\db.mdb");
        public XtraAnaSayfa af;
        public XtraCari ca;
        public XtraCariHareket ch;
        public XtraStok st;
        private Point barManager1;

        public XtraAnaSayfa()
        {
            InitializeComponent();
        }

        private void XtraAnaSayfa_Load(object sender, EventArgs e)
        {
            göster();
        }

        public void göster()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From TBLCARI where DURUM=true order by ADISOYADI", baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);

            gC1.DataSource = da;
        }

        private void BtnCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ca = new XtraCari();
            ca.af = this;
            ca.Show();
        }

        private void BtnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnStokEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            st = new XtraStok();
            st.Show();
        }

        private void BtnİşlemYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ch = new XtraCariHareket();
            ch.af = this;
            ch.id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
            ch.Show();
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
                    popupMenu1.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
        }
    }
}