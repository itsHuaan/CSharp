namespace QuanLyDiem
{
	partial class Lop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_khoa = new System.Windows.Forms.ComboBox();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_capnhat = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.textBox_malop = new System.Windows.Forms.TextBox();
            this.textBox_tenlop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvLop = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_khoa);
            this.panel1.Controls.Add(this.button_xoa);
            this.panel1.Controls.Add(this.button_capnhat);
            this.panel1.Controls.Add(this.button_them);
            this.panel1.Controls.Add(this.textBox_malop);
            this.panel1.Controls.Add(this.textBox_tenlop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(288, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 228);
            this.panel1.TabIndex = 20;
            // 
            // comboBox_khoa
            // 
            this.comboBox_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBox_khoa.FormattingEnabled = true;
            this.comboBox_khoa.Location = new System.Drawing.Point(13, 181);
            this.comboBox_khoa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_khoa.Name = "comboBox_khoa";
            this.comboBox_khoa.Size = new System.Drawing.Size(265, 28);
            this.comboBox_khoa.TabIndex = 21;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(329, 181);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(100, 28);
            this.button_xoa.TabIndex = 20;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_capnhat
            // 
            this.button_capnhat.Location = new System.Drawing.Point(329, 112);
            this.button_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.button_capnhat.Name = "button_capnhat";
            this.button_capnhat.Size = new System.Drawing.Size(100, 28);
            this.button_capnhat.TabIndex = 19;
            this.button_capnhat.Text = "Cập nhật";
            this.button_capnhat.UseVisualStyleBackColor = true;
            this.button_capnhat.Click += new System.EventHandler(this.button_capnhat_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(329, 41);
            this.button_them.Margin = new System.Windows.Forms.Padding(4);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(100, 28);
            this.button_them.TabIndex = 18;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // textBox_malop
            // 
            this.textBox_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_malop.Location = new System.Drawing.Point(13, 41);
            this.textBox_malop.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_malop.Name = "textBox_malop";
            this.textBox_malop.Size = new System.Drawing.Size(265, 26);
            this.textBox_malop.TabIndex = 14;
            // 
            // textBox_tenlop
            // 
            this.textBox_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_tenlop.Location = new System.Drawing.Point(13, 112);
            this.textBox_tenlop.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tenlop.Name = "textBox_tenlop";
            this.textBox_tenlop.Size = new System.Drawing.Size(265, 26);
            this.textBox_tenlop.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Khoa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã lớp:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên lớp:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thông tin lớp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvLop
            // 
            this.dtgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.MaKhoa});
            this.dtgvLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvLop.Location = new System.Drawing.Point(0, 298);
            this.dtgvLop.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvLop.Name = "dtgvLop";
            this.dtgvLop.RowHeadersWidth = 51;
            this.dtgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLop.Size = new System.Drawing.Size(1067, 540);
            this.dtgvLop.TabIndex = 21;
            this.dtgvLop.SelectionChanged += new System.EventHandler(this.dtgvLop_SelectionChanged);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 838);
            this.Controls.Add(this.dtgvLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin lớp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_malop;
		private System.Windows.Forms.TextBox textBox_tenlop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_xoa;
		private System.Windows.Forms.Button button_capnhat;
		private System.Windows.Forms.Button button_them;
		private System.Windows.Forms.ComboBox comboBox_khoa;
		private System.Windows.Forms.DataGridView dtgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
    }
}