namespace 進銷存系統
{
    partial class Frm商品列表維護
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dv商品列表 = new System.Windows.Forms.DataGridView();
            this.cmb廠商 = new System.Windows.Forms.ComboBox();
            this.lbl廠商 = new System.Windows.Forms.Label();
            this.lbl商品類別 = new System.Windows.Forms.Label();
            this.cmb商品類別 = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv商品列表)).BeginInit();
            this.SuspendLayout();
            // 
            // dv商品列表
            // 
            this.dv商品列表.AllowDrop = true;
            this.dv商品列表.AllowUserToOrderColumns = true;
            this.dv商品列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv商品列表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dv商品列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv商品列表.Location = new System.Drawing.Point(0, 110);
            this.dv商品列表.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dv商品列表.Name = "dv商品列表";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv商品列表.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dv商品列表.RowHeadersWidth = 51;
            this.dv商品列表.RowTemplate.Height = 27;
            this.dv商品列表.Size = new System.Drawing.Size(884, 252);
            this.dv商品列表.TabIndex = 1;
            // 
            // cmb廠商
            // 
            this.cmb廠商.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb廠商.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb廠商.FormattingEnabled = true;
            this.cmb廠商.Location = new System.Drawing.Point(64, 10);
            this.cmb廠商.Name = "cmb廠商";
            this.cmb廠商.Size = new System.Drawing.Size(585, 32);
            this.cmb廠商.TabIndex = 2;
            // 
            // lbl廠商
            // 
            this.lbl廠商.AutoSize = true;
            this.lbl廠商.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl廠商.Location = new System.Drawing.Point(12, 12);
            this.lbl廠商.Name = "lbl廠商";
            this.lbl廠商.Size = new System.Drawing.Size(48, 24);
            this.lbl廠商.TabIndex = 13;
            this.lbl廠商.Text = "廠商";
            // 
            // lbl商品類別
            // 
            this.lbl商品類別.AutoSize = true;
            this.lbl商品類別.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品類別.Location = new System.Drawing.Point(655, 11);
            this.lbl商品類別.Name = "lbl商品類別";
            this.lbl商品類別.Size = new System.Drawing.Size(86, 24);
            this.lbl商品類別.TabIndex = 15;
            this.lbl商品類別.Text = "商品類別";
            // 
            // cmb商品類別
            // 
            this.cmb商品類別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb商品類別.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb商品類別.FormattingEnabled = true;
            this.cmb商品類別.Location = new System.Drawing.Point(742, 9);
            this.cmb商品類別.Name = "cmb商品類別";
            this.cmb商品類別.Size = new System.Drawing.Size(130, 32);
            this.cmb商品類別.TabIndex = 14;
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(433, 60);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 34);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "列印表單";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(772, 60);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 34);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(666, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(560, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Frm商品列表維護
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lbl商品類別);
            this.Controls.Add(this.cmb商品類別);
            this.Controls.Add(this.lbl廠商);
            this.Controls.Add(this.cmb廠商);
            this.Controls.Add(this.dv商品列表);
            this.Name = "Frm商品列表維護";
            this.Text = "Frm商品列表維護";
            this.Load += new System.EventHandler(this.Frm商品列表維護_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv商品列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dv商品列表;
        private System.Windows.Forms.ComboBox cmb廠商;
        private System.Windows.Forms.Label lbl廠商;
        private System.Windows.Forms.Label lbl商品類別;
        private System.Windows.Forms.ComboBox cmb商品類別;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}