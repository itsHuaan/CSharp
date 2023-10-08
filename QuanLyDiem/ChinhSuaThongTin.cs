using QuanLyDiem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
	public partial class ChinhSuaThongTin : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True");
		SqlCommand cmd;
		public ChinhSuaThongTin()
		{
			InitializeComponent();
			LoadGiangvien();
		}

		void LoadGiangvien()
		{
			string query = "Select * from GiangVien";
			DataProvider provider = new DataProvider();
			dtgvGv.DataSource = provider.ExecuteQuery(query);
			dtgvGv.ClearSelection();
		}
		private void button_capnhat_Click(object sender, EventArgs e)
		{
			try
			{
				cmd = new SqlCommand("update GiangVien set TenGv=@TenGv, GioiTinh=@GioiTinh, Phone=@Phone, Email=@Email where MaGv=@MaGv", conn);
				conn.Open();
				cmd.Parameters.AddWithValue("@MaGv", txbMagv.Text);
				cmd.Parameters.AddWithValue("@TenGv", txbTengv.Text);
				if (rdbNam.Checked)
					cmd.Parameters.AddWithValue("@GioiTinh", rdbNam.Text);
				else
					cmd.Parameters.AddWithValue("@GioiTinh", rdbNu.Text);
				cmd.Parameters.AddWithValue("@Phone", txbSodienthoai.Text);
				cmd.Parameters.AddWithValue("@Email", txbMail.Text);

				if (cmd.ExecuteNonQuery() > 0)
				{
					MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadGiangvien();
				}
				else
				{
					MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			catch (Exception)
			{
				MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			conn.Close();

		}

		private void button_thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dtgvGv_SelectionChanged(object sender, EventArgs e)
		{
			int selected_row = dtgvGv.CurrentRow.Index;
			try
			{

				if (selected_row >= 0)
				{
					txbMagv.Text = dtgvGv.Rows[selected_row].Cells["MaGv"].Value.ToString();
					txbTengv.Text = dtgvGv.Rows[selected_row].Cells["TenGv"].Value.ToString();
					if(dtgvGv.Rows[selected_row].Cells["GioiTinh"].Value.ToString().Equals("nam", StringComparison.CurrentCultureIgnoreCase))
						rdbNam.Checked = true;
					else
						rdbNu.Checked = true;
					txbSodienthoai.Text = dtgvGv.Rows[selected_row].Cells["Phone"].Value.ToString();
					txbMail.Text = dtgvGv.Rows[selected_row].Cells["Email"].Value.ToString();
				}
			}
			catch
			{
				
			}
		}
	}
}
