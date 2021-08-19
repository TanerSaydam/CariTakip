
namespace CariTakip
{
    partial class XtraStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraStok));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLSTOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new CariTakip.dbDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGELIRGIDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBirimFiyat = new DevExpress.XtraEditors.TextEdit();
            this.rbGelir = new System.Windows.Forms.RadioButton();
            this.rbGider = new System.Windows.Forms.RadioButton();
            this.TxtStokAdı = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tBLSTOKTableAdapter = new CariTakip.dbDataSetTableAdapters.TBLSTOKTableAdapter();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BtnGüncelle = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBirimFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnTemizle);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.BtnKapat);
            this.layoutControl1.Controls.Add(this.BtnKaydet);
            this.layoutControl1.Controls.Add(this.TxtBirimFiyat);
            this.layoutControl1.Controls.Add(this.rbGelir);
            this.layoutControl1.Controls.Add(this.rbGider);
            this.layoutControl1.Controls.Add(this.TxtStokAdı);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(612, 681);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Enabled = false;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(12, 141);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(588, 36);
            this.BtnTemizle.StyleController = this.layoutControl1;
            this.BtnTemizle.TabIndex = 11;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLSTOKBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 221);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(588, 448);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLSTOKBindingSource
            // 
            this.tBLSTOKBindingSource.DataMember = "TBLSTOK";
            this.tBLSTOKBindingSource.DataSource = this.dbDataSet;
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
            this.colSTOK,
            this.colGELIRGIDER,
            this.colTUTAR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colSTOK
            // 
            this.colSTOK.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSTOK.AppearanceCell.Options.UseFont = true;
            this.colSTOK.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSTOK.AppearanceHeader.Options.UseFont = true;
            this.colSTOK.Caption = "Stok Adı";
            this.colSTOK.FieldName = "STOK";
            this.colSTOK.Name = "colSTOK";
            this.colSTOK.Visible = true;
            this.colSTOK.VisibleIndex = 0;
            // 
            // colGELIRGIDER
            // 
            this.colGELIRGIDER.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGELIRGIDER.AppearanceCell.Options.UseFont = true;
            this.colGELIRGIDER.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGELIRGIDER.AppearanceHeader.Options.UseFont = true;
            this.colGELIRGIDER.Caption = "Gelir / Gider";
            this.colGELIRGIDER.FieldName = "GELIRGIDER";
            this.colGELIRGIDER.Name = "colGELIRGIDER";
            this.colGELIRGIDER.Visible = true;
            this.colGELIRGIDER.VisibleIndex = 1;
            // 
            // colTUTAR
            // 
            this.colTUTAR.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTUTAR.AppearanceCell.Options.UseFont = true;
            this.colTUTAR.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTUTAR.AppearanceHeader.Options.UseFont = true;
            this.colTUTAR.Caption = "Birim Fiyat";
            this.colTUTAR.DisplayFormat.FormatString = "n2";
            this.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 2;
            // 
            // BtnKapat
            // 
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(12, 181);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(588, 36);
            this.BtnKapat.StyleController = this.layoutControl1;
            this.BtnKapat.TabIndex = 9;
            this.BtnKapat.TabStop = false;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(12, 101);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(588, 36);
            this.BtnKaydet.StyleController = this.layoutControl1;
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtBirimFiyat
            // 
            this.TxtBirimFiyat.Location = new System.Drawing.Point(82, 42);
            this.TxtBirimFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBirimFiyat.Name = "TxtBirimFiyat";
            this.TxtBirimFiyat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBirimFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtBirimFiyat.Size = new System.Drawing.Size(518, 26);
            this.TxtBirimFiyat.StyleController = this.layoutControl1;
            this.TxtBirimFiyat.TabIndex = 3;
            // 
            // rbGelir
            // 
            this.rbGelir.Location = new System.Drawing.Point(12, 72);
            this.rbGelir.Margin = new System.Windows.Forms.Padding(4);
            this.rbGelir.Name = "rbGelir";
            this.rbGelir.Size = new System.Drawing.Size(292, 25);
            this.rbGelir.TabIndex = 1;
            this.rbGelir.Text = "Gelir";
            this.rbGelir.UseVisualStyleBackColor = true;
            // 
            // rbGider
            // 
            this.rbGider.Checked = true;
            this.rbGider.Location = new System.Drawing.Point(308, 72);
            this.rbGider.Margin = new System.Windows.Forms.Padding(4);
            this.rbGider.Name = "rbGider";
            this.rbGider.Size = new System.Drawing.Size(292, 25);
            this.rbGider.TabIndex = 2;
            this.rbGider.TabStop = true;
            this.rbGider.Text = "Gider";
            this.rbGider.UseVisualStyleBackColor = true;
            // 
            // TxtStokAdı
            // 
            this.TxtStokAdı.Location = new System.Drawing.Point(82, 12);
            this.TxtStokAdı.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStokAdı.Name = "TxtStokAdı";
            this.TxtStokAdı.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStokAdı.Properties.Appearance.Options.UseFont = true;
            this.TxtStokAdı.Size = new System.Drawing.Size(518, 26);
            this.TxtStokAdı.StyleController = this.layoutControl1;
            this.TxtStokAdı.TabIndex = 0;
            this.TxtStokAdı.Leave += new System.EventHandler(this.TxtStokAdı_Leave);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(612, 681);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.TxtStokAdı;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(592, 30);
            this.layoutControlItem1.Text = "Stok Adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rbGider;
            this.layoutControlItem2.Location = new System.Drawing.Point(296, 60);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(296, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BtnKaydet;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(592, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnKapat;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(592, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 209);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(592, 452);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rbGelir;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(296, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.TxtBirimFiyat;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(592, 30);
            this.layoutControlItem4.Text = "Birim Fiyat";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 19);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.BtnTemizle;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(592, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // tBLSTOKTableAdapter
            // 
            this.tBLSTOKTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnGüncelle),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSil)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Caption = "Güncelle";
            this.BtnGüncelle.Id = 0;
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.LargeImage")));
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGüncelle_ItemClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Caption = "Sil";
            this.BtnSil.Id = 1;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.LargeImage")));
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSil_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnGüncelle,
            this.BtnSil});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(612, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 681);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(612, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 681);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(612, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 681);
            // 
            // XtraStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 681);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XtraStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kayıt Formu";
            this.Load += new System.EventHandler(this.XtraStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBirimFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtBirimFiyat;
        private System.Windows.Forms.RadioButton rbGelir;
        private System.Windows.Forms.RadioButton rbGider;
        private DevExpress.XtraEditors.TextEdit TxtStokAdı;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource tBLSTOKBindingSource;
        private dbDataSetTableAdapters.TBLSTOKTableAdapter tBLSTOKTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK;
        private DevExpress.XtraGrid.Columns.GridColumn colGELIRGIDER;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem BtnGüncelle;
        private DevExpress.XtraBars.BarButtonItem BtnSil;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}