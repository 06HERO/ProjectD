namespace 庫存查詢DEMO
{
    partial class Form庫存
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo類型 = new System.Windows.Forms.ComboBox();
            this.cbo地點 = new System.Windows.Forms.ComboBox();
            this.btn輸入 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo廠商 = new System.Windows.Forms.ComboBox();
            this.btn商品關鍵字 = new System.Windows.Forms.Button();
            this.btnTOP10 = new System.Windows.Forms.Button();
            this.btnALL = new System.Windows.Forms.Button();
            this.btn進貨商列表 = new System.Windows.Forms.Button();
            this.btn倉庫列表 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1272, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "庫存資料";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "倉庫";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(293, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品類型";
            // 
            // cbo類型
            // 
            this.cbo類型.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo類型.FormattingEnabled = true;
            this.cbo類型.Location = new System.Drawing.Point(384, 87);
            this.cbo類型.Name = "cbo類型";
            this.cbo類型.Size = new System.Drawing.Size(218, 28);
            this.cbo類型.TabIndex = 4;
            // 
            // cbo地點
            // 
            this.cbo地點.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo地點.FormattingEnabled = true;
            this.cbo地點.Location = new System.Drawing.Point(74, 87);
            this.cbo地點.Name = "cbo地點";
            this.cbo地點.Size = new System.Drawing.Size(213, 28);
            this.cbo地點.TabIndex = 7;
            // 
            // btn輸入
            // 
            this.btn輸入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸入.Location = new System.Drawing.Point(920, 85);
            this.btn輸入.Name = "btn輸入";
            this.btn輸入.Size = new System.Drawing.Size(74, 30);
            this.btn輸入.TabIndex = 8;
            this.btn輸入.Text = "輸入";
            this.btn輸入.UseVisualStyleBackColor = true;
            this.btn輸入.Click += new System.EventHandler(this.btn輸入_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(609, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "進貨商";
            // 
            // cbo廠商
            // 
            this.cbo廠商.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo廠商.FormattingEnabled = true;
            this.cbo廠商.Location = new System.Drawing.Point(682, 86);
            this.cbo廠商.Name = "cbo廠商";
            this.cbo廠商.Size = new System.Drawing.Size(218, 28);
            this.cbo廠商.TabIndex = 9;
            // 
            // btn商品關鍵字
            // 
            this.btn商品關鍵字.BackColor = System.Drawing.Color.CadetBlue;
            this.btn商品關鍵字.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品關鍵字.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn商品關鍵字.Location = new System.Drawing.Point(419, 121);
            this.btn商品關鍵字.Name = "btn商品關鍵字";
            this.btn商品關鍵字.Size = new System.Drawing.Size(142, 30);
            this.btn商品關鍵字.TabIndex = 11;
            this.btn商品關鍵字.Text = "商品關鍵字";
            this.btn商品關鍵字.UseVisualStyleBackColor = false;
            this.btn商品關鍵字.Click += new System.EventHandler(this.btn關鍵字_Click);
            // 
            // btnTOP10
            // 
            this.btnTOP10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTOP10.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTOP10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTOP10.Location = new System.Drawing.Point(1090, 71);
            this.btnTOP10.Name = "btnTOP10";
            this.btnTOP10.Size = new System.Drawing.Size(133, 66);
            this.btnTOP10.TabIndex = 12;
            this.btnTOP10.Text = "前10大庫存商品";
            this.btnTOP10.UseVisualStyleBackColor = false;
            this.btnTOP10.Click += new System.EventHandler(this.btnTOP10_Click);
            // 
            // btnALL
            // 
            this.btnALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnALL.BackColor = System.Drawing.Color.PaleGreen;
            this.btnALL.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnALL.Location = new System.Drawing.Point(1090, 135);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(133, 66);
            this.btnALL.TabIndex = 13;
            this.btnALL.Text = "全部庫存商品";
            this.btnALL.UseVisualStyleBackColor = false;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // btn進貨商列表
            // 
            this.btn進貨商列表.BackColor = System.Drawing.Color.CadetBlue;
            this.btn進貨商列表.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn進貨商列表.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn進貨商列表.Location = new System.Drawing.Point(729, 121);
            this.btn進貨商列表.Name = "btn進貨商列表";
            this.btn進貨商列表.Size = new System.Drawing.Size(125, 30);
            this.btn進貨商列表.TabIndex = 16;
            this.btn進貨商列表.Text = "進貨商列表";
            this.btn進貨商列表.UseVisualStyleBackColor = false;
            this.btn進貨商列表.Click += new System.EventHandler(this.btn進貨商列表_Click);
            // 
            // btn倉庫列表
            // 
            this.btn倉庫列表.BackColor = System.Drawing.Color.CadetBlue;
            this.btn倉庫列表.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn倉庫列表.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn倉庫列表.Location = new System.Drawing.Point(124, 121);
            this.btn倉庫列表.Name = "btn倉庫列表";
            this.btn倉庫列表.Size = new System.Drawing.Size(101, 30);
            this.btn倉庫列表.TabIndex = 17;
            this.btn倉庫列表.Text = "倉庫列表";
            this.btn倉庫列表.UseVisualStyleBackColor = false;
            this.btn倉庫列表.Click += new System.EventHandler(this.btn倉庫列表_Click);
            // 
            // Form庫存
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1272, 656);
            this.Controls.Add(this.btn倉庫列表);
            this.Controls.Add(this.btn進貨商列表);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.btnTOP10);
            this.Controls.Add(this.btn商品關鍵字);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo廠商);
            this.Controls.Add(this.btn輸入);
            this.Controls.Add(this.cbo地點);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo類型);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form庫存";
            this.Text = "庫存資料";
            this.Load += new System.EventHandler(this.Form庫存_Load);
            this.SizeChanged += new System.EventHandler(this.Form庫存_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo類型;
        private System.Windows.Forms.ComboBox cbo地點;
        private System.Windows.Forms.Button btn輸入;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo廠商;
        private System.Windows.Forms.Button btn商品關鍵字;
        private System.Windows.Forms.Button btnTOP10;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Button btn進貨商列表;
        private System.Windows.Forms.Button btn倉庫列表;
    }
}

