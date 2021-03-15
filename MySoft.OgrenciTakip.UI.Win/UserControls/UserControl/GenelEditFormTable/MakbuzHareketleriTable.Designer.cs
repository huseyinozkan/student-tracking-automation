﻿namespace MySoft.OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    partial class MakbuzHareketleriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colOgrenciNo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSinifAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOgrenciSubeAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colPortfoyNo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBelgeSubeAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOdemeTuruAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaHesapAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTakipNo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colGirisTarihi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVade = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colHesabaGecisTarihi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTutar = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIslemOncesiTutar = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIslemTutari = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBelgeDurum = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaSubeAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBelgeNo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colHesapNo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAsilBorclu = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colCiranta = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bndBelgeDetayBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 365);
            this.insUptNavigator.Size = new System.Drawing.Size(666, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(666, 365);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 20;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.bndBelgeDetayBilgileri});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOgrenciNo,
            this.colAdi,
            this.colSoyadi,
            this.colSinifAdi,
            this.colOgrenciSubeAdi,
            this.colBelgeSubeAdi,
            this.colOdemeTuruAdi,
            this.colBankaHesapAdi,
            this.colTakipNo,
            this.colPortfoyNo,
            this.colGirisTarihi,
            this.colVade,
            this.colHesabaGecisTarihi,
            this.colTutar,
            this.colIslemOncesiTutar,
            this.colIslemTutari,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colBelgeNo,
            this.colHesapNo,
            this.colAsilBorclu,
            this.colCiranta,
            this.colBelgeDurum});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "İşlem Yapılacak Belgeleri Seçiniz";
            this.tablo.StatusBarKisaYol = "Shift + Insert : ";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "Makbuz Hareketleri";
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.Caption = "No";
            this.colOgrenciNo.CustomizationCaption = "Ogrenci No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisaYol = null;
            this.colOgrenciNo.StatusBarKisaYolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadi";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 100;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sinif Adi";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 100;
            // 
            // colOgrenciSubeAdi
            // 
            this.colOgrenciSubeAdi.Caption = "Sube Adi";
            this.colOgrenciSubeAdi.CustomizationCaption = "Ogrenci Sube Adi";
            this.colOgrenciSubeAdi.FieldName = "OgrenciSubeAdi";
            this.colOgrenciSubeAdi.Name = "colOgrenciSubeAdi";
            this.colOgrenciSubeAdi.OptionsColumn.AllowEdit = false;
            this.colOgrenciSubeAdi.StatusBarAciklama = null;
            this.colOgrenciSubeAdi.StatusBarKisaYol = null;
            this.colOgrenciSubeAdi.StatusBarKisaYolAciklama = null;
            this.colOgrenciSubeAdi.Visible = true;
            this.colOgrenciSubeAdi.Width = 200;
            // 
            // colPortfoyNo
            // 
            this.colPortfoyNo.Caption = "Portfoy No";
            this.colPortfoyNo.FieldName = "OdemeBilgileriId";
            this.colPortfoyNo.Name = "colPortfoyNo";
            this.colPortfoyNo.OptionsColumn.AllowEdit = false;
            this.colPortfoyNo.StatusBarAciklama = null;
            this.colPortfoyNo.StatusBarKisaYol = null;
            this.colPortfoyNo.StatusBarKisaYolAciklama = null;
            this.colPortfoyNo.Visible = true;
            this.colPortfoyNo.Width = 100;
            // 
            // colBelgeSubeAdi
            // 
            this.colBelgeSubeAdi.Caption = "Sube Adi";
            this.colBelgeSubeAdi.CustomizationCaption = "Belge Sube Adi";
            this.colBelgeSubeAdi.FieldName = "BelgeSubeAdi";
            this.colBelgeSubeAdi.Name = "colBelgeSubeAdi";
            this.colBelgeSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBelgeSubeAdi.StatusBarAciklama = null;
            this.colBelgeSubeAdi.StatusBarKisaYol = null;
            this.colBelgeSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBelgeSubeAdi.Visible = true;
            this.colBelgeSubeAdi.Width = 200;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Odeme Turu";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.StatusBarAciklama = null;
            this.colOdemeTuruAdi.StatusBarKisaYol = null;
            this.colOdemeTuruAdi.StatusBarKisaYolAciklama = null;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.Width = 100;
            // 
            // colBankaHesapAdi
            // 
            this.colBankaHesapAdi.Caption = "Hesap Adi";
            this.colBankaHesapAdi.CustomizationCaption = "Banka Hesap Adi";
            this.colBankaHesapAdi.FieldName = "BankaHesapAdi";
            this.colBankaHesapAdi.Name = "colBankaHesapAdi";
            this.colBankaHesapAdi.OptionsColumn.AllowEdit = false;
            this.colBankaHesapAdi.StatusBarAciklama = null;
            this.colBankaHesapAdi.StatusBarKisaYol = null;
            this.colBankaHesapAdi.StatusBarKisaYolAciklama = null;
            this.colBankaHesapAdi.Visible = true;
            this.colBankaHesapAdi.Width = 200;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TakipNo";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.OptionsColumn.AllowEdit = false;
            this.colTakipNo.StatusBarAciklama = null;
            this.colTakipNo.StatusBarKisaYol = null;
            this.colTakipNo.StatusBarKisaYolAciklama = null;
            this.colTakipNo.Visible = true;
            this.colTakipNo.Width = 100;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.Caption = "Giris Tarihi";
            this.colGirisTarihi.ColumnEdit = this.repositoryTarih;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.StatusBarAciklama = null;
            this.colGirisTarihi.StatusBarKisaYol = null;
            this.colGirisTarihi.StatusBarKisaYolAciklama = null;
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.Width = 100;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colVade
            // 
            this.colVade.AppearanceCell.Options.UseTextOptions = true;
            this.colVade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVade.Caption = "Vade";
            this.colVade.ColumnEdit = this.repositoryTarih;
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.OptionsColumn.AllowEdit = false;
            this.colVade.StatusBarAciklama = null;
            this.colVade.StatusBarKisaYol = null;
            this.colVade.StatusBarKisaYolAciklama = null;
            this.colVade.Visible = true;
            this.colVade.Width = 100;
            // 
            // colHesabaGecisTarihi
            // 
            this.colHesabaGecisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colHesabaGecisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesabaGecisTarihi.Caption = "H. Gecis Tarihi";
            this.colHesabaGecisTarihi.ColumnEdit = this.repositoryTarih;
            this.colHesabaGecisTarihi.FieldName = "HesabaGecisTarihi";
            this.colHesabaGecisTarihi.Name = "colHesabaGecisTarihi";
            this.colHesabaGecisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesabaGecisTarihi.StatusBarAciklama = null;
            this.colHesabaGecisTarihi.StatusBarKisaYol = null;
            this.colHesabaGecisTarihi.StatusBarKisaYolAciklama = null;
            this.colHesabaGecisTarihi.Visible = true;
            this.colHesabaGecisTarihi.Width = 100;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryDecimal;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.Width = 100;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colIslemOncesiTutar
            // 
            this.colIslemOncesiTutar.Caption = "Kalan";
            this.colIslemOncesiTutar.ColumnEdit = this.repositoryDecimal;
            this.colIslemOncesiTutar.FieldName = "IslemOncesiTutar";
            this.colIslemOncesiTutar.Name = "colIslemOncesiTutar";
            this.colIslemOncesiTutar.OptionsColumn.AllowEdit = false;
            this.colIslemOncesiTutar.StatusBarAciklama = null;
            this.colIslemOncesiTutar.StatusBarKisaYol = null;
            this.colIslemOncesiTutar.StatusBarKisaYolAciklama = null;
            this.colIslemOncesiTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IslemOncesiTutar", "{0:n2}")});
            this.colIslemOncesiTutar.Visible = true;
            this.colIslemOncesiTutar.Width = 100;
            // 
            // colIslemTutari
            // 
            this.colIslemTutari.Caption = "IslemTutari";
            this.colIslemTutari.ColumnEdit = this.repositoryDecimal;
            this.colIslemTutari.FieldName = "IslemTutari";
            this.colIslemTutari.Name = "colIslemTutari";
            this.colIslemTutari.OptionsColumn.AllowEdit = false;
            this.colIslemTutari.StatusBarAciklama = "Tutar Giriniz";
            this.colIslemTutari.StatusBarKisaYol = "F4 : ";
            this.colIslemTutari.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.colIslemTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IslemTutari", "{0:n2}")});
            this.colIslemTutari.Visible = true;
            this.colIslemTutari.Width = 100;
            // 
            // colBelgeDurum
            // 
            this.colBelgeDurum.Caption = "Durum";
            this.colBelgeDurum.FieldName = "BelgeDurumu";
            this.colBelgeDurum.Name = "colBelgeDurum";
            this.colBelgeDurum.OptionsColumn.AllowEdit = false;
            this.colBelgeDurum.StatusBarAciklama = null;
            this.colBelgeDurum.StatusBarKisaYol = null;
            this.colBelgeDurum.StatusBarKisaYolAciklama = null;
            this.colBelgeDurum.Visible = true;
            this.colBelgeDurum.Width = 200;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 200;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Sube Adi";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 200;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.Width = 100;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.Width = 100;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.Caption = "Asil Borclu";
            this.colAsilBorclu.FieldName = "AsilBorclu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.OptionsColumn.AllowEdit = false;
            this.colAsilBorclu.StatusBarAciklama = null;
            this.colAsilBorclu.StatusBarKisaYol = null;
            this.colAsilBorclu.StatusBarKisaYolAciklama = null;
            this.colAsilBorclu.Visible = true;
            this.colAsilBorclu.Width = 200;
            // 
            // colCiranta
            // 
            this.colCiranta.Caption = "Ciranta";
            this.colCiranta.FieldName = "Ciranta";
            this.colCiranta.Name = "colCiranta";
            this.colCiranta.OptionsColumn.AllowEdit = false;
            this.colCiranta.StatusBarAciklama = null;
            this.colCiranta.StatusBarKisaYol = null;
            this.colCiranta.StatusBarKisaYolAciklama = null;
            this.colCiranta.Visible = true;
            this.colCiranta.Width = 200;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colOgrenciNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colSinifAdi);
            this.gridBand1.Columns.Add(this.colOgrenciSubeAdi);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 600;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Belge Genel Bilgiler";
            this.gridBand2.Columns.Add(this.colPortfoyNo);
            this.gridBand2.Columns.Add(this.colBelgeSubeAdi);
            this.gridBand2.Columns.Add(this.colOdemeTuruAdi);
            this.gridBand2.Columns.Add(this.colBankaHesapAdi);
            this.gridBand2.Columns.Add(this.colTakipNo);
            this.gridBand2.Columns.Add(this.colGirisTarihi);
            this.gridBand2.Columns.Add(this.colVade);
            this.gridBand2.Columns.Add(this.colHesabaGecisTarihi);
            this.gridBand2.Columns.Add(this.colTutar);
            this.gridBand2.Columns.Add(this.colIslemOncesiTutar);
            this.gridBand2.Columns.Add(this.colIslemTutari);
            this.gridBand2.Columns.Add(this.colBelgeDurum);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1500;
            // 
            // bndBelgeDetayBilgileri
            // 
            this.bndBelgeDetayBilgileri.Caption = "Belge Detay Bilgiler";
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBankaAdi);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBankaSubeAdi);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBelgeNo);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colHesapNo);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colAsilBorclu);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colCiranta);
            this.bndBelgeDetayBilgileri.Name = "bndBelgeDetayBilgileri";
            this.bndBelgeDetayBilgileri.VisibleIndex = 2;
            this.bndBelgeDetayBilgileri.Width = 1000;
            // 
            // MakbuzHareketleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MakbuzHareketleriTable";
            this.Size = new System.Drawing.Size(666, 389);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private Grid.MyBandedGridColumn colOgrenciNo;
        private Grid.MyBandedGridColumn colAdi;
        private Grid.MyBandedGridColumn colSoyadi;
        private Grid.MyBandedGridColumn colSinifAdi;
        private Grid.MyBandedGridColumn colOgrenciSubeAdi;
        private Grid.MyBandedGridColumn colPortfoyNo;
        private Grid.MyBandedGridColumn colBelgeSubeAdi;
        private Grid.MyBandedGridColumn colOdemeTuruAdi;
        private Grid.MyBandedGridColumn colBankaHesapAdi;
        private Grid.MyBandedGridColumn colTakipNo;
        private Grid.MyBandedGridColumn colGirisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyBandedGridColumn colVade;
        private Grid.MyBandedGridColumn colHesabaGecisTarihi;
        private Grid.MyBandedGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private Grid.MyBandedGridColumn colIslemOncesiTutar;
        private Grid.MyBandedGridColumn colBelgeDurum;
        private Grid.MyBandedGridColumn colBankaAdi;
        private Grid.MyBandedGridColumn colBankaSubeAdi;
        private Grid.MyBandedGridColumn colBelgeNo;
        private Grid.MyBandedGridColumn colHesapNo;
        private Grid.MyBandedGridColumn colAsilBorclu;
        private Grid.MyBandedGridColumn colCiranta;
        protected internal Grid.MyBandedGridColumn colIslemTutari;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndBelgeDetayBilgileri;
    }
}
