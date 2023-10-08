using QuanLyDiem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Menu_Load(object sender, EventArgs e)
		{
			lb1.Parent = pictureBox1;
			lb1.BackColor = Color.Transparent;
			label2.Parent = pictureBox1;
			label2.BackColor = Color.Transparent;
			timer1.Start();
			

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lb1.Text = DateTime.Now.ToString("D");
			label2.Text = DateTime.Now.ToString("T");
		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChinhSuaThongTin f = new ChinhSuaThongTin();
			f.ShowDialog();
		}

		private void cậpNhậtSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SinhVien f = new SinhVien();
			f.ShowDialog();
		}

		private void cậpNhậtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Khoa f = new Khoa();
			f.ShowDialog();
		}

		private void cậpNhậtKhoaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MonHoc f = new MonHoc();
			f.ShowDialog();
		}

		private void cậpNhậtLớpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lop f = new Lop();
			f.ShowDialog();
		}

		private void danhSáchSinhViênTrongLớpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SinhVienTheoLop f = new SinhVienTheoLop();
			f.ShowDialog();
		}

		private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Diem f = new Diem();
			f.ShowDialog();
		}

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Account f = new Account();
			f.ShowDialog();
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

        private void thốngKêChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Thongketheomon f = new Thongketheomon();
			f.ShowDialog();
        }

        private void thốngKêĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

			Thongkediem f = new Thongkediem();
			f.ShowDialog();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
			ChinhSuaThongTin f = new ChinhSuaThongTin();
			f.ShowDialog();
        }
    }
}
