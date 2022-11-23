namespace 進銷存系統
{
    partial class Frm廠商列表維護
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dv廠商列表 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txt統一編號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt代表人姓名 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt資本總額 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt聯絡電話 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk顯示與否 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dv廠商列表)).BeginInit();
            this.SuspendLayout();
            // 
            // dv廠商列表
            // 
            this.dv廠商列表.AllowDrop = true;
            this.dv廠商列表.AllowUserToOrderColumns = true;
            this.dv廠商列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv廠商列表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dv廠商列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv廠商列表.Location = new System.Drawing.Point(0, 285);
            this.dv廠商列表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dv廠商列表.Name = "dv廠商列表";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv廠商列表.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dv廠商列表.RowHeadersWidth = 51;
            this.dv廠商列表.RowTemplate.Height = 27;
            this.dv廠商列表.Size = new System.Drawing.Size(1179, 291);
            this.dv廠商列表.TabIndex = 0;
            this.dv廠商列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv廠商列表_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(605, 234);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(133, 42);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(13, 24);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 30);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "廠商ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(205, 24);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 30);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "廠商名稱";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(19, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 39);
            this.txtID.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(211, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(951, 39);
            this.txtName.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(888, 236);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 42);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(747, 234);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 42);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(1029, 235);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(133, 42);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "列印表單";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txt統一編號
            // 
            this.txt統一編號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt統一編號.Location = new System.Drawing.Point(21, 145);
            this.txt統一編號.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt統一編號.MaxLength = 10;
            this.txt統一編號.Name = "txt統一編號";
            this.txt統一編號.Size = new System.Drawing.Size(151, 39);
            this.txt統一編號.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "統一編號";
            // 
            // txt代表人姓名
            // 
            this.txt代表人姓名.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt代表人姓名.Location = new System.Drawing.Point(211, 145);
            this.txt代表人姓名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt代表人姓名.MaxLength = 50;
            this.txt代表人姓名.Name = "txt代表人姓名";
            this.txt代表人姓名.Size = new System.Drawing.Size(588, 39);
            this.txt代表人姓名.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(205, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "代表人姓名";
            // 
            // txt資本總額
            // 
            this.txt資本總額.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt資本總額.Location = new System.Drawing.Point(833, 145);
            this.txt資本總額.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt資本總額.MaxLength = 15;
            this.txt資本總額.Name = "txt資本總額";
            this.txt資本總額.Size = new System.Drawing.Size(328, 39);
            this.txt資本總額.TabIndex = 24;
            this.txt資本總額.Text = "0";
            this.txt資本總額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(832, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "資本總額";
            // 
            // txt聯絡電話
            // 
            this.txt聯絡電話.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt聯絡電話.Location = new System.Drawing.Point(21, 236);
            this.txt聯絡電話.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt聯絡電話.MaxLength = 20;
            this.txt聯絡電話.Name = "txt聯絡電話";
            this.txt聯絡電話.Size = new System.Drawing.Size(151, 39);
            this.txt聯絡電話.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "聯絡電話";
            // 
            // chk顯示與否
            // 
            this.chk顯示與否.AutoSize = true;
            this.chk顯示與否.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk顯示與否.Location = new System.Drawing.Point(211, 234);
            this.chk顯示與否.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk顯示與否.Name = "chk顯示與否";
            this.chk顯示與否.Size = new System.Drawing.Size(131, 34);
            this.chk顯示與否.TabIndex = 27;
            this.chk顯示與否.Text = "顯示與否";
            this.chk顯示與否.UseVisualStyleBackColor = true;
            // 
            // Frm廠商列表維護
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 576);
            this.Controls.Add(this.chk顯示與否);
            this.Controls.Add(this.txt聯絡電話);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt資本總額);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt代表人姓名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt統一編號);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dv廠商列表);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm廠商列表維護";
            this.Text = "廠商列表維護";
            this.Load += new System.EventHandler(this.廠商列表維護_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv廠商列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dv廠商列表;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txt統一編號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt代表人姓名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt資本總額;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt聯絡電話;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk顯示與否;
    }
}