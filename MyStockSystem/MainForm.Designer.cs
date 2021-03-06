﻿namespace MyStockSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MtlStockAnals = new MetroFramework.Controls.MetroTile();
            this.MtlInvestSimuls = new MetroFramework.Controls.MetroTile();
            this.MtlGalmetgilGuide = new MetroFramework.Controls.MetroTile();
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlStockAnals
            // 
            this.MtlStockAnals.Location = new System.Drawing.Point(396, 99);
            this.MtlStockAnals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MtlStockAnals.Name = "MtlStockAnals";
            this.MtlStockAnals.Size = new System.Drawing.Size(165, 167);
            this.MtlStockAnals.Style = MetroFramework.MetroColorStyle.Orange;
            this.MtlStockAnals.TabIndex = 0;
            this.MtlStockAnals.Text = "주식정보분석";
            this.MtlStockAnals.TileImage = global::MyStockSystem.Properties.Resources.analysis2;
            this.MtlStockAnals.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlStockAnals.UseTileImage = true;
            // 
            // MtlInvestSimuls
            // 
            this.MtlInvestSimuls.Location = new System.Drawing.Point(396, 272);
            this.MtlInvestSimuls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MtlInvestSimuls.Name = "MtlInvestSimuls";
            this.MtlInvestSimuls.Size = new System.Drawing.Size(330, 167);
            this.MtlInvestSimuls.Style = MetroFramework.MetroColorStyle.Green;
            this.MtlInvestSimuls.TabIndex = 0;
            this.MtlInvestSimuls.Text = "투자시뮬레이션";
            this.MtlInvestSimuls.TileImage = global::MyStockSystem.Properties.Resources.simulator2;
            this.MtlInvestSimuls.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlInvestSimuls.UseTileImage = true;
            // 
            // MtlGalmetgilGuide
            // 
            this.MtlGalmetgilGuide.Location = new System.Drawing.Point(535, 445);
            this.MtlGalmetgilGuide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MtlGalmetgilGuide.Name = "MtlGalmetgilGuide";
            this.MtlGalmetgilGuide.Size = new System.Drawing.Size(330, 167);
            this.MtlGalmetgilGuide.Style = MetroFramework.MetroColorStyle.Purple;
            this.MtlGalmetgilGuide.TabIndex = 0;
            this.MtlGalmetgilGuide.Text = "갈맷길 정보";
            this.MtlGalmetgilGuide.TileImage = global::MyStockSystem.Properties.Resources.seagull2;
            this.MtlGalmetgilGuide.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlGalmetgilGuide.UseTileImage = true;
            this.MtlGalmetgilGuide.Click += new System.EventHandler(this.MtlGalmetgilGuide_Click);
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(60, 99);
            this.MtlSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.Size = new System.Drawing.Size(330, 167);
            this.MtlSearchItem.TabIndex = 0;
            this.MtlSearchItem.Text = "주식정보검색";
            this.MtlSearchItem.TileImage = global::MyStockSystem.Properties.Resources.marketing2;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlStockAnals);
            this.Controls.Add(this.MtlInvestSimuls);
            this.Controls.Add(this.MtlGalmetgilGuide);
            this.Controls.Add(this.MtlSearchItem);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(22, 67, 22, 23);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주식분석시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile MtlStockAnals;
        private MetroFramework.Controls.MetroTile MtlInvestSimuls;
        private MetroFramework.Controls.MetroTile MtlGalmetgilGuide;
    }
}

