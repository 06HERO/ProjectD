namespace 進銷存系統
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB登入人員 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB廠商資料查詢編輯 = new System.Windows.Forms.ToolStripButton();
            this.tSB商品類別查詢編輯 = new System.Windows.Forms.ToolStripButton();
            this.tSB商品資料查詢編輯 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB進貨單查詢編輯 = new System.Windows.Forms.ToolStripButton();
            this.tSB庫存查詢 = new System.Windows.Forms.ToolStripButton();
            this.tSBExit = new System.Windows.Forms.ToolStripButton();
            this.tSB真_廠商資料查詢編輯 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB客戶維護系統 = new System.Windows.Forms.ToolStripButton();
            this.tSB經銷商查詢編輯 = new System.Windows.Forms.ToolStripButton();
            this.tSB訂單查詢 = new System.Windows.Forms.ToolStripButton();
            this.tSB出貨單維護 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB登入人員,
            this.toolStripSeparator1,
            this.tSB真_廠商資料查詢編輯,
            this.tSB廠商資料查詢編輯,
            this.tSB商品類別查詢編輯,
            this.tSB商品資料查詢編輯,
            this.toolStripSeparator3,
            this.tSB進貨單查詢編輯,
            this.tSB庫存查詢,
            this.tSB訂單查詢,
            this.tSB出貨單維護,
            this.toolStripSeparator4,
            this.tSB客戶維護系統,
            this.tSB經銷商查詢編輯,
            this.toolStripSeparator5,
            this.tSBExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(143, 627);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB登入人員
            // 
            this.tSB登入人員.ForeColor = System.Drawing.Color.Blue;
            this.tSB登入人員.Name = "tSB登入人員";
            this.tSB登入人員.Size = new System.Drawing.Size(140, 18);
            this.tSB登入人員.Text = "登入人員";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // tSB廠商資料查詢編輯
            // 
            this.tSB廠商資料查詢編輯.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB廠商資料查詢編輯.Image = ((System.Drawing.Image)(resources.GetObject("tSB廠商資料查詢編輯.Image")));
            this.tSB廠商資料查詢編輯.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB廠商資料查詢編輯.Name = "tSB廠商資料查詢編輯";
            this.tSB廠商資料查詢編輯.Size = new System.Drawing.Size(140, 22);
            this.tSB廠商資料查詢編輯.Text = "廠商資料查詢編輯";
            this.tSB廠商資料查詢編輯.Click += new System.EventHandler(this.廠商資料查詢編輯_Click);
            // 
            // tSB商品類別查詢編輯
            // 
            this.tSB商品類別查詢編輯.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB商品類別查詢編輯.Image = ((System.Drawing.Image)(resources.GetObject("tSB商品類別查詢編輯.Image")));
            this.tSB商品類別查詢編輯.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB商品類別查詢編輯.Name = "tSB商品類別查詢編輯";
            this.tSB商品類別查詢編輯.Size = new System.Drawing.Size(140, 22);
            this.tSB商品類別查詢編輯.Text = "商品類別查詢編輯";
            this.tSB商品類別查詢編輯.Click += new System.EventHandler(this.商品類別查詢編輯_Click);
            // 
            // tSB商品資料查詢編輯
            // 
            this.tSB商品資料查詢編輯.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB商品資料查詢編輯.Image = ((System.Drawing.Image)(resources.GetObject("tSB商品資料查詢編輯.Image")));
            this.tSB商品資料查詢編輯.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB商品資料查詢編輯.Name = "tSB商品資料查詢編輯";
            this.tSB商品資料查詢編輯.Size = new System.Drawing.Size(140, 22);
            this.tSB商品資料查詢編輯.Text = "商品資料查詢編輯";
            this.tSB商品資料查詢編輯.Click += new System.EventHandler(this.商品資料查詢編輯_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(140, 6);
            // 
            // tSB進貨單查詢編輯
            // 
            this.tSB進貨單查詢編輯.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB進貨單查詢編輯.Image = ((System.Drawing.Image)(resources.GetObject("tSB進貨單查詢編輯.Image")));
            this.tSB進貨單查詢編輯.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB進貨單查詢編輯.Name = "tSB進貨單查詢編輯";
            this.tSB進貨單查詢編輯.Size = new System.Drawing.Size(140, 22);
            this.tSB進貨單查詢編輯.Text = "進貨單查詢編輯";
            this.tSB進貨單查詢編輯.Click += new System.EventHandler(this.tSB進貨單查詢編輯_Click);
            // 
            // tSB庫存查詢
            // 
            this.tSB庫存查詢.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB庫存查詢.Image = ((System.Drawing.Image)(resources.GetObject("tSB庫存查詢.Image")));
            this.tSB庫存查詢.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB庫存查詢.Name = "tSB庫存查詢";
            this.tSB庫存查詢.Size = new System.Drawing.Size(140, 22);
            this.tSB庫存查詢.Text = "庫存查詢";
            this.tSB庫存查詢.Click += new System.EventHandler(this.tSB庫存查詢_Click);
            // 
            // tSBExit
            // 
            this.tSBExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBExit.Image = ((System.Drawing.Image)(resources.GetObject("tSBExit.Image")));
            this.tSBExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBExit.Name = "tSBExit";
            this.tSBExit.Size = new System.Drawing.Size(140, 22);
            this.tSBExit.Text = "結束程式";
            this.tSBExit.Click += new System.EventHandler(this.tSBExit_Click);
            // 
            // tSB真_廠商資料查詢編輯
            // 
            this.tSB真_廠商資料查詢編輯.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB真_廠商資料查詢編輯.Image = ((System.Drawing.Image)(resources.GetObject("tSB真_廠商資料查詢編輯.Image")));
            this.tSB真_廠商資料查詢編輯.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB真_廠商資料查詢編輯.Name = "tSB真_廠商資料查詢編輯";
            this.tSB真_廠商資料查詢編輯.Size = new System.Drawing.Size(140, 22);
            this.tSB真_廠商資料查詢編輯.Text = "真!廠商資料查詢編輯";
            this.tSB真_廠商資料查詢編輯.Click += new System.EventHandler(this.tSB真_廠商資料查詢編輯_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(140, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(140, 6);
            // 
            // tSB客戶維護系統
            // 
            this.tSB客戶維護系統.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB客戶維護系統.Image = ((System.Drawing.Image)(resources.GetObject("tSB客戶維護系統.Image")));
            this.tSB客戶維護系統.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB客戶維護系統.Name = "tSB客戶維護系統";
            this.tSB客戶維護系統.Size = new System.Drawing.Size(140, 22);
            this.tSB客戶維護系統.Text = "客戶維護系統";
            this.tSB客戶維護系統.Click += new System.EventHandler(this.tSB客戶維護系統_Click);
            // 
            // tSB經銷商查詢編輯
            // 
            this.tSB經銷商查詢編輯.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB經銷商查詢編輯.Image = ((System.Drawing.Image)(resources.GetObject("tSB經銷商查詢編輯.Image")));
            this.tSB經銷商查詢編輯.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB經銷商查詢編輯.Name = "tSB經銷商查詢編輯";
            this.tSB經銷商查詢編輯.Size = new System.Drawing.Size(140, 22);
            this.tSB經銷商查詢編輯.Text = "經銷商查詢編輯";
            this.tSB經銷商查詢編輯.Click += new System.EventHandler(this.tSB經銷商查詢編輯_Click);
            // 
            // tSB訂單查詢
            // 
            this.tSB訂單查詢.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB訂單查詢.Image = ((System.Drawing.Image)(resources.GetObject("tSB訂單查詢.Image")));
            this.tSB訂單查詢.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB訂單查詢.Name = "tSB訂單查詢";
            this.tSB訂單查詢.Size = new System.Drawing.Size(140, 22);
            this.tSB訂單查詢.Text = "訂單查詢";
            this.tSB訂單查詢.Click += new System.EventHandler(this.tSB訂單查詢_Click);
            // 
            // tSB出貨單維護
            // 
            this.tSB出貨單維護.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB出貨單維護.Image = ((System.Drawing.Image)(resources.GetObject("tSB出貨單維護.Image")));
            this.tSB出貨單維護.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB出貨單維護.Name = "tSB出貨單維護";
            this.tSB出貨單維護.Size = new System.Drawing.Size(140, 22);
            this.tSB出貨單維護.Text = "出貨單維護";
            this.tSB出貨單維護.Click += new System.EventHandler(this.tSB出貨單維護_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 627);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "進銷存系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB廠商資料查詢編輯;
        private System.Windows.Forms.ToolStripButton tSB商品類別查詢編輯;
        private System.Windows.Forms.ToolStripButton tSB商品資料查詢編輯;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSBExit;
        private System.Windows.Forms.ToolStripLabel tSB登入人員;
        private System.Windows.Forms.ToolStripButton tSB進貨單查詢編輯;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tSB庫存查詢;
        private System.Windows.Forms.ToolStripButton tSB真_廠商資料查詢編輯;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tSB客戶維護系統;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tSB經銷商查詢編輯;
        private System.Windows.Forms.ToolStripButton tSB訂單查詢;
        private System.Windows.Forms.ToolStripButton tSB出貨單維護;
    }
}

