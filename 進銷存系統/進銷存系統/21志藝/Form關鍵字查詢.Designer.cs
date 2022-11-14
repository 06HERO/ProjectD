namespace 庫存查詢DEMO
{
    partial class Form關鍵字查詢
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
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn確定 = new System.Windows.Forms.Button();
            this.txtb關鍵字 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(551, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "---請輸入商品關鍵字---";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn取消
            // 
            this.btn取消.BackColor = System.Drawing.Color.Tan;
            this.btn取消.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.Location = new System.Drawing.Point(434, 172);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(84, 35);
            this.btn取消.TabIndex = 14;
            this.btn取消.Text = "取消";
            this.btn取消.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn確定
            // 
            this.btn確定.BackColor = System.Drawing.Color.Tan;
            this.btn確定.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確定.Location = new System.Drawing.Point(318, 172);
            this.btn確定.Name = "btn確定";
            this.btn確定.Size = new System.Drawing.Size(84, 35);
            this.btn確定.TabIndex = 13;
            this.btn確定.Text = "確定";
            this.btn確定.UseVisualStyleBackColor = false;
            this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
            // 
            // txtb關鍵字
            // 
            this.txtb關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtb關鍵字.Location = new System.Drawing.Point(42, 108);
            this.txtb關鍵字.Name = "txtb關鍵字";
            this.txtb關鍵字.Size = new System.Drawing.Size(466, 29);
            this.txtb關鍵字.TabIndex = 15;
            // 
            // Form關鍵字查詢
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(551, 223);
            this.Controls.Add(this.txtb關鍵字);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn確定);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form關鍵字查詢";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form關鍵字查詢";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn確定;
        private System.Windows.Forms.TextBox txtb關鍵字;
    }
}