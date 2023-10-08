namespace QuanLyDiem
{
	partial class SinhVienTheoLop
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
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbSvlop = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(535, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(231, 29);
			this.label7.TabIndex = 32;
			this.label7.Text = "Sinh viên trong lớp";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 34;
			this.label1.Text = "Chọn lớp: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbbSvlop
			// 
			this.cbbSvlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cbbSvlop.FormattingEnabled = true;
			this.cbbSvlop.Location = new System.Drawing.Point(83, 3);
			this.cbbSvlop.Name = "cbbSvlop";
			this.cbbSvlop.Size = new System.Drawing.Size(213, 28);
			this.cbbSvlop.TabIndex = 33;
			this.cbbSvlop.SelectedIndexChanged += new System.EventHandler(this.cbbSvlop_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbbSvlop);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(482, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 33);
			this.panel1.TabIndex = 35;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.NgaySinh,
            this.QueQuan,
            this.MaLop});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 117);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1264, 564);
			this.dataGridView1.TabIndex = 36;
			// 
			// MaSV
			// 
			this.MaSV.DataPropertyName = "MaSV";
			this.MaSV.FillWeight = 50F;
			this.MaSV.HeaderText = "Mã sinh viên";
			this.MaSV.Name = "MaSV";
			this.MaSV.ReadOnly = true;
			// 
			// TenSV
			// 
			this.TenSV.DataPropertyName = "TenSV";
			this.TenSV.FillWeight = 70F;
			this.TenSV.HeaderText = "Họ và tên";
			this.TenSV.Name = "TenSV";
			this.TenSV.ReadOnly = true;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.FillWeight = 30F;
			this.GioiTinh.HeaderText = "Giới tính";
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.ReadOnly = true;
			// 
			// NgaySinh
			// 
			this.NgaySinh.DataPropertyName = "NgaySinh";
			this.NgaySinh.FillWeight = 50F;
			this.NgaySinh.HeaderText = "Ngày sinh";
			this.NgaySinh.Name = "NgaySinh";
			this.NgaySinh.ReadOnly = true;
			// 
			// QueQuan
			// 
			this.QueQuan.DataPropertyName = "QueQuan";
			this.QueQuan.HeaderText = "Quê quán";
			this.QueQuan.Name = "QueQuan";
			this.QueQuan.ReadOnly = true;
			// 
			// MaLop
			// 
			this.MaLop.DataPropertyName = "MaLop";
			this.MaLop.FillWeight = 40F;
			this.MaLop.HeaderText = "Mã lớp";
			this.MaLop.Name = "MaLop";
			this.MaLop.ReadOnly = true;
			// 
			// SinhVienTheoLop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label7);
			this.Name = "SinhVienTheoLop";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sinh viên trong lớp";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbSvlop;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
	}
}