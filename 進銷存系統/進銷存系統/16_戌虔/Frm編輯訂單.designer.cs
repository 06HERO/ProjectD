namespace 進銷存系統
{
    partial class Frm編輯訂單
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm編輯訂單));
            this.btn更新 = new System.Windows.Forms.Button();
            this.btn結案 = new System.Windows.Forms.Button();
            this.lab訂單狀態 = new System.Windows.Forms.Label();
            this.date交貨日期 = new System.Windows.Forms.DateTimePicker();
            this.date訂單日期 = new System.Windows.Forms.DateTimePicker();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.lab警語 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn送出訂單 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btn清除產品資訊 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cbox品名 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.btn加入明細 = new System.Windows.Forms.Button();
            this.txt訂單狀態 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt備註 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt聯絡人 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt聯絡電話 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt訂單編號 = new System.Windows.Forms.TextBox();
            this.dgv訂單明細 = new System.Windows.Forms.DataGridView();
            this.cbox經銷商ID = new System.Windows.Forms.ComboBox();
            this.cbox廠商ID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbox類型ID = new System.Windows.Forms.ComboBox();
            this.cbox商品ID = new System.Windows.Forms.ComboBox();
            this.labtotaprice = new System.Windows.Forms.Label();
            this.txt單價 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn刪除品項 = new System.Windows.Forms.Button();
            this.btn關閉 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txt庫存 = new System.Windows.Forms.TextBox();
            this.btn列印 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單明細)).BeginInit();
            this.SuspendLayout();
            // 
            // btn更新
            // 
            this.btn更新.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn更新.Location = new System.Drawing.Point(212, 79);
            this.btn更新.Name = "btn更新";
            this.btn更新.Size = new System.Drawing.Size(65, 30);
            this.btn更新.TabIndex = 155;
            this.btn更新.TabStop = false;
            this.btn更新.Text = "更新";
            this.btn更新.UseVisualStyleBackColor = true;
            this.btn更新.Click += new System.EventHandler(this.btn更新_Click);
            // 
            // btn結案
            // 
            this.btn結案.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結案.Location = new System.Drawing.Point(139, 79);
            this.btn結案.Name = "btn結案";
            this.btn結案.Size = new System.Drawing.Size(65, 30);
            this.btn結案.TabIndex = 154;
            this.btn結案.TabStop = false;
            this.btn結案.Text = "結案";
            this.btn結案.UseVisualStyleBackColor = true;
            this.btn結案.Click += new System.EventHandler(this.btn結案_Click);
            // 
            // lab訂單狀態
            // 
            this.lab訂單狀態.AutoSize = true;
            this.lab訂單狀態.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab訂單狀態.Location = new System.Drawing.Point(445, 297);
            this.lab訂單狀態.Name = "lab訂單狀態";
            this.lab訂單狀態.Size = new System.Drawing.Size(90, 19);
            this.lab訂單狀態.TabIndex = 153;
            this.lab訂單狀態.Text = "訂單狀態:";
            // 
            // date交貨日期
            // 
            this.date交貨日期.Checked = false;
            this.date交貨日期.CustomFormat = " ";
            this.date交貨日期.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date交貨日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date交貨日期.Location = new System.Drawing.Point(549, 168);
            this.date交貨日期.Name = "date交貨日期";
            this.date交貨日期.Size = new System.Drawing.Size(242, 33);
            this.date交貨日期.TabIndex = 152;
            this.date交貨日期.TabStop = false;
            this.date交貨日期.ValueChanged += new System.EventHandler(this.date交貨日期_ValueChanged);
            // 
            // date訂單日期
            // 
            this.date訂單日期.Checked = false;
            this.date訂單日期.Cursor = System.Windows.Forms.Cursors.Default;
            this.date訂單日期.CustomFormat = " ";
            this.date訂單日期.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date訂單日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date訂單日期.Location = new System.Drawing.Point(549, 126);
            this.date訂單日期.Name = "date訂單日期";
            this.date訂單日期.Size = new System.Drawing.Size(242, 33);
            this.date訂單日期.TabIndex = 151;
            this.date訂單日期.TabStop = false;
            this.date訂單日期.Value = new System.DateTime(2022, 11, 4, 13, 21, 10, 0);
            this.date訂單日期.ValueChanged += new System.EventHandler(this.date訂單日期_ValueChanged);
            // 
            // btn取消
            // 
            this.btn取消.BackColor = System.Drawing.Color.Silver;
            this.btn取消.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.ForeColor = System.Drawing.Color.Black;
            this.btn取消.Location = new System.Drawing.Point(597, 79);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(93, 30);
            this.btn取消.TabIndex = 150;
            this.btn取消.TabStop = false;
            this.btn取消.Text = "取消訂單";
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(7, 542);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 24);
            this.label23.TabIndex = 149;
            this.label23.Text = "訂單明細";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(-1, 518);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(820, 2);
            this.label22.TabIndex = 148;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(635, 818);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(0, 24);
            this.labTotalPrice.TabIndex = 147;
            // 
            // lab警語
            // 
            this.lab警語.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab警語.AutoSize = true;
            this.lab警語.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab警語.ForeColor = System.Drawing.Color.Red;
            this.lab警語.Location = new System.Drawing.Point(498, 911);
            this.lab警語.Name = "lab警語";
            this.lab警語.Size = new System.Drawing.Size(294, 24);
            this.lab警語.TabIndex = 146;
            this.lab警語.Text = "*送出前請再次確認資料是否正確*\r\n";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(-1, 852);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(820, 2);
            this.label20.TabIndex = 145;
            // 
            // btn送出訂單
            // 
            this.btn送出訂單.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn送出訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出訂單.Location = new System.Drawing.Point(674, 878);
            this.btn送出訂單.Name = "btn送出訂單";
            this.btn送出訂單.Size = new System.Drawing.Size(106, 30);
            this.btn送出訂單.TabIndex = 144;
            this.btn送出訂單.TabStop = false;
            this.btn送出訂單.Text = "送出訂單";
            this.btn送出訂單.UseVisualStyleBackColor = true;
            this.btn送出訂單.Click += new System.EventHandler(this.btn送出訂單_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(463, 818);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 24);
            this.label19.TabIndex = 143;
            this.label19.Text = "總計金額:";
            // 
            // btn清除產品資訊
            // 
            this.btn清除產品資訊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除產品資訊.Location = new System.Drawing.Point(714, 462);
            this.btn清除產品資訊.Name = "btn清除產品資訊";
            this.btn清除產品資訊.Size = new System.Drawing.Size(66, 30);
            this.btn清除產品資訊.TabIndex = 134;
            this.btn清除產品資訊.Text = "清除";
            this.btn清除產品資訊.UseVisualStyleBackColor = true;
            this.btn清除產品資訊.Click += new System.EventHandler(this.btn清除產品資訊_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(27, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 24);
            this.label17.TabIndex = 142;
            this.label17.Text = "品名:";
            // 
            // cbox品名
            // 
            this.cbox品名.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox品名.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox品名.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox品名.FormattingEnabled = true;
            this.cbox品名.Location = new System.Drawing.Point(80, 462);
            this.cbox品名.Name = "cbox品名";
            this.cbox品名.Size = new System.Drawing.Size(403, 27);
            this.cbox品名.TabIndex = 130;
            this.cbox品名.DropDownClosed += new System.EventHandler(this.cbox品名_DropDownClosed);
            this.cbox品名.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbox品名_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(496, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 19);
            this.label14.TabIndex = 141;
            this.label14.Text = "數量:";
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(549, 459);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(65, 33);
            this.txt數量.TabIndex = 131;
            // 
            // btn加入明細
            // 
            this.btn加入明細.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入明細.Location = new System.Drawing.Point(633, 462);
            this.btn加入明細.Name = "btn加入明細";
            this.btn加入明細.Size = new System.Drawing.Size(65, 30);
            this.btn加入明細.TabIndex = 133;
            this.btn加入明細.Text = "加入";
            this.btn加入明細.UseVisualStyleBackColor = true;
            this.btn加入明細.Click += new System.EventHandler(this.btn加入明細_Click);
            // 
            // txt訂單狀態
            // 
            this.txt訂單狀態.Enabled = false;
            this.txt訂單狀態.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂單狀態.Location = new System.Drawing.Point(549, 290);
            this.txt訂單狀態.Name = "txt訂單狀態";
            this.txt訂單狀態.Size = new System.Drawing.Size(242, 33);
            this.txt訂單狀態.TabIndex = 156;
            this.txt訂單狀態.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(10, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 140;
            this.label11.Text = "產品資訊";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(10, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 139;
            this.label12.Text = "訂單資訊";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(820, 2);
            this.label10.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(26, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 137;
            this.label9.Text = "備        註:";
            // 
            // txt備註
            // 
            this.txt備註.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt備註.Location = new System.Drawing.Point(130, 290);
            this.txt備註.Name = "txt備註";
            this.txt備註.Size = new System.Drawing.Size(242, 33);
            this.txt備註.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(445, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 136;
            this.label8.Text = "經銷商ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(445, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 135;
            this.label7.Text = "交貨日期:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(26, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 132;
            this.label6.Text = "聯  絡  人:";
            // 
            // txt聯絡人
            // 
            this.txt聯絡人.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt聯絡人.Location = new System.Drawing.Point(130, 167);
            this.txt聯絡人.Name = "txt聯絡人";
            this.txt聯絡人.Size = new System.Drawing.Size(242, 33);
            this.txt聯絡人.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(26, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 129;
            this.label5.Text = "地        址:";
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(130, 249);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(661, 33);
            this.txt地址.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(26, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "聯絡電話:";
            // 
            // txt聯絡電話
            // 
            this.txt聯絡電話.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt聯絡電話.Location = new System.Drawing.Point(130, 208);
            this.txt聯絡電話.Name = "txt聯絡電話";
            this.txt聯絡電話.Size = new System.Drawing.Size(242, 33);
            this.txt聯絡電話.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(445, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 127;
            this.label3.Text = "訂單日期:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 62);
            this.panel1.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(263, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "普雷二電玩股份有限公司 出貨單";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "訂單編號:";
            // 
            // txt訂單編號
            // 
            this.txt訂單編號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂單編號.Location = new System.Drawing.Point(130, 126);
            this.txt訂單編號.Name = "txt訂單編號";
            this.txt訂單編號.Size = new System.Drawing.Size(242, 33);
            this.txt訂單編號.TabIndex = 119;
            // 
            // dgv訂單明細
            // 
            this.dgv訂單明細.AllowUserToAddRows = false;
            this.dgv訂單明細.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv訂單明細.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv訂單明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單明細.Location = new System.Drawing.Point(7, 582);
            this.dgv訂單明細.Name = "dgv訂單明細";
            this.dgv訂單明細.RowTemplate.Height = 24;
            this.dgv訂單明細.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv訂單明細.Size = new System.Drawing.Size(785, 233);
            this.dgv訂單明細.TabIndex = 118;
            this.dgv訂單明細.TabStop = false;
            this.dgv訂單明細.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單明細_CellClick);
            // 
            // cbox經銷商ID
            // 
            this.cbox經銷商ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox經銷商ID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox經銷商ID.FormattingEnabled = true;
            this.cbox經銷商ID.Location = new System.Drawing.Point(550, 212);
            this.cbox經銷商ID.Name = "cbox經銷商ID";
            this.cbox經銷商ID.Size = new System.Drawing.Size(241, 27);
            this.cbox經銷商ID.TabIndex = 158;
            // 
            // cbox廠商ID
            // 
            this.cbox廠商ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox廠商ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox廠商ID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox廠商ID.FormattingEnabled = true;
            this.cbox廠商ID.Location = new System.Drawing.Point(80, 414);
            this.cbox廠商ID.Name = "cbox廠商ID";
            this.cbox廠商ID.Size = new System.Drawing.Size(67, 27);
            this.cbox廠商ID.TabIndex = 159;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(27, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 160;
            this.label13.Text = "廠商:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(158, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 24);
            this.label15.TabIndex = 161;
            this.label15.Text = "類型:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(293, 414);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 24);
            this.label16.TabIndex = 162;
            this.label16.Text = "編號:";
            // 
            // cbox類型ID
            // 
            this.cbox類型ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox類型ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox類型ID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox類型ID.FormattingEnabled = true;
            this.cbox類型ID.Location = new System.Drawing.Point(212, 413);
            this.cbox類型ID.Name = "cbox類型ID";
            this.cbox類型ID.Size = new System.Drawing.Size(67, 27);
            this.cbox類型ID.TabIndex = 163;
            // 
            // cbox商品ID
            // 
            this.cbox商品ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox商品ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox商品ID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox商品ID.FormattingEnabled = true;
            this.cbox商品ID.Location = new System.Drawing.Point(347, 413);
            this.cbox商品ID.Name = "cbox商品ID";
            this.cbox商品ID.Size = new System.Drawing.Size(67, 27);
            this.cbox商品ID.TabIndex = 164;
            // 
            // labtotaprice
            // 
            this.labtotaprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labtotaprice.AutoSize = true;
            this.labtotaprice.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtotaprice.Location = new System.Drawing.Point(611, 818);
            this.labtotaprice.Name = "labtotaprice";
            this.labtotaprice.Size = new System.Drawing.Size(0, 24);
            this.labtotaprice.TabIndex = 165;
            // 
            // txt單價
            // 
            this.txt單價.Enabled = false;
            this.txt單價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt單價.Location = new System.Drawing.Point(500, 410);
            this.txt單價.Name = "txt單價";
            this.txt單價.Size = new System.Drawing.Size(131, 33);
            this.txt單價.TabIndex = 166;
            this.txt單價.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(447, 419);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 19);
            this.label18.TabIndex = 167;
            this.label18.Text = "單價:";
            // 
            // btn刪除品項
            // 
            this.btn刪除品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除品項.Location = new System.Drawing.Point(139, 540);
            this.btn刪除品項.Name = "btn刪除品項";
            this.btn刪除品項.Size = new System.Drawing.Size(96, 30);
            this.btn刪除品項.TabIndex = 168;
            this.btn刪除品項.Text = "刪除品項";
            this.btn刪除品項.UseVisualStyleBackColor = true;
            this.btn刪除品項.Click += new System.EventHandler(this.btn刪除品項_Click);
            // 
            // btn關閉
            // 
            this.btn關閉.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn關閉.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.ForeColor = System.Drawing.Color.Black;
            this.btn關閉.Location = new System.Drawing.Point(696, 79);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(93, 30);
            this.btn關閉.TabIndex = 170;
            this.btn關閉.TabStop = false;
            this.btn關閉.Text = "關閉";
            this.btn關閉.UseVisualStyleBackColor = false;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(644, 418);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 19);
            this.label21.TabIndex = 171;
            this.label21.Text = "庫存:";
            // 
            // txt庫存
            // 
            this.txt庫存.Enabled = false;
            this.txt庫存.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt庫存.Location = new System.Drawing.Point(693, 411);
            this.txt庫存.Name = "txt庫存";
            this.txt庫存.Size = new System.Drawing.Size(87, 33);
            this.txt庫存.TabIndex = 172;
            this.txt庫存.TabStop = false;
            // 
            // btn列印
            // 
            this.btn列印.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列印.Location = new System.Drawing.Point(283, 79);
            this.btn列印.Name = "btn列印";
            this.btn列印.Size = new System.Drawing.Size(65, 30);
            this.btn列印.TabIndex = 173;
            this.btn列印.TabStop = false;
            this.btn列印.Text = "列印";
            this.btn列印.UseVisualStyleBackColor = true;
            this.btn列印.Click += new System.EventHandler(this.btn列印_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Frm編輯訂單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 961);
            this.Controls.Add(this.btn列印);
            this.Controls.Add(this.txt庫存);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn關閉);
            this.Controls.Add(this.btn刪除品項);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt單價);
            this.Controls.Add(this.labtotaprice);
            this.Controls.Add(this.cbox商品ID);
            this.Controls.Add(this.cbox類型ID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbox廠商ID);
            this.Controls.Add(this.cbox經銷商ID);
            this.Controls.Add(this.btn更新);
            this.Controls.Add(this.btn結案);
            this.Controls.Add(this.lab訂單狀態);
            this.Controls.Add(this.date交貨日期);
            this.Controls.Add(this.date訂單日期);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.lab警語);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn送出訂單);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btn清除產品資訊);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbox品名);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.btn加入明細);
            this.Controls.Add(this.txt訂單狀態);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt備註);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt聯絡人);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt聯絡電話);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt訂單編號);
            this.Controls.Add(this.dgv訂單明細);
            this.Name = "Frm編輯訂單";
            this.Text = "Frm編輯訂單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm編輯訂單_FormClosing);
            this.Load += new System.EventHandler(this.Frm編輯訂單_Load);
            this.SizeChanged += new System.EventHandler(this.Frm編輯訂單_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單明細)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn更新;
        private System.Windows.Forms.Button btn結案;
        private System.Windows.Forms.Label lab訂單狀態;
        private System.Windows.Forms.DateTimePicker date交貨日期;
        private System.Windows.Forms.DateTimePicker date訂單日期;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label lab警語;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn送出訂單;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn清除產品資訊;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbox品名;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Button btn加入明細;
        private System.Windows.Forms.TextBox txt訂單狀態;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt備註;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt聯絡人;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt聯絡電話;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt訂單編號;
        private System.Windows.Forms.DataGridView dgv訂單明細;
        private System.Windows.Forms.ComboBox cbox經銷商ID;
        private System.Windows.Forms.ComboBox cbox廠商ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbox類型ID;
        private System.Windows.Forms.ComboBox cbox商品ID;
        private System.Windows.Forms.Label labtotaprice;
        private System.Windows.Forms.TextBox txt單價;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn刪除品項;
        private System.Windows.Forms.Button btn關閉;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt庫存;
        private System.Windows.Forms.Button btn列印;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}