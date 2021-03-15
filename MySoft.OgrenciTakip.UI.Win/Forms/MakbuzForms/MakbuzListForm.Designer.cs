﻿namespace MySoft.OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    partial class MakbuzListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakbuzListForm));
            this.longNavigator = new MySoft.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colMakbuzNo = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colTarih = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHesapTuru = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colMakbuzTuru = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHareketSayisi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colMakbuzToplami = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHesapAdi = new MySoft.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryHareketSayisi = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHareketSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(809, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // barSubItem1
            // 
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            // 
            // barSubItem2
            // 
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            // 
            // barSubItem3
            // 
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            // 
            // barSubItem4
            // 
            this.barSubItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem4.ImageOptions.Image")));
            // 
            // barSubItem5
            // 
            this.barSubItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem5.ImageOptions.Image")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 430);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(809, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDecimal,
            this.repositoryTarih,
            this.repositoryHareketSayisi});
            this.grid.Size = new System.Drawing.Size(809, 328);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
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
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMakbuzNo,
            this.colTarih,
            this.colHesapTuru,
            this.colMakbuzTuru,
            this.colHareketSayisi,
            this.colMakbuzToplami,
            this.colHesapAdi});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Makbuz Kartları";
            // 
            // colMakbuzNo
            // 
            this.colMakbuzNo.Caption = "Makbuz No";
            this.colMakbuzNo.FieldName = "Kod";
            this.colMakbuzNo.Name = "colMakbuzNo";
            this.colMakbuzNo.OptionsColumn.AllowEdit = false;
            this.colMakbuzNo.StatusBarAciklama = null;
            this.colMakbuzNo.StatusBarKisaYol = null;
            this.colMakbuzNo.StatusBarKisaYolAciklama = null;
            this.colMakbuzNo.Visible = true;
            this.colMakbuzNo.VisibleIndex = 0;
            this.colMakbuzNo.Width = 90;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisaYol = null;
            this.colTarih.StatusBarKisaYolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 90;
            // 
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsColumn.AllowEdit = false;
            this.colHesapTuru.StatusBarAciklama = null;
            this.colHesapTuru.StatusBarKisaYol = null;
            this.colHesapTuru.StatusBarKisaYolAciklama = null;
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.VisibleIndex = 2;
            this.colHesapTuru.Width = 90;
            // 
            // colMakbuzTuru
            // 
            this.colMakbuzTuru.Caption = "Makbuz Turu";
            this.colMakbuzTuru.FieldName = "MakbuzTuru";
            this.colMakbuzTuru.Name = "colMakbuzTuru";
            this.colMakbuzTuru.OptionsColumn.AllowEdit = false;
            this.colMakbuzTuru.StatusBarAciklama = null;
            this.colMakbuzTuru.StatusBarKisaYol = null;
            this.colMakbuzTuru.StatusBarKisaYolAciklama = null;
            this.colMakbuzTuru.Visible = true;
            this.colMakbuzTuru.VisibleIndex = 3;
            this.colMakbuzTuru.Width = 200;
            // 
            // colHareketSayisi
            // 
            this.colHareketSayisi.Caption = "Hareket";
            this.colHareketSayisi.ColumnEdit = this.repositoryHareketSayisi;
            this.colHareketSayisi.FieldName = "HareketSayisi";
            this.colHareketSayisi.Name = "colHareketSayisi";
            this.colHareketSayisi.OptionsColumn.AllowEdit = false;
            this.colHareketSayisi.StatusBarAciklama = null;
            this.colHareketSayisi.StatusBarKisaYol = null;
            this.colHareketSayisi.StatusBarKisaYolAciklama = null;
            this.colHareketSayisi.Visible = true;
            this.colHareketSayisi.VisibleIndex = 4;
            this.colHareketSayisi.Width = 90;
            // 
            // colMakbuzToplami
            // 
            this.colMakbuzToplami.Caption = "Makbuz Toplami";
            this.colMakbuzToplami.ColumnEdit = this.repositoryDecimal;
            this.colMakbuzToplami.FieldName = "MakbuzToplami";
            this.colMakbuzToplami.Name = "colMakbuzToplami";
            this.colMakbuzToplami.OptionsColumn.AllowEdit = false;
            this.colMakbuzToplami.StatusBarAciklama = null;
            this.colMakbuzToplami.StatusBarKisaYol = null;
            this.colMakbuzToplami.StatusBarKisaYolAciklama = null;
            this.colMakbuzToplami.Visible = true;
            this.colMakbuzToplami.VisibleIndex = 5;
            this.colMakbuzToplami.Width = 120;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsColumn.AllowEdit = false;
            this.colHesapAdi.StatusBarAciklama = null;
            this.colHesapAdi.StatusBarKisaYol = null;
            this.colHesapAdi.StatusBarKisaYolAciklama = null;
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 6;
            this.colHesapAdi.Width = 200;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "n2";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "n2";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
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
            // repositoryHareketSayisi
            // 
            this.repositoryHareketSayisi.AutoHeight = false;
            this.repositoryHareketSayisi.DisplayFormat.FormatString = "{0:n0}";
            this.repositoryHareketSayisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryHareketSayisi.Name = "repositoryHareketSayisi";
            // 
            // MakbuzListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 485);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "MakbuzListForm";
            this.Text = "Makbuz Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHareketSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colMakbuzNo;
        private UserControls.Grid.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private UserControls.Grid.MyGridColumn colHesapTuru;
        private UserControls.Grid.MyGridColumn colMakbuzTuru;
        private UserControls.Grid.MyGridColumn colHareketSayisi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryHareketSayisi;
        private UserControls.Grid.MyGridColumn colMakbuzToplami;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private UserControls.Grid.MyGridColumn colHesapAdi;
    }
}