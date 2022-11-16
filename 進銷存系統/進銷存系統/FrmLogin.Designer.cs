namespace 進銷存系統
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timErr = new System.Windows.Forms.Timer(this.components);
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.txtCheckCode = new System.Windows.Forms.TextBox();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResetPW = new System.Windows.Forms.Button();
            this.btnShowPW = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.lblCheckCode = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdatePW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnNewPW = new System.Windows.Forms.TextBox();
            this.tabLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPW.Location = new System.Drawing.Point(29, 173);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.MaxLength = 20;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(241, 39);
            this.txtPW.TabIndex = 13;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "密碼";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(29, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(232, 39);
            this.txtID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "登入ID";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(8, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 2);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(286, 266);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 42);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(137, 266);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 42);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timErr
            // 
            this.timErr.Tick += new System.EventHandler(this.timErr_Tick);
            // 
            // btnDemo
            // 
            this.btnDemo.AutoSize = true;
            this.btnDemo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDemo.Location = new System.Drawing.Point(2, 381);
            this.btnDemo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(125, 42);
            this.btnDemo.TabIndex = 24;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.AutoSize = true;
            this.btnDemo2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDemo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDemo2.Location = new System.Drawing.Point(145, 377);
            this.btnDemo2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(125, 42);
            this.btnDemo2.TabIndex = 25;
            this.btnDemo2.Text = "Demo2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // txtCheckCode
            // 
            this.txtCheckCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCheckCode.Location = new System.Drawing.Point(28, 184);
            this.txtCheckCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckCode.MaxLength = 6;
            this.txtCheckCode.Name = "txtCheckCode";
            this.txtCheckCode.Size = new System.Drawing.Size(220, 39);
            this.txtCheckCode.TabIndex = 26;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.AutoSize = true;
            this.btnCheckCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckCode.Location = new System.Drawing.Point(268, 184);
            this.btnCheckCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(153, 42);
            this.btnCheckCode.TabIndex = 27;
            this.btnCheckCode.Text = "驗證碼登入";
            this.btnCheckCode.UseVisualStyleBackColor = true;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabPage1);
            this.tabLogin.Controls.Add(this.tabPage2);
            this.tabLogin.Controls.Add(this.tabPage3);
            this.tabLogin.Location = new System.Drawing.Point(-6, 0);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(450, 450);
            this.tabLogin.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnResetPW);
            this.tabPage1.Controls.Add(this.btnShowPW);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDemo2);
            this.tabPage1.Controls.Add(this.btnDemo);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPW);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnResetPW
            // 
            this.btnResetPW.AutoSize = true;
            this.btnResetPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResetPW.Location = new System.Drawing.Point(286, 117);
            this.btnResetPW.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetPW.Name = "btnResetPW";
            this.btnResetPW.Size = new System.Drawing.Size(131, 42);
            this.btnResetPW.TabIndex = 27;
            this.btnResetPW.Text = "重設密碼";
            this.btnResetPW.UseVisualStyleBackColor = true;
            this.btnResetPW.Click += new System.EventHandler(this.btnResetPW_Click);
            // 
            // btnShowPW
            // 
            this.btnShowPW.AutoSize = true;
            this.btnShowPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowPW.Location = new System.Drawing.Point(286, 170);
            this.btnShowPW.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPW.Name = "btnShowPW";
            this.btnShowPW.Size = new System.Drawing.Size(131, 42);
            this.btnShowPW.TabIndex = 26;
            this.btnShowPW.Text = "顯示/隱藏";
            this.btnShowPW.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnCancel2);
            this.tabPage2.Controls.Add(this.lblCheckCode);
            this.tabPage2.Controls.Add(this.txtCheckCode);
            this.tabPage2.Controls.Add(this.btnCheckCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.AutoSize = true;
            this.btnCancel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel2.Location = new System.Drawing.Point(268, 250);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(153, 42);
            this.btnCancel2.TabIndex = 29;
            this.btnCancel2.Text = "取消";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCheckCode
            // 
            this.lblCheckCode.BackColor = System.Drawing.Color.Yellow;
            this.lblCheckCode.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCheckCode.ForeColor = System.Drawing.Color.Red;
            this.lblCheckCode.Location = new System.Drawing.Point(28, 42);
            this.lblCheckCode.Name = "lblCheckCode";
            this.lblCheckCode.Size = new System.Drawing.Size(393, 98);
            this.lblCheckCode.TabIndex = 28;
            this.lblCheckCode.Text = "label3";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdatePW);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtCheckPW);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtnNewPW);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(442, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePW
            // 
            this.btnUpdatePW.AutoSize = true;
            this.btnUpdatePW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdatePW.Location = new System.Drawing.Point(32, 287);
            this.btnUpdatePW.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePW.Name = "btnUpdatePW";
            this.btnUpdatePW.Size = new System.Drawing.Size(241, 42);
            this.btnUpdatePW.TabIndex = 24;
            this.btnUpdatePW.Text = "修改密碼";
            this.btnUpdatePW.UseVisualStyleBackColor = true;
            this.btnUpdatePW.Click += new System.EventHandler(this.btnUpdatePW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "確認密碼";
            // 
            // txtCheckPW
            // 
            this.txtCheckPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCheckPW.Location = new System.Drawing.Point(32, 196);
            this.txtCheckPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckPW.MaxLength = 20;
            this.txtCheckPW.Name = "txtCheckPW";
            this.txtCheckPW.Size = new System.Drawing.Size(241, 39);
            this.txtCheckPW.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "密碼";
            // 
            // txtnNewPW
            // 
            this.txtnNewPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnNewPW.Location = new System.Drawing.Point(32, 83);
            this.txtnNewPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtnNewPW.MaxLength = 20;
            this.txtnNewPW.Name = "txtnNewPW";
            this.txtnNewPW.Size = new System.Drawing.Size(241, 39);
            this.txtnNewPW.TabIndex = 15;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 453);
            this.Controls.Add(this.tabLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系統登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.tabLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timErr;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.TextBox txtCheckCode;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCheckCode;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnShowPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnNewPW;
        private System.Windows.Forms.Button btnUpdatePW;
        private System.Windows.Forms.Button btnResetPW;
    }
}