namespace QuanLyDiem
{
    partial class Account
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
			this.dtgvAccount = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txbType = new System.Windows.Forms.TextBox();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.txbUsername = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtgvAccount
			// 
			this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvAccount.Location = new System.Drawing.Point(9, 10);
			this.dtgvAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtgvAccount.Name = "dtgvAccount";
			this.dtgvAccount.RowHeadersWidth = 51;
			this.dtgvAccount.RowTemplate.Height = 24;
			this.dtgvAccount.Size = new System.Drawing.Size(336, 301);
			this.dtgvAccount.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(350, 13);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "Thêm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(461, 13);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(70, 42);
			this.button2.TabIndex = 3;
			this.button2.Text = "Sửa";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(580, 13);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(70, 42);
			this.button3.TabIndex = 4;
			this.button3.Text = "Xóa";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 67);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tên tài khoản";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mật khẩu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 184);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Loại tài khoản";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txbType);
			this.panel1.Controls.Add(this.txbPassword);
			this.panel1.Controls.Add(this.txbUsername);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(350, 88);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(302, 223);
			this.panel1.TabIndex = 8;
			// 
			// txbType
			// 
			this.txbType.Location = new System.Drawing.Point(100, 184);
			this.txbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbType.Name = "txbType";
			this.txbType.Size = new System.Drawing.Size(189, 20);
			this.txbType.TabIndex = 10;
			// 
			// txbPassword
			// 
			this.txbPassword.Location = new System.Drawing.Point(100, 129);
			this.txbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(189, 20);
			this.txbPassword.TabIndex = 9;
			// 
			// txbUsername
			// 
			this.txbUsername.Location = new System.Drawing.Point(100, 67);
			this.txbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbUsername.Name = "txbUsername";
			this.txbUsername.Size = new System.Drawing.Size(189, 20);
			this.txbUsername.TabIndex = 8;
			// 
			// Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 322);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dtgvAccount);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Account";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tài khoản";
			((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
    }
}