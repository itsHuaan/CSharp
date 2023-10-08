namespace QuanLyDiem
{
    partial class Thongketheomon
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
			this.dtgvTktheoMh = new System.Windows.Forms.DataGridView();
			this.cbbMonhoc = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemCc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgvTktheoMh)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgvTktheoMh
			// 
			this.dtgvTktheoMh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvTktheoMh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvTktheoMh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaMH,
            this.DiemCc,
            this.DiemLan1,
            this.DiemLan2,
            this.DiemThi});
			this.dtgvTktheoMh.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dtgvTktheoMh.Location = new System.Drawing.Point(0, 130);
			this.dtgvTktheoMh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtgvTktheoMh.MultiSelect = false;
			this.dtgvTktheoMh.Name = "dtgvTktheoMh";
			this.dtgvTktheoMh.RowHeadersWidth = 51;
			this.dtgvTktheoMh.RowTemplate.Height = 24;
			this.dtgvTktheoMh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvTktheoMh.Size = new System.Drawing.Size(837, 366);
			this.dtgvTktheoMh.TabIndex = 0;
			// 
			// cbbMonhoc
			// 
			this.cbbMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbMonhoc.FormattingEnabled = true;
			this.cbbMonhoc.Location = new System.Drawing.Point(372, 89);
			this.cbbMonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbbMonhoc.Name = "cbbMonhoc";
			this.cbbMonhoc.Size = new System.Drawing.Size(210, 25);
			this.cbbMonhoc.TabIndex = 1;
			this.cbbMonhoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonhoc_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(269, 92);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chọn môn học:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(256, 29);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(349, 36);
			this.label2.TabIndex = 3;
			this.label2.Text = "Thống kê theo môn học";
			// 
			// MaSV
			// 
			this.MaSV.DataPropertyName = "MaSV";
			this.MaSV.HeaderText = "Mã sinh viên";
			this.MaSV.Name = "MaSV";
			this.MaSV.ReadOnly = true;
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
			// DiemLan2
			// 
			this.DiemLan2.DataPropertyName = "DiemLan2";
			this.DiemLan2.HeaderText = "Điểm hệ số 2";
			this.DiemLan2.Name = "DiemLan2";
			this.DiemLan2.ReadOnly = true;
			// 
			// DiemThi
			// 
			this.DiemThi.DataPropertyName = "DiemThi";
			this.DiemThi.HeaderText = "Điểm học kỳ";
			this.DiemThi.Name = "DiemThi";
			this.DiemThi.ReadOnly = true;
			// 
			// Thongketheomon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 496);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbMonhoc);
			this.Controls.Add(this.dtgvTktheoMh);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Thongketheomon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống kê theo môn học";
			((System.ComponentModel.ISupportInitialize)(this.dtgvTktheoMh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTktheoMh;
        private System.Windows.Forms.ComboBox cbbMonhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemCc;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
	}
}