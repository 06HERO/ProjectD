namespace 進銷存系統
{
    partial class Frm進貨單維護
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dv進貨單列表 = new System.Windows.Forms.DataGridView();
            this.txt進貨單編號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dv進貨單明細 = new System.Windows.Forms.DataGridView();
            this.lbl庫存地點 = new System.Windows.Forms.Label();
            this.cmb庫存地點 = new System.Windows.Forms.ComboBox();
            this.lbl廠商 = new System.Windows.Forms.Label();
            this.cmb廠商 = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDtStart = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDtEnd = new System.Windows.Forms.MaskedTextBox();
            this.lbl商品類別 = new System.Windows.Forms.Label();
            this.cmb商品類別 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.btnDelete列表 = new System.Windows.Forms.Button();
            this.btnUpdate列表 = new System.Windows.Forms.Button();
            this.btnInsert列表 = new System.Windows.Forms.Button();
            this.btnDelete明細 = new System.Windows.Forms.Button();
            this.btnUpdate明細 = new System.Windows.Forms.Button();
            this.btnInsert明細 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lbl標題 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv進貨單列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv進貨單明細)).BeginInit();
            this.SuspendLayout();
            // 
            // dv進貨單列表
            // 
            this.dv進貨單列表.AllowDrop = true;
            this.dv進貨單列表.AllowUserToOrderColumns = true;
            this.dv進貨單列表.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv進貨單列表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dv進貨單列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv進貨單列表.Location = new System.Drawing.Point(0, 178);
            this.dv進貨單列表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dv進貨單列表.Name = "dv進貨單列表";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv進貨單列表.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dv進貨單列表.RowHeadersWidth = 51;
            this.dv進貨單列表.RowTemplate.Height = 27;
            this.dv進貨單列表.Size = new System.Drawing.Size(1312, 270);
            this.dv進貨單列表.TabIndex = 2;
            this.dv進貨單列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv進貨單列表_CellClick);
            // 
            // txt進貨單編號
            // 
            this.txt進貨單編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt進貨單編號.Location = new System.Drawing.Point(147, 82);
            this.txt進貨單編號.Margin = new System.Windows.Forms.Padding(4);
            this.txt進貨單編號.MaxLength = 10;
            this.txt進貨單編號.Name = "txt進貨單編號";
            this.txt進貨單編號.Size = new System.Drawing.Size(105, 34);
            this.txt進貨單編號.TabIndex = 21;
            this.txt進貨單編號.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "進貨單編號";
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelect.Location = new System.Drawing.Point(884, 75);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 39);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "條件查詢";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dv進貨單明細
            // 
            this.dv進貨單明細.AllowDrop = true;
            this.dv進貨單明細.AllowUserToOrderColumns = true;
            this.dv進貨單明細.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv進貨單明細.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dv進貨單明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv進貨單明細.Location = new System.Drawing.Point(0, 576);
            this.dv進貨單明細.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dv進貨單明細.Name = "dv進貨單明細";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv進貨單明細.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dv進貨單明細.RowHeadersWidth = 51;
            this.dv進貨單明細.RowTemplate.Height = 27;
            this.dv進貨單明細.Size = new System.Drawing.Size(1312, 250);
            this.dv進貨單明細.StandardTab = true;
            this.dv進貨單明細.TabIndex = 23;
            // 
            // lbl庫存地點
            // 
            this.lbl庫存地點.AutoSize = true;
            this.lbl庫存地點.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存地點.Location = new System.Drawing.Point(41, 134);
            this.lbl庫存地點.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl庫存地點.Name = "lbl庫存地點";
            this.lbl庫存地點.Size = new System.Drawing.Size(92, 25);
            this.lbl庫存地點.TabIndex = 27;
            this.lbl庫存地點.Text = "庫存地點";
            // 
            // cmb庫存地點
            // 
            this.cmb庫存地點.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb庫存地點.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb庫存地點.FormattingEnabled = true;
            this.cmb庫存地點.Location = new System.Drawing.Point(147, 134);
            this.cmb庫存地點.Margin = new System.Windows.Forms.Padding(4);
            this.cmb庫存地點.Name = "cmb庫存地點";
            this.cmb庫存地點.Size = new System.Drawing.Size(132, 33);
            this.cmb庫存地點.TabIndex = 26;
            // 
            // lbl廠商
            // 
            this.lbl廠商.AutoSize = true;
            this.lbl廠商.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl廠商.Location = new System.Drawing.Point(280, 89);
            this.lbl廠商.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl廠商.Name = "lbl廠商";
            this.lbl廠商.Size = new System.Drawing.Size(52, 25);
            this.lbl廠商.TabIndex = 25;
            this.lbl廠商.Text = "廠商";
            // 
            // cmb廠商
            // 
            this.cmb廠商.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb廠商.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb廠商.FormattingEnabled = true;
            this.cmb廠商.Location = new System.Drawing.Point(340, 82);
            this.cmb廠商.Margin = new System.Windows.Forms.Padding(4);
            this.cmb廠商.Name = "cmb廠商";
            this.cmb廠商.Size = new System.Drawing.Size(512, 33);
            this.cmb廠商.TabIndex = 24;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClear.Location = new System.Drawing.Point(1011, 75);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(112, 39);
            this.BtnClear.TabIndex = 28;
            this.BtnClear.Text = "清空條件";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(432, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "進貨日期";
            // 
            // mskDtStart
            // 
            this.mskDtStart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mskDtStart.Location = new System.Drawing.Point(537, 130);
            this.mskDtStart.Margin = new System.Windows.Forms.Padding(4);
            this.mskDtStart.Mask = "0000/00/00";
            this.mskDtStart.Name = "mskDtStart";
            this.mskDtStart.Size = new System.Drawing.Size(132, 31);
            this.mskDtStart.TabIndex = 30;
            this.mskDtStart.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(679, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "至";
            // 
            // mskDtEnd
            // 
            this.mskDtEnd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mskDtEnd.Location = new System.Drawing.Point(720, 130);
            this.mskDtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.mskDtEnd.Mask = "0000/00/00";
            this.mskDtEnd.Name = "mskDtEnd";
            this.mskDtEnd.Size = new System.Drawing.Size(132, 31);
            this.mskDtEnd.TabIndex = 32;
            this.mskDtEnd.ValidatingType = typeof(System.DateTime);
            // 
            // lbl商品類別
            // 
            this.lbl商品類別.AutoSize = true;
            this.lbl商品類別.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品類別.Location = new System.Drawing.Point(13, 532);
            this.lbl商品類別.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl商品類別.Name = "lbl商品類別";
            this.lbl商品類別.Size = new System.Drawing.Size(92, 25);
            this.lbl商品類別.TabIndex = 38;
            this.lbl商品類別.Text = "商品類別";
            // 
            // cmb商品類別
            // 
            this.cmb商品類別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb商品類別.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb商品類別.FormattingEnabled = true;
            this.cmb商品類別.Location = new System.Drawing.Point(113, 529);
            this.cmb商品類別.Margin = new System.Windows.Forms.Padding(4);
            this.cmb商品類別.Name = "cmb商品類別";
            this.cmb商品類別.Size = new System.Drawing.Size(151, 33);
            this.cmb商品類別.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(313, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "商品名稱關鍵字";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyWord.Location = new System.Drawing.Point(483, 528);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.MaxLength = 10;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(265, 34);
            this.txtKeyWord.TabIndex = 40;
            this.txtKeyWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyWord_KeyDown);
            // 
            // btnDelete列表
            // 
            this.btnDelete列表.AutoSize = true;
            this.btnDelete列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete列表.Location = new System.Drawing.Point(884, 130);
            this.btnDelete列表.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete列表.Name = "btnDelete列表";
            this.btnDelete列表.Size = new System.Drawing.Size(133, 42);
            this.btnDelete列表.TabIndex = 43;
            this.btnDelete列表.Text = "刪除";
            this.btnDelete列表.UseVisualStyleBackColor = true;
            this.btnDelete列表.Click += new System.EventHandler(this.btnDelete列表_Click);
            // 
            // btnUpdate列表
            // 
            this.btnUpdate列表.AutoSize = true;
            this.btnUpdate列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate列表.Location = new System.Drawing.Point(1025, 130);
            this.btnUpdate列表.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate列表.Name = "btnUpdate列表";
            this.btnUpdate列表.Size = new System.Drawing.Size(133, 42);
            this.btnUpdate列表.TabIndex = 42;
            this.btnUpdate列表.Text = "修改";
            this.btnUpdate列表.UseVisualStyleBackColor = true;
            this.btnUpdate列表.Click += new System.EventHandler(this.btnUpdate列表_Click);
            // 
            // btnInsert列表
            // 
            this.btnInsert列表.AutoSize = true;
            this.btnInsert列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert列表.Location = new System.Drawing.Point(1167, 130);
            this.btnInsert列表.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert列表.Name = "btnInsert列表";
            this.btnInsert列表.Size = new System.Drawing.Size(133, 42);
            this.btnInsert列表.TabIndex = 41;
            this.btnInsert列表.Text = "新增";
            this.btnInsert列表.UseVisualStyleBackColor = true;
            this.btnInsert列表.Click += new System.EventHandler(this.btnInsert列表_Click);
            // 
            // btnDelete明細
            // 
            this.btnDelete明細.AutoSize = true;
            this.btnDelete明細.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete明細.Location = new System.Drawing.Point(884, 528);
            this.btnDelete明細.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete明細.Name = "btnDelete明細";
            this.btnDelete明細.Size = new System.Drawing.Size(133, 42);
            this.btnDelete明細.TabIndex = 46;
            this.btnDelete明細.Text = "刪除";
            this.btnDelete明細.UseVisualStyleBackColor = true;
            this.btnDelete明細.Click += new System.EventHandler(this.btnDelete明細_Click);
            // 
            // btnUpdate明細
            // 
            this.btnUpdate明細.AutoSize = true;
            this.btnUpdate明細.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate明細.Location = new System.Drawing.Point(1025, 527);
            this.btnUpdate明細.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate明細.Name = "btnUpdate明細";
            this.btnUpdate明細.Size = new System.Drawing.Size(133, 42);
            this.btnUpdate明細.TabIndex = 45;
            this.btnUpdate明細.Text = "修改";
            this.btnUpdate明細.UseVisualStyleBackColor = true;
            this.btnUpdate明細.Click += new System.EventHandler(this.btnUpdate明細_Click);
            // 
            // btnInsert明細
            // 
            this.btnInsert明細.AutoSize = true;
            this.btnInsert明細.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert明細.Location = new System.Drawing.Point(1167, 527);
            this.btnInsert明細.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert明細.Name = "btnInsert明細";
            this.btnInsert明細.Size = new System.Drawing.Size(133, 42);
            this.btnInsert明細.TabIndex = 44;
            this.btnInsert明細.Text = "新增";
            this.btnInsert明細.UseVisualStyleBackColor = true;
            this.btnInsert明細.Click += new System.EventHandler(this.btnInsert明細_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
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
            this.lbl標題.Size = new System.Drawing.Size(1312, 62);
            this.lbl標題.TabIndex = 47;
            this.lbl標題.Text = "進貨單列表";
            this.lbl標題.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(0, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1312, 62);
            this.label4.TabIndex = 48;
            this.label4.Text = "進貨單列表";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm進貨單維護
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 826);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl標題);
            this.Controls.Add(this.btnDelete明細);
            this.Controls.Add(this.btnUpdate明細);
            this.Controls.Add(this.btnInsert明細);
            this.Controls.Add(this.btnDelete列表);
            this.Controls.Add(this.btnUpdate列表);
            this.Controls.Add(this.btnInsert列表);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl商品類別);
            this.Controls.Add(this.cmb商品類別);
            this.Controls.Add(this.mskDtEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskDtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.lbl庫存地點);
            this.Controls.Add(this.cmb庫存地點);
            this.Controls.Add(this.lbl廠商);
            this.Controls.Add(this.cmb廠商);
            this.Controls.Add(this.dv進貨單明細);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txt進貨單編號);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dv進貨單列表);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm進貨單維護";
            this.Text = "Frm進貨單維護";
            this.Load += new System.EventHandler(this.Frm進貨單維護_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv進貨單列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv進貨單明細)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dv進貨單列表;
        private System.Windows.Forms.TextBox txt進貨單編號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dv進貨單明細;
        private System.Windows.Forms.Label lbl庫存地點;
        private System.Windows.Forms.ComboBox cmb庫存地點;
        private System.Windows.Forms.Label lbl廠商;
        private System.Windows.Forms.ComboBox cmb廠商;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDtEnd;
        private System.Windows.Forms.Label lbl商品類別;
        private System.Windows.Forms.ComboBox cmb商品類別;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button btnDelete列表;
        private System.Windows.Forms.Button btnUpdate列表;
        private System.Windows.Forms.Button btnInsert列表;
        private System.Windows.Forms.Button btnDelete明細;
        private System.Windows.Forms.Button btnUpdate明細;
        private System.Windows.Forms.Button btnInsert明細;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lbl標題;
        private System.Windows.Forms.Label label4;
    }
}