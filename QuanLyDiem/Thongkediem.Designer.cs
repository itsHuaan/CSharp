namespace QuanLyDiem
{
    partial class Thongkediem
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
			this.cbTklop = new System.Windows.Forms.ComboBox();
			this.dtgvThongkeDiem = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXemDanhgia = new System.Windows.Forms.Button();
			this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemCc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgvThongkeDiem)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Thống kê và xếp loại";
			// 
			// cbTklop
			// 
			this.cbTklop.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbTklop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.cbTklop.FormattingEnabled = true;
			this.cbTklop.Location = new System.Drawing.Point(78, 15);
			this.cbTklop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbTklop.Name = "cbTklop";
			this.cbTklop.Size = new System.Drawing.Size(157, 24);
			this.cbTklop.TabIndex = 3;
			this.cbTklop.SelectedIndexChanged += new System.EventHandler(this.cbTklop_SelectedIndexChanged);
			// 
			// dtgvThongkeDiem
			// 
			this.dtgvThongkeDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvThongkeDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvThongkeDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.MaMH,
            this.DiemCc,
            this.DiemLan1,
            this.Column2,
            this.DiemThi});
			this.dtgvThongkeDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dtgvThongkeDiem.Location = new System.Drawing.Point(0, 108);
			this.dtgvThongkeDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtgvThongkeDiem.MultiSelect = false;
			this.dtgvThongkeDiem.Name = "dtgvThongkeDiem";
			this.dtgvThongkeDiem.ReadOnly = true;
			this.dtgvThongkeDiem.RowHeadersWidth = 51;
			this.dtgvThongkeDiem.RowTemplate.Height = 24;
			this.dtgvThongkeDiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgvThongkeDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvThongkeDiem.Size = new System.Drawing.Size(848, 381);
			this.dtgvThongkeDiem.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label2.Location = new System.Drawing.Point(14, 17);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Chọn lớp:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbTklop);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(300, 51);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 52);
			this.panel1.TabIndex = 6;
			// 
			// btnXemDanhgia
			// 
			this.btnXemDanhgia.Location = new System.Drawing.Point(552, 59);
			this.btnXemDanhgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnXemDanhgia.Name = "btnXemDanhgia";
			this.btnXemDanhgia.Size = new System.Drawing.Size(98, 37);
			this.btnXemDanhgia.TabIndex = 7;
			this.btnXemDanhgia.Text = "Đánh giá";
			this.btnXemDanhgia.UseVisualStyleBackColor = true;
			this.btnXemDanhgia.Click += new System.EventHandler(this.btnXemDanhgia_Click);
			// 
			// MaSV
			// 
			this.MaSV.DataPropertyName = "MaSV";
			this.MaSV.HeaderText = "Mã sinh viên";
			this.MaSV.Name = "MaSV";
			this.MaSV.ReadOnly = true;
			// 
			// TenSV
			// 
			this.TenSV.DataPropertyName = "TenSV";
			this.TenSV.HeaderText = "Họ và tên";
			this.TenSV.Name = "TenSV";
			this.TenSV.ReadOnly = true;
			// 
			// MaMH
			// 
			this.MaMH.DataPropertyName = "MaMH";
			this.MaMH.HeaderText = "Mã môn học";
			this.MaMH.Name = "MaMH";
			this.MaMH.ReadOnly = true;
			// 
			// DiemCc
			// 
			this.DiemCc.DataPropertyName = "DiemCc";
			this.DiemCc.HeaderText = "Điểm chuyên cần";
			this.DiemCc.Name = "DiemCc";
			this.DiemCc.ReadOnly = true;
			// 
			// DiemLan1
			// 
			this.DiemLan1.DataPropertyName = "DiemLan1";
			this.DiemLan1.HeaderText = "Điểm hệ số 1";
			this.DiemLan1.Name = "DiemLan1";
			this.DiemLan1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Column2";
			this.Column2.HeaderText = "Điểm hệ số 2";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// DiemThi
			// 
			this.DiemThi.DataPropertyName = "DiemThi";
			this.DiemThi.HeaderText = "Điểm học kỳ";
			this.DiemThi.Name = "DiemThi";
			this.DiemThi.ReadOnly = true;
			// 
			// Thongkediem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 489);
			this.Controls.Add(this.btnXemDanhgia);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dtgvThongkeDiem);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Thongkediem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống kê và xếp loại";
			this.Load += new System.EventHandler(this.Thongkediem_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvThongkeDiem)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTklop;
        private System.Windows.Forms.DataGridView dtgvThongkeDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemDanhgia;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemCc;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
	}
}