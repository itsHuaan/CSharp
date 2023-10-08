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
	public partial class Lop : Form
	{
		public Lop()
		{
			InitializeComponent();
			LoadLop();
			clear_form();
		}
		public void clear_form()
		{
            textBox_malop.Clear();
            textBox_tenlop.Clear();
			comboBox_khoa.SelectedIndex = -1;
        }
		void LoadLop()
		{
			DataProvider data = new DataProvider();
			dtgvLop.DataSource = data.ExecuteQuery("Select *from Lop");
			comboBox_khoa.DataSource = data.ExecuteQuery("Select *from Khoa");
			comboBox_khoa.DisplayMember = "TenKhoa";
			comboBox_khoa.ValueMember = "MaKhoa";

		}

		private void button_them_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(textBox_malop.Text) || string.IsNullOrEmpty(textBox_tenlop.Text) || comboBox_khoa.SelectedIndex < 0)
				{
                    MessageBox.Show("Chưa nhập đủ dữ liệu\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
				else
				{
                    DataProvider data = new DataProvider();
                    string query = "insert into Lop values('" + textBox_malop.Text + "',N'" + textBox_tenlop.Text + "','" + comboBox_khoa.Text + "')";
                    data.ExecuteQuery(query);
                    clear_form();
                    LoadLop();
                }
			}
			catch (Exception)
			{
                MessageBox.Show("Thêm thất bại\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void button_capnhat_Click(object sender, EventArgs e)
		{
			try
			{
                DataProvider data = new DataProvider();
                string query = "Update Lop set TenLop = N'" + textBox_tenlop.Text + "',MaKhoa = '" + comboBox_khoa.Text + "' where MaLop = '" + textBox_malop.Text + "'";
                data.ExecuteQuery(query);
                clear_form();
                LoadLop();
            }
			catch (Exception)
			{
                MessageBox.Show("Cập nhật thất bại\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void button_xoa_Click(object sender, EventArgs e)
        {
			DataProvider data = new DataProvider();
			string query = "Delete from Lop where MaLop = '" + textBox_malop.Text + "'";
			data.ExecuteQuery(query);
			LoadLop();
        }

        private void dtgvLop_SelectionChanged(object sender, EventArgs e)
        {
			int selected_row = dtgvLop.CurrentRow.Index;
			if (selected_row >= 0)
			{
				textBox_malop.Text = dtgvLop.Rows[selected_row].Cells["MaLop"].Value.ToString();
                textBox_tenlop.Text = dtgvLop.Rows[selected_row].Cells["TenLop"].Value.ToString();
                comboBox_khoa.SelectedValue = dtgvLop.Rows[selected_row].Cells["MaKhoa"].Value;
			}
        }
    }
}
