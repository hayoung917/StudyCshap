﻿namespace BookRentalShopApp2020.SubItems
{
    partial class BooksMngForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdBooksTbl = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtRealeasDate = new MetroFramework.Controls.MetroDateTime();
            this.CboDivision = new MetroFramework.Controls.MetroComboBox();
            this.BtnCancle = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtIsbn = new MetroFramework.Controls.MetroTextBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdBooksTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(821, 653);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdBooksTbl
            // 
            this.GrdBooksTbl.AllowUserToAddRows = false;
            this.GrdBooksTbl.AllowUserToDeleteRows = false;
            this.GrdBooksTbl.AllowUserToResizeRows = false;
            this.GrdBooksTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.GrdBooksTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdBooksTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdBooksTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdBooksTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdBooksTbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdBooksTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBooksTbl.EnableHeadersVisualStyles = false;
            this.GrdBooksTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdBooksTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBooksTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdBooksTbl.Name = "GrdBooksTbl";
            this.GrdBooksTbl.ReadOnly = true;
            this.GrdBooksTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdBooksTbl.RowHeadersWidth = 62;
            this.GrdBooksTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdBooksTbl.RowTemplate.Height = 30;
            this.GrdBooksTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdBooksTbl.Size = new System.Drawing.Size(408, 653);
            this.GrdBooksTbl.Style = MetroFramework.MetroColorStyle.Orange;
            this.GrdBooksTbl.TabIndex = 0;
            this.GrdBooksTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtRealeasDate);
            this.groupBox1.Controls.Add(this.CboDivision);
            this.groupBox1.Controls.Add(this.BtnCancle);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.TxtIsbn);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.TxtAuthor);
            this.groupBox1.Controls.Add(this.TxtIdx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 653);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // DtRealeasDate
            // 
            this.DtRealeasDate.Location = new System.Drawing.Point(138, 214);
            this.DtRealeasDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtRealeasDate.Name = "DtRealeasDate";
            this.DtRealeasDate.Size = new System.Drawing.Size(265, 29);
            this.DtRealeasDate.TabIndex = 11;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 23;
            this.CboDivision.Location = new System.Drawing.Point(137, 125);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(266, 29);
            this.CboDivision.TabIndex = 2;
            this.CboDivision.UseSelectable = true;
            // 
            // BtnCancle
            // 
            this.BtnCancle.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCancle.Location = new System.Drawing.Point(331, 358);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(75, 37);
            this.BtnCancle.TabIndex = 10;
            this.BtnCancle.Text = "취소";
            this.BtnCancle.UseSelectable = true;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSave.Location = new System.Drawing.Point(233, 358);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 37);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNew.Location = new System.Drawing.Point(135, 358);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 37);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDelete.Location = new System.Drawing.Point(37, 358);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 37);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(14, 302);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 37);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "가격 : ";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(14, 261);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 37);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "ISBN : ";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(14, 172);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 37);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "이름 : ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(14, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 37);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "저자명 : ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(14, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 32);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "출간일 : ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(14, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(117, 32);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "장르 : ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(14, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 32);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "번호 : ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(137, 302);
            this.TxtPrice.MaxLength = 45;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(266, 28);
            this.TxtPrice.TabIndex = 6;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIsbn
            // 
            // 
            // 
            // 
            this.TxtIsbn.CustomButton.Image = null;
            this.TxtIsbn.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.TxtIsbn.CustomButton.Name = "";
            this.TxtIsbn.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIsbn.CustomButton.TabIndex = 1;
            this.TxtIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIsbn.CustomButton.UseSelectable = true;
            this.TxtIsbn.CustomButton.Visible = false;
            this.TxtIsbn.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIsbn.Lines = new string[0];
            this.TxtIsbn.Location = new System.Drawing.Point(137, 261);
            this.TxtIsbn.MaxLength = 13;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.PasswordChar = '\0';
            this.TxtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIsbn.SelectedText = "";
            this.TxtIsbn.SelectionLength = 0;
            this.TxtIsbn.SelectionStart = 0;
            this.TxtIsbn.ShortcutsEnabled = true;
            this.TxtIsbn.Size = new System.Drawing.Size(266, 28);
            this.TxtIsbn.TabIndex = 5;
            this.TxtIsbn.UseSelectable = true;
            this.TxtIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(137, 172);
            this.TxtNames.MaxLength = 100;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(266, 28);
            this.TxtNames.TabIndex = 3;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(137, 80);
            this.TxtAuthor.MaxLength = 45;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = true;
            this.TxtAuthor.Size = new System.Drawing.Size(266, 28);
            this.TxtAuthor.TabIndex = 1;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(137, 30);
            this.TxtIdx.MaxLength = 12;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(266, 28);
            this.TxtIdx.TabIndex = 0;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BooksMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 733);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BooksMngForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "BooksMngForm";
            this.Load += new System.EventHandler(this.DivMngForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdBooksTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroButton BtnCancle;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroTextBox TxtIsbn;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroComboBox CboDivision;
        private MetroFramework.Controls.MetroDateTime DtRealeasDate;
    }
}