namespace QuanLyDiem
{
	partial class Khoa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvKhoa = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thông tin khoa";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txbMaKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txbTenKhoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(100, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 189);
            this.panel1.TabIndex = 18;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(263, 146);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbMaKhoa.Location = new System.Drawing.Point(106, 12);
            this.txbMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(255, 26);
            this.txbMaKhoa.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên khoa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã khoa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(140, 146);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbTenKhoa.Location = new System.Drawing.Point(106, 84);
            this.txbTenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(255, 26);
            this.txbTenKhoa.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 146);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dtgvKhoa
            // 
            this.dtgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dtgvKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvKhoa.Location = new System.Drawing.Point(0, 259);
            this.dtgvKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvKhoa.Name = "dtgvKhoa";
            this.dtgvKhoa.RowHeadersWidth = 51;
            this.dtgvKhoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhoa.Size = new System.Drawing.Size(579, 450);
            this.dtgvKhoa.TabIndex = 19;
            this.dtgvKhoa.SelectionChanged += new System.EventHandler(this.dtgvKhoa_SelectionChanged);
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = " Mã khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 709);
            this.Controls.Add(this.dtgvKhoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txbMaKhoa;
		private System.Windows.Forms.TextBox txbTenKhoa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dtgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    }
}