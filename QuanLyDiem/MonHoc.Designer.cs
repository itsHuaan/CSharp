namespace QuanLyDiem
{
	partial class MonHoc
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
			this.txbMamh = new System.Windows.Forms.TextBox();
			this.txbTenmh = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbHocki = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_giangvien = new System.Windows.Forms.TextBox();
			this.button_xoa = new System.Windows.Forms.Button();
			this.button_capnhat = new System.Windows.Forms.Button();
			this.button_them = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_export = new System.Windows.Forms.Button();
			this.txbSotc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtgvMonHoc = new System.Windows.Forms.DataGridView();
			this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hocki = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
			this.SuspendLayout();
			// 
			// txbMamh
			// 
			this.txbMamh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.txbMamh.Location = new System.Drawing.Point(10, 31);
			this.txbMamh.Name = "txbMamh";
			this.txbMamh.Size = new System.Drawing.Size(200, 22);
			this.txbMamh.TabIndex = 14;
			// 
			// txbTenmh
			// 
			this.txbTenmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.txbTenmh.Location = new System.Drawing.Point(10, 89);
			this.txbTenmh.Name = "txbTenmh";
			this.txbTenmh.Size = new System.Drawing.Size(200, 22);
			this.txbTenmh.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label3.Location = new System.Drawing.Point(246, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Học kỳ:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Mã môn học:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label2.Location = new System.Drawing.Point(10, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Tên môn học:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txbHocki
			// 
			this.txbHocki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.txbHocki.Location = new System.Drawing.Point(246, 31);
			this.txbHocki.Name = "txbHocki";
			this.txbHocki.Size = new System.Drawing.Size(200, 22);
			this.txbHocki.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label4.Location = new System.Drawing.Point(246, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "Mã giảng viên:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_giangvien
			// 
			this.textBox_giangvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.textBox_giangvien.Location = new System.Drawing.Point(246, 89);
			this.textBox_giangvien.Name = "textBox_giangvien";
			this.textBox_giangvien.Size = new System.Drawing.Size(200, 22);
			this.textBox_giangvien.TabIndex = 20;
			// 
			// button_xoa
			// 
			this.button_xoa.Location = new System.Drawing.Point(348, 124);
			this.button_xoa.Name = "button_xoa";
			this.button_xoa.Size = new System.Drawing.Size(75, 23);
			this.button_xoa.TabIndex = 28;
			this.button_xoa.Text = "Xóa";
			this.button_xoa.UseVisualStyleBackColor = true;
			this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
			// 
			// button_capnhat
			// 
			this.button_capnhat.Location = new System.Drawing.Point(267, 124);
			this.button_capnhat.Name = "button_capnhat";
			this.button_capnhat.Size = new System.Drawing.Size(75, 23);
			this.button_capnhat.TabIndex = 27;
			this.button_capnhat.Text = "Cập nhật";
			this.button_capnhat.UseVisualStyleBackColor = true;
			this.button_capnhat.Click += new System.EventHandler(this.button_capnhat_Click);
			// 
			// button_them
			// 
			this.button_them.Location = new System.Drawing.Point(186, 124);
			this.button_them.Name = "button_them";
			this.button_them.Size = new System.Drawing.Size(75, 23);
			this.button_them.TabIndex = 26;
			this.button_them.Text = "Thêm";
			this.button_them.UseVisualStyleBackColor = true;
			this.button_them.Click += new System.EventHandler(this.button_them_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button_export);
			this.panel1.Controls.Add(this.txbSotc);
			this.panel1.Controls.Add(this.txbHocki);
			this.panel1.Controls.Add(this.button_xoa);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button_capnhat);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button_them);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txbTenmh);
			this.panel1.Controls.Add(this.textBox_giangvien);
			this.panel1.Controls.Add(this.txbMamh);
			this.panel1.Location = new System.Drawing.Point(72, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(671, 160);
			this.panel1.TabIndex = 29;
			// 
			// button_export
			// 
			this.button_export.Location = new System.Drawing.Point(429, 124);
			this.button_export.Name = "button_export";
			this.button_export.Size = new System.Drawing.Size(75, 23);
			this.button_export.TabIndex = 31;
			this.button_export.Text = "Xuất";
			this.button_export.UseVisualStyleBackColor = true;
			this.button_export.Click += new System.EventHandler(this.button_export_Click);
			// 
			// txbSotc
			// 
			this.txbSotc.Location = new System.Drawing.Point(490, 33);
			this.txbSotc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbSotc.Name = "txbSotc";
			this.txbSotc.Size = new System.Drawing.Size(167, 20);
			this.txbSotc.TabIndex = 30;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label5.Location = new System.Drawing.Point(497, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 16);
			this.label5.TabIndex = 19;
			this.label5.Text = "Số tín chỉ:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(301, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(236, 29);
			this.label7.TabIndex = 31;
			this.label7.Text = "Thông tin học phần";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtgvMonHoc
			// 
			this.dtgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dtgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.Hocki,
            this.SoTc,
            this.MaGv});
			this.dtgvMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dtgvMonHoc.Location = new System.Drawing.Point(0, 208);
			this.dtgvMonHoc.MultiSelect = false;
			this.dtgvMonHoc.Name = "dtgvMonHoc";
			this.dtgvMonHoc.RowHeadersWidth = 51;
			this.dtgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvMonHoc.Size = new System.Drawing.Size(800, 359);
			this.dtgvMonHoc.TabIndex = 32;
			this.dtgvMonHoc.SelectionChanged += new System.EventHandler(this.dtgvMonHoc_SelectionChanged);
			// 
			// MaMH
			// 
			this.MaMH.DataPropertyName = "MaMH";
			this.MaMH.HeaderText = "Mã môn học";
			this.MaMH.MinimumWidth = 6;
			this.MaMH.Name = "MaMH";
			this.MaMH.ReadOnly = true;
			// 
			// TenMH
			// 
			this.TenMH.DataPropertyName = "TenMH";
			this.TenMH.HeaderText = "Tên môn học";
			this.TenMH.MinimumWidth = 6;
			this.TenMH.Name = "TenMH";
			this.TenMH.ReadOnly = true;
			// 
			// Hocki
			// 
			this.Hocki.DataPropertyName = "Hocki";
			this.Hocki.HeaderText = "Học kì";
			this.Hocki.MinimumWidth = 6;
			this.Hocki.Name = "Hocki";
			this.Hocki.ReadOnly = true;
			// 
			// SoTc
			// 
			this.SoTc.DataPropertyName = "SoTc";
			this.SoTc.HeaderText = "Số tín chỉ";
			this.SoTc.MinimumWidth = 6;
			this.SoTc.Name = "SoTc";
			this.SoTc.ReadOnly = true;
			// 
			// MaGv
			// 
			this.MaGv.DataPropertyName = "MaGv";
			this.MaGv.HeaderText = "Giảng viên";
			this.MaGv.MinimumWidth = 6;
			this.MaGv.Name = "MaGv";
			this.MaGv.ReadOnly = true;
			// 
			// MonHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 567);
			this.Controls.Add(this.dtgvMonHoc);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Name = "MonHoc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin học phần";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbMamh;
		private System.Windows.Forms.TextBox txbTenmh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbHocki;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_giangvien;
		private System.Windows.Forms.Button button_xoa;
		private System.Windows.Forms.Button button_capnhat;
		private System.Windows.Forms.Button button_them;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dtgvMonHoc;
        private System.Windows.Forms.TextBox txbSotc;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hocki;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoTc;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaGv;
        private System.Windows.Forms.Button button_export;
    }
}