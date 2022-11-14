namespace 進銷存系統
{
    partial class Frm查詢訂單
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
            this.label11 = new System.Windows.Forms.Label();
            this.date交貨日期e = new System.Windows.Forms.DateTimePicker();
            this.date訂單日期e = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.cbox訂單狀態 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.date交貨日期s = new System.Windows.Forms.DateTimePicker();
            this.date訂單日期s = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt聯絡電話 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt訂單編號 = new System.Windows.Forms.TextBox();
            this.dgv出貨單列表 = new System.Windows.Forms.DataGridView();
            this.btn清除訂單日期 = new System.Windows.Forms.Button();
            this.btn清除交貨日期 = new System.Windows.Forms.Button();
            this.btn清空查詢條件 = new System.Windows.Forms.Button();
            this.cbox經銷商ID = new System.Windows.Forms.ComboBox();
            this.btn清除狀態 = new System.Windows.Forms.Button();
            this.btn清除訂單編號 = new System.Windows.Forms.Button();
            this.btn清除經銷商 = new System.Windows.Forms.Button();
            this.btn清除電話 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv出貨單列表)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(740, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 139;
            this.label11.Text = "~";
            // 
            // date交貨日期e
            // 
            this.date交貨日期e.Checked = false;
            this.date交貨日期e.CustomFormat = " ";
            this.date交貨日期e.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date交貨日期e.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date交貨日期e.Location = new System.Drawing.Point(765, 140);
            this.date交貨日期e.Name = "date交貨日期e";
            this.date交貨日期e.Size = new System.Drawing.Size(127, 33);
            this.date交貨日期e.TabIndex = 133;
            this.date交貨日期e.TabStop = false;
            this.date交貨日期e.CloseUp += new System.EventHandler(this.date交貨日期e_CloseUp);
            // 
            // date訂單日期e
            // 
            this.date訂單日期e.Checked = false;
            this.date訂單日期e.CustomFormat = " ";
            this.date訂單日期e.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date訂單日期e.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date訂單日期e.Location = new System.Drawing.Point(765, 98);
            this.date訂單日期e.MinDate = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            this.date訂單日期e.Name = "date訂單日期e";
            this.date訂單日期e.Size = new System.Drawing.Size(127, 33);
            this.date訂單日期e.TabIndex = 131;
            this.date訂單日期e.TabStop = false;
            this.date訂單日期e.CloseUp += new System.EventHandler(this.date訂單日期e_CloseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(740, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 138;
            this.label9.Text = "~";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-62, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1064, 2);
            this.label10.TabIndex = 137;
            // 
            // btn新增
            // 
            this.btn新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(26, 234);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(127, 37);
            this.btn新增.TabIndex = 128;
            this.btn新增.Text = "新增訂單";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn查詢
            // 
            this.btn查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢.Location = new System.Drawing.Point(608, 234);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(127, 37);
            this.btn查詢.TabIndex = 129;
            this.btn查詢.Text = "查詢訂單";
            this.btn查詢.UseVisualStyleBackColor = true;
            this.btn查詢.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // cbox訂單狀態
            // 
            this.cbox訂單狀態.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox訂單狀態.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox訂單狀態.FormattingEnabled = true;
            this.cbox訂單狀態.Items.AddRange(new object[] {
            "接收",
            "完成",
            "取消",
            "草稿"});
            this.cbox訂單狀態.Location = new System.Drawing.Point(608, 194);
            this.cbox訂單狀態.Name = "cbox訂單狀態";
            this.cbox訂單狀態.Size = new System.Drawing.Size(284, 27);
            this.cbox訂單狀態.TabIndex = 134;
            this.cbox訂單狀態.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(504, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 19);
            this.label18.TabIndex = 121;
            this.label18.Text = "訂單狀態:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 75);
            this.panel1.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(326, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 40);
            this.label1.TabIndex = 101;
            this.label1.Text = "訂單查詢維護";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date交貨日期s
            // 
            this.date交貨日期s.Checked = false;
            this.date交貨日期s.CustomFormat = " ";
            this.date交貨日期s.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date交貨日期s.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date交貨日期s.Location = new System.Drawing.Point(608, 140);
            this.date交貨日期s.Name = "date交貨日期s";
            this.date交貨日期s.Size = new System.Drawing.Size(127, 33);
            this.date交貨日期s.TabIndex = 132;
            this.date交貨日期s.TabStop = false;
            this.date交貨日期s.CloseUp += new System.EventHandler(this.date交貨日期s_CloseUp);
            // 
            // date訂單日期s
            // 
            this.date訂單日期s.Checked = false;
            this.date訂單日期s.CustomFormat = " ";
            this.date訂單日期s.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date訂單日期s.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date訂單日期s.Location = new System.Drawing.Point(608, 98);
            this.date訂單日期s.Name = "date訂單日期s";
            this.date訂單日期s.Size = new System.Drawing.Size(127, 33);
            this.date訂單日期s.TabIndex = 130;
            this.date訂單日期s.TabStop = false;
            this.date訂單日期s.CloseUp += new System.EventHandler(this.date訂單日期s_CloseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(22, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 122;
            this.label8.Text = "經銷商ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(504, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 123;
            this.label7.Text = "交貨日期:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 124;
            this.label4.Text = "聯絡電話:";
            // 
            // txt聯絡電話
            // 
            this.txt聯絡電話.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt聯絡電話.Location = new System.Drawing.Point(126, 187);
            this.txt聯絡電話.Name = "txt聯絡電話";
            this.txt聯絡電話.Size = new System.Drawing.Size(284, 33);
            this.txt聯絡電話.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(504, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "訂單日期:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 119;
            this.label2.Text = "訂單編號:";
            // 
            // txt訂單編號
            // 
            this.txt訂單編號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂單編號.Location = new System.Drawing.Point(126, 105);
            this.txt訂單編號.Name = "txt訂單編號";
            this.txt訂單編號.Size = new System.Drawing.Size(284, 33);
            this.txt訂單編號.TabIndex = 1;
            // 
            // dgv出貨單列表
            // 
            this.dgv出貨單列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv出貨單列表.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv出貨單列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv出貨單列表.Location = new System.Drawing.Point(12, 298);
            this.dgv出貨單列表.Name = "dgv出貨單列表";
            this.dgv出貨單列表.RowTemplate.Height = 24;
            this.dgv出貨單列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv出貨單列表.Size = new System.Drawing.Size(916, 399);
            this.dgv出貨單列表.TabIndex = 135;
            this.dgv出貨單列表.TabStop = false;
            this.dgv出貨單列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單資訊_CellClick);
            this.dgv出貨單列表.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單資訊_CellDoubleClick);
            // 
            // btn清除訂單日期
            // 
            this.btn清除訂單日期.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除訂單日期.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn清除訂單日期.Location = new System.Drawing.Point(900, 103);
            this.btn清除訂單日期.Name = "btn清除訂單日期";
            this.btn清除訂單日期.Size = new System.Drawing.Size(26, 24);
            this.btn清除訂單日期.TabIndex = 140;
            this.btn清除訂單日期.TabStop = false;
            this.btn清除訂單日期.Text = " X";
            this.btn清除訂單日期.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn清除訂單日期.UseVisualStyleBackColor = false;
            this.btn清除訂單日期.Click += new System.EventHandler(this.btn清除訂單日期_Click);
            // 
            // btn清除交貨日期
            // 
            this.btn清除交貨日期.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除交貨日期.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn清除交貨日期.Location = new System.Drawing.Point(900, 144);
            this.btn清除交貨日期.Name = "btn清除交貨日期";
            this.btn清除交貨日期.Size = new System.Drawing.Size(26, 24);
            this.btn清除交貨日期.TabIndex = 141;
            this.btn清除交貨日期.TabStop = false;
            this.btn清除交貨日期.Text = " X";
            this.btn清除交貨日期.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn清除交貨日期.UseVisualStyleBackColor = false;
            this.btn清除交貨日期.Click += new System.EventHandler(this.btn清除交貨日期_Click);
            // 
            // btn清空查詢條件
            // 
            this.btn清空查詢條件.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空查詢條件.Location = new System.Drawing.Point(765, 234);
            this.btn清空查詢條件.Name = "btn清空查詢條件";
            this.btn清空查詢條件.Size = new System.Drawing.Size(127, 36);
            this.btn清空查詢條件.TabIndex = 142;
            this.btn清空查詢條件.Text = "清空查詢條件";
            this.btn清空查詢條件.UseVisualStyleBackColor = true;
            this.btn清空查詢條件.Click += new System.EventHandler(this.btn清空查詢條件_Click);
            // 
            // cbox經銷商ID
            // 
            this.cbox經銷商ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox經銷商ID.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox經銷商ID.FormattingEnabled = true;
            this.cbox經銷商ID.Items.AddRange(new object[] {
            "接收",
            "完成",
            "取消",
            "草稿"});
            this.cbox經銷商ID.Location = new System.Drawing.Point(126, 149);
            this.cbox經銷商ID.Name = "cbox經銷商ID";
            this.cbox經銷商ID.Size = new System.Drawing.Size(284, 29);
            this.cbox經銷商ID.TabIndex = 2;
            // 
            // btn清除狀態
            // 
            this.btn清除狀態.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除狀態.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn清除狀態.Location = new System.Drawing.Point(900, 196);
            this.btn清除狀態.Name = "btn清除狀態";
            this.btn清除狀態.Size = new System.Drawing.Size(26, 24);
            this.btn清除狀態.TabIndex = 144;
            this.btn清除狀態.TabStop = false;
            this.btn清除狀態.Text = " X";
            this.btn清除狀態.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn清除狀態.UseVisualStyleBackColor = false;
            this.btn清除狀態.Click += new System.EventHandler(this.btn清除狀態_Click);
            // 
            // btn清除訂單編號
            // 
            this.btn清除訂單編號.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除訂單編號.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn清除訂單編號.Location = new System.Drawing.Point(416, 111);
            this.btn清除訂單編號.Name = "btn清除訂單編號";
            this.btn清除訂單編號.Size = new System.Drawing.Size(26, 24);
            this.btn清除訂單編號.TabIndex = 145;
            this.btn清除訂單編號.TabStop = false;
            this.btn清除訂單編號.Text = " X";
            this.btn清除訂單編號.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn清除訂單編號.UseVisualStyleBackColor = false;
            this.btn清除訂單編號.Click += new System.EventHandler(this.btn清除訂單編號_Click);
            // 
            // btn清除經銷商
            // 
            this.btn清除經銷商.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除經銷商.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn清除經銷商.Location = new System.Drawing.Point(416, 153);
            this.btn清除經銷商.Name = "btn清除經銷商";
            this.btn清除經銷商.Size = new System.Drawing.Size(26, 24);
            this.btn清除經銷商.TabIndex = 146;
            this.btn清除經銷商.TabStop = false;
            this.btn清除經銷商.Text = " X";
            this.btn清除經銷商.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn清除經銷商.UseVisualStyleBackColor = false;
            this.btn清除經銷商.Click += new System.EventHandler(this.btn清除經銷商_Click);
            // 
            // btn清除電話
            // 
            this.btn清除電話.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn清除電話.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn清除電話.Location = new System.Drawing.Point(416, 193);
            this.btn清除電話.Name = "btn清除電話";
            this.btn清除電話.Size = new System.Drawing.Size(26, 24);
            this.btn清除電話.TabIndex = 147;
            this.btn清除電話.TabStop = false;
            this.btn清除電話.Text = " X";
            this.btn清除電話.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn清除電話.UseVisualStyleBackColor = false;
            this.btn清除電話.Click += new System.EventHandler(this.btn清除電話_Click);
            // 
            // Frm查詢訂單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 709);
            this.Controls.Add(this.btn清除電話);
            this.Controls.Add(this.btn清除經銷商);
            this.Controls.Add(this.btn清除訂單編號);
            this.Controls.Add(this.btn清除狀態);
            this.Controls.Add(this.cbox經銷商ID);
            this.Controls.Add(this.btn清空查詢條件);
            this.Controls.Add(this.btn清除交貨日期);
            this.Controls.Add(this.btn清除訂單日期);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.date交貨日期e);
            this.Controls.Add(this.date訂單日期e);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.cbox訂單狀態);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.date交貨日期s);
            this.Controls.Add(this.date訂單日期s);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt聯絡電話);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt訂單編號);
            this.Controls.Add(this.dgv出貨單列表);
            this.Name = "Frm查詢訂單";
            this.Text = "Frm查詢訂單";
            this.Load += new System.EventHandler(this.Frm查詢訂單_Load);
            this.ResizeEnd += new System.EventHandler(this.Frm查詢訂單_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv出貨單列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date交貨日期e;
        private System.Windows.Forms.DateTimePicker date訂單日期e;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.ComboBox cbox訂單狀態;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date交貨日期s;
        private System.Windows.Forms.DateTimePicker date訂單日期s;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt聯絡電話;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt訂單編號;
        private System.Windows.Forms.DataGridView dgv出貨單列表;
        private System.Windows.Forms.Button btn清除訂單日期;
        private System.Windows.Forms.Button btn清除交貨日期;
        private System.Windows.Forms.Button btn清空查詢條件;
        private System.Windows.Forms.ComboBox cbox經銷商ID;
        private System.Windows.Forms.Button btn清除狀態;
        private System.Windows.Forms.Button btn清除訂單編號;
        private System.Windows.Forms.Button btn清除經銷商;
        private System.Windows.Forms.Button btn清除電話;
    }
}

