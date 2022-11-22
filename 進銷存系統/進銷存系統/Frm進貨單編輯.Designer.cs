namespace 進銷存系統
{
    partial class Frm進貨單編輯
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
            this.lbl標題 = new System.Windows.Forms.Label();
            this.lbl廠商 = new System.Windows.Forms.Label();
            this.cmb廠商 = new System.Windows.Forms.ComboBox();
            this.txt進貨單編號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl庫存地點 = new System.Windows.Forms.Label();
            this.cmb庫存地點 = new System.Windows.Forms.ComboBox();
            this.msk進貨日期 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt明細筆數 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbl商品類別 = new System.Windows.Forms.Label();
            this.cmb商品類別 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl標題
            // 
            this.lbl標題.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl標題.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl標題.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標題.ForeColor = System.Drawing.Color.Yellow;
            this.lbl標題.Location = new System.Drawing.Point(0, 0);
            this.lbl標題.Name = "lbl標題";
            this.lbl標題.Size = new System.Drawing.Size(884, 50);
            this.lbl標題.TabIndex = 2;
            this.lbl標題.Text = "進貨單編輯";
            this.lbl標題.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl廠商
            // 
            this.lbl廠商.AutoSize = true;
            this.lbl廠商.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl廠商.Location = new System.Drawing.Point(72, 104);
            this.lbl廠商.Name = "lbl廠商";
            this.lbl廠商.Size = new System.Drawing.Size(48, 24);
            this.lbl廠商.TabIndex = 29;
            this.lbl廠商.Text = "廠商";
            // 
            // cmb廠商
            // 
            this.cmb廠商.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb廠商.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb廠商.FormattingEnabled = true;
            this.cmb廠商.Location = new System.Drawing.Point(126, 101);
            this.cmb廠商.Name = "cmb廠商";
            this.cmb廠商.Size = new System.Drawing.Size(385, 32);
            this.cmb廠商.TabIndex = 28;
            // 
            // txt進貨單編號
            // 
            this.txt進貨單編號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt進貨單編號.Location = new System.Drawing.Point(126, 62);
            this.txt進貨單編號.MaxLength = 10;
            this.txt進貨單編號.Name = "txt進貨單編號";
            this.txt進貨單編號.Size = new System.Drawing.Size(80, 33);
            this.txt進貨單編號.TabIndex = 27;
            this.txt進貨單編號.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "進貨單編號";
            // 
            // lbl庫存地點
            // 
            this.lbl庫存地點.AutoSize = true;
            this.lbl庫存地點.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存地點.Location = new System.Drawing.Point(34, 142);
            this.lbl庫存地點.Name = "lbl庫存地點";
            this.lbl庫存地點.Size = new System.Drawing.Size(86, 24);
            this.lbl庫存地點.TabIndex = 31;
            this.lbl庫存地點.Text = "庫存地點";
            // 
            // cmb庫存地點
            // 
            this.cmb庫存地點.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb庫存地點.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb庫存地點.FormattingEnabled = true;
            this.cmb庫存地點.Location = new System.Drawing.Point(126, 139);
            this.cmb庫存地點.Name = "cmb庫存地點";
            this.cmb庫存地點.Size = new System.Drawing.Size(122, 32);
            this.cmb庫存地點.TabIndex = 30;
            // 
            // msk進貨日期
            // 
            this.msk進貨日期.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msk進貨日期.Location = new System.Drawing.Point(638, 56);
            this.msk進貨日期.Mask = "0000/00/00";
            this.msk進貨日期.Name = "msk進貨日期";
            this.msk進貨日期.Size = new System.Drawing.Size(100, 33);
            this.msk進貨日期.TabIndex = 33;
            this.msk進貨日期.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(546, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "進貨日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(546, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "明細筆數";
            // 
            // txt明細筆數
            // 
            this.txt明細筆數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt明細筆數.Location = new System.Drawing.Point(638, 100);
            this.txt明細筆數.MaxLength = 10;
            this.txt明細筆數.Name = "txt明細筆數";
            this.txt明細筆數.Size = new System.Drawing.Size(100, 33);
            this.txt明細筆數.TabIndex = 35;
            this.txt明細筆數.Text = "0";
            this.txt明細筆數.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(666, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(772, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 34);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbl商品類別
            // 
            this.lbl商品類別.AutoSize = true;
            this.lbl商品類別.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品類別.Location = new System.Drawing.Point(34, 217);
            this.lbl商品類別.Name = "lbl商品類別";
            this.lbl商品類別.Size = new System.Drawing.Size(86, 24);
            this.lbl商品類別.TabIndex = 41;
            this.lbl商品類別.Text = "商品類別";
            // 
            // cmb商品類別
            // 
            this.cmb商品類別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb商品類別.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb商品類別.FormattingEnabled = true;
            this.cmb商品類別.Location = new System.Drawing.Point(126, 217);
            this.cmb商品類別.Name = "cmb商品類別";
            this.cmb商品類別.Size = new System.Drawing.Size(130, 32);
            this.cmb商品類別.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(34, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "商品名稱";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(385, 32);
            this.comboBox1.TabIndex = 43;
            // 
            // Frm進貨單編輯
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl商品類別);
            this.Controls.Add(this.cmb商品類別);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt明細筆數);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msk進貨日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl庫存地點);
            this.Controls.Add(this.cmb庫存地點);
            this.Controls.Add(this.lbl廠商);
            this.Controls.Add(this.cmb廠商);
            this.Controls.Add(this.txt進貨單編號);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl標題);
            this.Name = "Frm進貨單編輯";
            this.Text = "Frm進貨單編輯";
            this.Load += new System.EventHandler(this.Frm進貨單編輯_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl標題;
        private System.Windows.Forms.Label lbl廠商;
        private System.Windows.Forms.ComboBox cmb廠商;
        private System.Windows.Forms.TextBox txt進貨單編號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl庫存地點;
        private System.Windows.Forms.ComboBox cmb庫存地點;
        private System.Windows.Forms.MaskedTextBox msk進貨日期;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt明細筆數;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbl商品類別;
        private System.Windows.Forms.ComboBox cmb商品類別;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}