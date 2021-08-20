
namespace CariTakip
{
    partial class XtraAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraAnaSayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnCariEkle = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStokEkle = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKapat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnİşlemYap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gC1 = new DevExpress.XtraGrid.GridControl();
            this.tBLCARIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new CariTakip.dbDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADISOYADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDURUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tBLCARIHAREKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLCARITableAdapter = new CariTakip.dbDataSetTableAdapters.TBLCARITableAdapter();
            this.tBLCARIHAREKETTableAdapter = new CariTakip.dbDataSetTableAdapters.TBLCARIHAREKETTableAdapter();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCARIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCARIHAREKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnCariEkle,
            this.BtnStokEkle,
            this.BtnKapat,
            this.BtnİşlemYap});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1029, 150);
            // 
            // BtnCariEkle
            // 
            this.BtnCariEkle.Caption = "Cari Ekle";
            this.BtnCariEkle.Id = 5;
            this.BtnCariEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCariEkle.ImageOptions.Image")));
            this.BtnCariEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCariEkle.ImageOptions.LargeImage")));
            this.BtnCariEkle.Name = "BtnCariEkle";
            this.BtnCariEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCariEkle_ItemClick);
            // 
            // BtnStokEkle
            // 
            this.BtnStokEkle.Caption = "Stok Ekle";
            this.BtnStokEkle.Id = 6;
            this.BtnStokEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStokEkle.ImageOptions.Image")));
            this.BtnStokEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStokEkle.ImageOptions.LargeImage")));
            this.BtnStokEkle.Name = "BtnStokEkle";
            this.BtnStokEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnStokEkle_ItemClick);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Caption = "Kapat";
            this.BtnKapat.Id = 9;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.LargeImage")));
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKapat_ItemClick);
            // 
            // BtnİşlemYap
            // 
            this.BtnİşlemYap.Caption = "İşlem Yap";
            this.BtnİşlemYap.Id = 10;
            this.BtnİşlemYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnİşlemYap.ImageOptions.Image")));
            this.BtnİşlemYap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnİşlemYap.ImageOptions.LargeImage")));
            this.BtnİşlemYap.Name = "BtnİşlemYap";
            this.BtnİşlemYap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnİşlemYap_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cari Hareket Takip Formu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnCariEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStokEkle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kayıt İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnKapat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Çıkış";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gC1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 150);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1029, 527);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gC1
            // 
            this.gC1.DataSource = this.tBLCARIBindingSource;
            this.gC1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gC1.Location = new System.Drawing.Point(12, 12);
            this.gC1.MainView = this.gridView1;
            this.gC1.Margin = new System.Windows.Forms.Padding(4);
            this.gC1.MenuManager = this.ribbonControl1;
            this.gC1.Name = "gC1";
            this.gC1.Size = new System.Drawing.Size(1005, 503);
            this.gC1.TabIndex = 4;
            this.gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLCARIBindingSource
            // 
            this.tBLCARIBindingSource.DataMember = "TBLCARI";
            this.tBLCARIBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colADISOYADI,
            this.colBAKIYE,
            this.colDURUM});
            this.gridView1.DetailHeight = 512;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gC1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Width = 112;
            // 
            // colADISOYADI
            // 
            this.colADISOYADI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colADISOYADI.AppearanceCell.Options.UseFont = true;
            this.colADISOYADI.AppearanceCell.Options.UseTextOptions = true;
            this.colADISOYADI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colADISOYADI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADISOYADI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colADISOYADI.AppearanceHeader.Options.UseFont = true;
            this.colADISOYADI.AppearanceHeader.Options.UseTextOptions = true;
            this.colADISOYADI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colADISOYADI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colADISOYADI.Caption = "Adı Soyadı";
            this.colADISOYADI.FieldName = "ADISOYADI";
            this.colADISOYADI.MinWidth = 30;
            this.colADISOYADI.Name = "colADISOYADI";
            this.colADISOYADI.OptionsColumn.FixedWidth = true;
            this.colADISOYADI.Visible = true;
            this.colADISOYADI.VisibleIndex = 0;
            this.colADISOYADI.Width = 112;
            // 
            // colBAKIYE
            // 
            this.colBAKIYE.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.colBAKIYE.AppearanceCell.Options.UseFont = true;
            this.colBAKIYE.AppearanceCell.Options.UseTextOptions = true;
            this.colBAKIYE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBAKIYE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBAKIYE.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBAKIYE.AppearanceHeader.Options.UseFont = true;
            this.colBAKIYE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBAKIYE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBAKIYE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBAKIYE.Caption = "Bakiye";
            this.colBAKIYE.DisplayFormat.FormatString = "n2";
            this.colBAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBAKIYE.FieldName = "BAKIYE";
            this.colBAKIYE.MinWidth = 30;
            this.colBAKIYE.Name = "colBAKIYE";
            this.colBAKIYE.OptionsColumn.FixedWidth = true;
            this.colBAKIYE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BAKIYE", "Toplam: {0:c2}")});
            this.colBAKIYE.Visible = true;
            this.colBAKIYE.VisibleIndex = 1;
            this.colBAKIYE.Width = 112;
            // 
            // colDURUM
            // 
            this.colDURUM.Caption = "Durum";
            this.colDURUM.FieldName = "DURUM";
            this.colDURUM.MinWidth = 30;
            this.colDURUM.Name = "colDURUM";
            this.colDURUM.Width = 112;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1029, 527);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gC1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1009, 507);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tBLCARIHAREKETBindingSource
            // 
            this.tBLCARIHAREKETBindingSource.DataMember = "TBLCARIHAREKET";
            this.tBLCARIHAREKETBindingSource.DataSource = this.dbDataSet;
            // 
            // tBLCARITableAdapter
            // 
            this.tBLCARITableAdapter.ClearBeforeFill = true;
            // 
            // tBLCARIHAREKETTableAdapter
            // 
            this.tBLCARIHAREKETTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.BtnİşlemYap);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // XtraAnaSayfa
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 677);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XtraAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hareket Formu || Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCARIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCARIHAREKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gC1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem BtnCariEkle;
        private DevExpress.XtraBars.BarButtonItem BtnStokEkle;        
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnKapat;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tBLCARIBindingSource;
        private dbDataSetTableAdapters.TBLCARITableAdapter tBLCARITableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colADISOYADI;
        private DevExpress.XtraGrid.Columns.GridColumn colBAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn colDURUM;
        private System.Windows.Forms.BindingSource tBLCARIHAREKETBindingSource;
        private dbDataSetTableAdapters.TBLCARIHAREKETTableAdapter tBLCARIHAREKETTableAdapter;
        private DevExpress.XtraBars.BarButtonItem BtnİşlemYap;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}