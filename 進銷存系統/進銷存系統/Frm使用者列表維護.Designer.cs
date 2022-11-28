namespace 進銷存系統
{
    partial class Frm使用者列表維護
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
            this.dv使用者列表 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmb管理權限 = new System.Windows.Forms.ComboBox();
            this.lbl管理權限 = new System.Windows.Forms.Label();
            this.lbl標題 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb驗證 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.btnKeyWord = new System.Windows.Forms.Button();
            this.btn重置CheckCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv使用者列表)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dv使用者列表
            // 
            this.dv使用者列表.AllowDrop = true;
            this.dv使用者列表.AllowUserToOrderColumns = true;
            this.dv使用者列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv使用者列表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dv使用者列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv使用者列表.Location = new System.Drawing.Point(0, 312);
            this.dv使用者列表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dv使用者列表.Name = "dv使用者列表";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv使用者列表.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dv使用者列表.RowHeadersWidth = 51;
            this.dv使用者列表.RowTemplate.Height = 27;
            this.dv使用者列表.Size = new System.Drawing.Size(845, 262);
            this.dv使用者列表.TabIndex = 1;
            this.dv使用者列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv使用者列表_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(687, 248);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 42);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(545, 248);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 42);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Location = new System.Drawing.Point(404, 248);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(133, 42);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmb管理權限
            // 
            this.cmb管理權限.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb管理權限.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb管理權限.FormattingEnabled = true;
            this.cmb管理權限.Location = new System.Drawing.Point(124, 31);
            this.cmb管理權限.Margin = new System.Windows.Forms.Padding(4);
            this.cmb管理權限.Name = "cmb管理權限";
            this.cmb管理權限.Size = new System.Drawing.Size(112, 38);
            this.cmb管理權限.TabIndex = 21;
            // 
            // lbl管理權限
            // 
            this.lbl管理權限.AutoSize = true;
            this.lbl管理權限.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl管理權限.Location = new System.Drawing.Point(7, 34);
            this.lbl管理權限.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl管理權限.Name = "lbl管理權限";
            this.lbl管理權限.Size = new System.Drawing.Size(109, 30);
            this.lbl管理權限.TabIndex = 22;
            this.lbl管理權限.Text = "管理權限";
            // 
            // lbl標題
            // 
            this.lbl標題.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl標題.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl標題.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標題.ForeColor = System.Drawing.Color.Yellow;
            this.lbl標題.Location = new System.Drawing.Point(0, 0);
            this.lbl標題.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl標題.Name = "lbl標題";
            this.lbl標題.Size = new System.Drawing.Size(845, 66);
            this.lbl標題.TabIndex = 28;
            this.lbl標題.Text = "使用者編輯維護";
            this.lbl標題.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb驗證);
            this.groupBox1.Controls.Add(this.lbl管理權限);
            this.groupBox1.Controls.Add(this.cmb管理權限);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(8, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 87);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "條件篩選";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "已驗證";
            // 
            // cmb驗證
            // 
            this.cmb驗證.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb驗證.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb驗證.FormattingEnabled = true;
            this.cmb驗證.Location = new System.Drawing.Point(364, 31);
            this.cmb驗證.Margin = new System.Windows.Forms.Padding(4);
            this.cmb驗證.Name = "cmb驗證";
            this.cmb驗證.Size = new System.Drawing.Size(112, 38);
            this.cmb驗證.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "關鍵字查詢";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyWord.Location = new System.Drawing.Point(156, 90);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.MaxLength = 100;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(522, 39);
            this.txtKeyWord.TabIndex = 31;
            // 
            // btnKeyWord
            // 
            this.btnKeyWord.AutoSize = true;
            this.btnKeyWord.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKeyWord.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnKeyWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKeyWord.Location = new System.Drawing.Point(687, 90);
            this.btnKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyWord.Name = "btnKeyWord";
            this.btnKeyWord.Size = new System.Drawing.Size(133, 42);
            this.btnKeyWord.TabIndex = 32;
            this.btnKeyWord.Text = "查詢";
            this.btnKeyWord.UseVisualStyleBackColor = false;
            // 
            // btn重置CheckCode
            // 
            this.btn重置CheckCode.AutoSize = true;
            this.btn重置CheckCode.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn重置CheckCode.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重置CheckCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn重置CheckCode.Location = new System.Drawing.Point(8, 264);
            this.btn重置CheckCode.Margin = new System.Windows.Forms.Padding(4);
            this.btn重置CheckCode.Name = "btn重置CheckCode";
            this.btn重置CheckCode.Size = new System.Drawing.Size(275, 42);
            this.btn重置CheckCode.TabIndex = 33;
            this.btn重置CheckCode.Text = "模擬每日重置非管員驗證狀態";
            this.btn重置CheckCode.UseVisualStyleBackColor = false;
            this.btn重置CheckCode.Click += new System.EventHandler(this.btn重置CheckCode_Click);
            // 
            // Frm使用者列表維護
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 576);
            this.Controls.Add(this.btn重置CheckCode);
            this.Controls.Add(this.btnKeyWord);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl標題);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dv使用者列表);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm使用者列表維護";
            this.Text = "Frm使用者編輯維護";
            this.Load += new System.EventHandler(this.Frm使用者編輯維護_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv使用者列表)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dv使用者列表;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmb管理權限;
        private System.Windows.Forms.Label lbl管理權限;
        private System.Windows.Forms.Label lbl標題;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb驗證;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button btnKeyWord;
        private System.Windows.Forms.Button btn重置CheckCode;
    }
}