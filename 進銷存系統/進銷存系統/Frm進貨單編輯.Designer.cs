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
            this.btnCancel列表 = new System.Windows.Forms.Button();
            this.btnOK列表 = new System.Windows.Forms.Button();
            this.lbl商品類別 = new System.Windows.Forms.Label();
            this.cmb商品類別 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb商品名稱 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt進貨成本 = new System.Windows.Forms.TextBox();
            this.txt商品數量 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb計算成本 = new System.Windows.Forms.GroupBox();
            this.rabManual = new System.Windows.Forms.RadioButton();
            this.rabAuto = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt備註 = new System.Windows.Forms.TextBox();
            this.pan明細 = new System.Windows.Forms.Panel();
            this.btnCancel明細 = new System.Windows.Forms.Button();
            this.btnOK明細 = new System.Windows.Forms.Button();
            this.gb計算成本.SuspendLayout();
            this.pan明細.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl標題.Size = new System.Drawing.Size(1179, 62);
            this.lbl標題.TabIndex = 2;
            this.lbl標題.Text = "進貨單編輯";
            this.lbl標題.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl廠商
            // 
            this.lbl廠商.AutoSize = true;
            this.lbl廠商.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl廠商.Location = new System.Drawing.Point(96, 130);
            this.lbl廠商.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl廠商.Name = "lbl廠商";
            this.lbl廠商.Size = new System.Drawing.Size(61, 30);
            this.lbl廠商.TabIndex = 29;
            this.lbl廠商.Text = "廠商";
            // 
            // cmb廠商
            // 
            this.cmb廠商.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb廠商.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb廠商.FormattingEnabled = true;
            this.cmb廠商.Location = new System.Drawing.Point(168, 126);
            this.cmb廠商.Margin = new System.Windows.Forms.Padding(4);
            this.cmb廠商.Name = "cmb廠商";
            this.cmb廠商.Size = new System.Drawing.Size(512, 38);
            this.cmb廠商.TabIndex = 28;
            // 
            // txt進貨單編號
            // 
            this.txt進貨單編號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt進貨單編號.Location = new System.Drawing.Point(168, 78);
            this.txt進貨單編號.Margin = new System.Windows.Forms.Padding(4);
            this.txt進貨單編號.MaxLength = 10;
            this.txt進貨單編號.Name = "txt進貨單編號";
            this.txt進貨單編號.Size = new System.Drawing.Size(105, 39);
            this.txt進貨單編號.TabIndex = 27;
            this.txt進貨單編號.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "進貨單編號";
            // 
            // lbl庫存地點
            // 
            this.lbl庫存地點.AutoSize = true;
            this.lbl庫存地點.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存地點.Location = new System.Drawing.Point(45, 178);
            this.lbl庫存地點.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl庫存地點.Name = "lbl庫存地點";
            this.lbl庫存地點.Size = new System.Drawing.Size(109, 30);
            this.lbl庫存地點.TabIndex = 31;
            this.lbl庫存地點.Text = "庫存地點";
            // 
            // cmb庫存地點
            // 
            this.cmb庫存地點.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb庫存地點.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb庫存地點.FormattingEnabled = true;
            this.cmb庫存地點.Location = new System.Drawing.Point(168, 174);
            this.cmb庫存地點.Margin = new System.Windows.Forms.Padding(4);
            this.cmb庫存地點.Name = "cmb庫存地點";
            this.cmb庫存地點.Size = new System.Drawing.Size(161, 38);
            this.cmb庫存地點.TabIndex = 30;
            // 
            // msk進貨日期
            // 
            this.msk進貨日期.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msk進貨日期.Location = new System.Drawing.Point(851, 70);
            this.msk進貨日期.Margin = new System.Windows.Forms.Padding(4);
            this.msk進貨日期.Mask = "0000/00/00";
            this.msk進貨日期.Name = "msk進貨日期";
            this.msk進貨日期.Size = new System.Drawing.Size(132, 39);
            this.msk進貨日期.TabIndex = 33;
            this.msk進貨日期.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(728, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "進貨日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(728, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "明細筆數";
            // 
            // txt明細筆數
            // 
            this.txt明細筆數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt明細筆數.Location = new System.Drawing.Point(851, 125);
            this.txt明細筆數.Margin = new System.Windows.Forms.Padding(4);
            this.txt明細筆數.MaxLength = 10;
            this.txt明細筆數.Name = "txt明細筆數";
            this.txt明細筆數.Size = new System.Drawing.Size(132, 39);
            this.txt明細筆數.TabIndex = 35;
            this.txt明細筆數.Text = "0";
            this.txt明細筆數.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel列表
            // 
            this.btnCancel列表.AutoSize = true;
            this.btnCancel列表.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel列表.Location = new System.Drawing.Point(890, 188);
            this.btnCancel列表.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel列表.Name = "btnCancel列表";
            this.btnCancel列表.Size = new System.Drawing.Size(133, 42);
            this.btnCancel列表.TabIndex = 39;
            this.btnCancel列表.Text = "取消";
            this.btnCancel列表.UseVisualStyleBackColor = true;
            // 
            // btnOK列表
            // 
            this.btnOK列表.AutoSize = true;
            this.btnOK列表.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK列表.Location = new System.Drawing.Point(1031, 188);
            this.btnOK列表.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK列表.Name = "btnOK列表";
            this.btnOK列表.Size = new System.Drawing.Size(133, 42);
            this.btnOK列表.TabIndex = 38;
            this.btnOK列表.Text = "確定";
            this.btnOK列表.UseVisualStyleBackColor = true;
            this.btnOK列表.Click += new System.EventHandler(this.btnOK列表_Click);
            // 
            // lbl商品類別
            // 
            this.lbl商品類別.AutoSize = true;
            this.lbl商品類別.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品類別.Location = new System.Drawing.Point(4, 15);
            this.lbl商品類別.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl商品類別.Name = "lbl商品類別";
            this.lbl商品類別.Size = new System.Drawing.Size(109, 30);
            this.lbl商品類別.TabIndex = 41;
            this.lbl商品類別.Text = "商品類別";
            // 
            // cmb商品類別
            // 
            this.cmb商品類別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb商品類別.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb商品類別.FormattingEnabled = true;
            this.cmb商品類別.Location = new System.Drawing.Point(127, 15);
            this.cmb商品類別.Margin = new System.Windows.Forms.Padding(4);
            this.cmb商品類別.Name = "cmb商品類別";
            this.cmb商品類別.Size = new System.Drawing.Size(172, 38);
            this.cmb商品類別.TabIndex = 40;
            this.cmb商品類別.SelectedIndexChanged += new System.EventHandler(this.cmb商品類別_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(332, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 42;
            this.label4.Text = "商品名稱";
            // 
            // cmb商品名稱
            // 
            this.cmb商品名稱.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb商品名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb商品名稱.FormattingEnabled = true;
            this.cmb商品名稱.Location = new System.Drawing.Point(449, 18);
            this.cmb商品名稱.Margin = new System.Windows.Forms.Padding(4);
            this.cmb商品名稱.Name = "cmb商品名稱";
            this.cmb商品名稱.Size = new System.Drawing.Size(591, 38);
            this.cmb商品名稱.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(332, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 44;
            this.label5.Text = "進貨成本";
            // 
            // txt進貨成本
            // 
            this.txt進貨成本.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt進貨成本.Location = new System.Drawing.Point(456, 80);
            this.txt進貨成本.Margin = new System.Windows.Forms.Padding(4);
            this.txt進貨成本.MaxLength = 10;
            this.txt進貨成本.Name = "txt進貨成本";
            this.txt進貨成本.Size = new System.Drawing.Size(238, 39);
            this.txt進貨成本.TabIndex = 46;
            this.txt進貨成本.Text = "0";
            this.txt進貨成本.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt商品數量
            // 
            this.txt商品數量.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品數量.Location = new System.Drawing.Point(127, 77);
            this.txt商品數量.Margin = new System.Windows.Forms.Padding(4);
            this.txt商品數量.MaxLength = 7;
            this.txt商品數量.Name = "txt商品數量";
            this.txt商品數量.Size = new System.Drawing.Size(172, 39);
            this.txt商品數量.TabIndex = 48;
            this.txt商品數量.Text = "0";
            this.txt商品數量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 47;
            this.label6.Text = "商品數量";
            // 
            // gb計算成本
            // 
            this.gb計算成本.Controls.Add(this.rabManual);
            this.gb計算成本.Controls.Add(this.rabAuto);
            this.gb計算成本.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb計算成本.Location = new System.Drawing.Point(715, 63);
            this.gb計算成本.Name = "gb計算成本";
            this.gb計算成本.Size = new System.Drawing.Size(325, 80);
            this.gb計算成本.TabIndex = 49;
            this.gb計算成本.TabStop = false;
            this.gb計算成本.Text = "依進貨價自動計算成本";
            // 
            // rabManual
            // 
            this.rabManual.AutoSize = true;
            this.rabManual.Location = new System.Drawing.Point(107, 37);
            this.rabManual.Name = "rabManual";
            this.rabManual.Size = new System.Drawing.Size(80, 33);
            this.rabManual.TabIndex = 1;
            this.rabManual.TabStop = true;
            this.rabManual.Text = "手動";
            this.rabManual.UseVisualStyleBackColor = true;
            // 
            // rabAuto
            // 
            this.rabAuto.AutoSize = true;
            this.rabAuto.Location = new System.Drawing.Point(21, 37);
            this.rabAuto.Name = "rabAuto";
            this.rabAuto.Size = new System.Drawing.Size(80, 33);
            this.rabAuto.TabIndex = 0;
            this.rabAuto.TabStop = true;
            this.rabAuto.Text = "自動";
            this.rabAuto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(4, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 30);
            this.label7.TabIndex = 50;
            this.label7.Text = "備註(300字以內)";
            // 
            // txt備註
            // 
            this.txt備註.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt備註.Location = new System.Drawing.Point(11, 166);
            this.txt備註.Margin = new System.Windows.Forms.Padding(4);
            this.txt備註.MaxLength = 300;
            this.txt備註.Multiline = true;
            this.txt備註.Name = "txt備註";
            this.txt備註.Size = new System.Drawing.Size(1135, 120);
            this.txt備註.TabIndex = 51;
            // 
            // pan明細
            // 
            this.pan明細.Controls.Add(this.btnCancel明細);
            this.pan明細.Controls.Add(this.btnOK明細);
            this.pan明細.Controls.Add(this.lbl商品類別);
            this.pan明細.Controls.Add(this.gb計算成本);
            this.pan明細.Controls.Add(this.txt備註);
            this.pan明細.Controls.Add(this.txt進貨成本);
            this.pan明細.Controls.Add(this.cmb商品類別);
            this.pan明細.Controls.Add(this.label5);
            this.pan明細.Controls.Add(this.label7);
            this.pan明細.Controls.Add(this.cmb商品名稱);
            this.pan明細.Controls.Add(this.label6);
            this.pan明細.Controls.Add(this.label4);
            this.pan明細.Controls.Add(this.txt商品數量);
            this.pan明細.Location = new System.Drawing.Point(12, 237);
            this.pan明細.Name = "pan明細";
            this.pan明細.Size = new System.Drawing.Size(1155, 340);
            this.pan明細.TabIndex = 52;
            // 
            // btnCancel明細
            // 
            this.btnCancel明細.AutoSize = true;
            this.btnCancel明細.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel明細.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel明細.Location = new System.Drawing.Point(878, 294);
            this.btnCancel明細.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel明細.Name = "btnCancel明細";
            this.btnCancel明細.Size = new System.Drawing.Size(133, 42);
            this.btnCancel明細.TabIndex = 54;
            this.btnCancel明細.Text = "取消";
            this.btnCancel明細.UseVisualStyleBackColor = true;
            // 
            // btnOK明細
            // 
            this.btnOK明細.AutoSize = true;
            this.btnOK明細.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK明細.Location = new System.Drawing.Point(1019, 294);
            this.btnOK明細.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK明細.Name = "btnOK明細";
            this.btnOK明細.Size = new System.Drawing.Size(133, 42);
            this.btnOK明細.TabIndex = 53;
            this.btnOK明細.Text = "確定";
            this.btnOK明細.UseVisualStyleBackColor = true;
            this.btnOK明細.Click += new System.EventHandler(this.btnOK明細_Click);
            // 
            // Frm進貨單編輯
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 589);
            this.Controls.Add(this.pan明細);
            this.Controls.Add(this.btnCancel列表);
            this.Controls.Add(this.btnOK列表);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm進貨單編輯";
            this.Text = "Frm進貨單編輯";
            this.Load += new System.EventHandler(this.Frm進貨單編輯_Load);
            this.gb計算成本.ResumeLayout(false);
            this.gb計算成本.PerformLayout();
            this.pan明細.ResumeLayout(false);
            this.pan明細.PerformLayout();
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
        private System.Windows.Forms.Button btnCancel列表;
        private System.Windows.Forms.Button btnOK列表;
        private System.Windows.Forms.Label lbl商品類別;
        private System.Windows.Forms.ComboBox cmb商品類別;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb商品名稱;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt進貨成本;
        private System.Windows.Forms.TextBox txt商品數量;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb計算成本;
        private System.Windows.Forms.RadioButton rabAuto;
        private System.Windows.Forms.RadioButton rabManual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt備註;
        private System.Windows.Forms.Panel pan明細;
        private System.Windows.Forms.Button btnCancel明細;
        private System.Windows.Forms.Button btnOK明細;
    }
}