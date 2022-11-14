namespace 進銷存系統
{
    partial class Frm_搜尋關鍵字
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_查詢列 = new System.Windows.Forms.TextBox();
            this.bTn_確定 = new System.Windows.Forms.Button();
            this.bTn_取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入公司名稱 or 統一編號";
            // 
            // tB_查詢列
            // 
            this.tB_查詢列.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_查詢列.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tB_查詢列.Location = new System.Drawing.Point(40, 63);
            this.tB_查詢列.Name = "tB_查詢列";
            this.tB_查詢列.Size = new System.Drawing.Size(305, 30);
            this.tB_查詢列.TabIndex = 1;
            this.tB_查詢列.TextChanged += new System.EventHandler(this.tB_查詢列_TextChanged);
            // 
            // bTn_確定
            // 
            this.bTn_確定.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTn_確定.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bTn_確定.Location = new System.Drawing.Point(345, 110);
            this.bTn_確定.Name = "bTn_確定";
            this.bTn_確定.Size = new System.Drawing.Size(87, 36);
            this.bTn_確定.TabIndex = 2;
            this.bTn_確定.Text = "確定";
            this.bTn_確定.UseVisualStyleBackColor = true;
            this.bTn_確定.Click += new System.EventHandler(this.bTn_確定_Click);
            // 
            // bTn_取消
            // 
            this.bTn_取消.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTn_取消.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bTn_取消.Location = new System.Drawing.Point(230, 110);
            this.bTn_取消.Name = "bTn_取消";
            this.bTn_取消.Size = new System.Drawing.Size(87, 36);
            this.bTn_取消.TabIndex = 3;
            this.bTn_取消.Text = "取消";
            this.bTn_取消.UseVisualStyleBackColor = true;
            this.bTn_取消.Click += new System.EventHandler(this.bTn_取消_Click);
            // 
            // Frm_搜尋關鍵字
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 167);
            this.Controls.Add(this.bTn_取消);
            this.Controls.Add(this.bTn_確定);
            this.Controls.Add(this.tB_查詢列);
            this.Controls.Add(this.label1);
            this.Name = "Frm_搜尋關鍵字";
            this.Text = "Frm_搜尋關鍵字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_查詢列;
        private System.Windows.Forms.Button bTn_確定;
        private System.Windows.Forms.Button bTn_取消;
    }
}