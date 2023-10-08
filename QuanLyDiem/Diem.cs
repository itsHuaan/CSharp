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
	public partial class Diem : Form
	{
		public Diem()
		{
			InitializeComponent();
			LoadDiemSv();
			clear_form();
		}

		public void clear_form()
		{
            textBox_diemcc.Clear();
            textBox_diemlan1.Clear();
            textBox_diemlan2.Clear();
            textBox_diemthi.Clear();
            textBox_mamh.Clear();
            comboBox_masv.SelectedIndex = -1;
        }
		void LoadDiemSv()
		{
			DataProvider data = new DataProvider();
			dtgvDiem.DataSource = data.ExecuteQuery("Select *from Diem");
			comboBox_masv.DataSource = data.ExecuteQuery("Select *from SinhVien");
			comboBox_masv.DisplayMember = "MaSV";
			comboBox_masv.ValueMember = "MaSV";
		}

        private void button_them_Click(object sender, EventArgs e)
        {
			try
			{
				if (string.IsNullOrEmpty(textBox_diemcc.Text) || string.IsNullOrEmpty(textBox_diemlan1.Text) || string.IsNullOrEmpty(textBox_diemlan2.Text) || string.IsNullOrEmpty(textBox_diemthi.Text) || string.IsNullOrEmpty(textBox_mamh.Text) || comboBox_masv.SelectedIndex < 0)
				{
                    MessageBox.Show("Chưa nhập đủ dữ liệu\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
				else
				{
                    DataProvider data = new DataProvider();
                    string query = "Insert into Diem values('" + textBox_diemcc.Text + "','" + textBox_diemlan1.Text + "', '" + textBox_diemlan2.Text + "', '" + textBox_diemthi.Text + "', '" + comboBox_masv.Text + "', '" + textBox_mamh.Text + "')";
                    data.ExecuteQuery(query);
                    clear_form();
                    LoadDiemSv();
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
                string query = "Update Diem set DiemCc = '" + textBox_diemcc.Text + "', DiemLan1 = '" + textBox_diemlan1.Text + "', DiemLan2 = '" + textBox_diemlan2.Text + "', DiemThi = '" + textBox_diemthi.Text + "', MaSV = '" + comboBox_masv.Text + "' where MaMH = '" + textBox_mamh.Text + "'";
                data.ExecuteQuery(query);
                clear_form();
                LoadDiemSv();
                /*if(string.IsNullOrEmpty(textBox_diemcc.Text) || string.IsNullOrEmpty(textBox_diemlan1.Text) || string.IsNullOrEmpty(textBox_diemlan2.Text) || string.IsNullOrEmpty(textBox_diemthi.Text) || string.IsNullOrEmpty(textBox_mamh.Text) || comboBox_masv.SelectedIndex < 0)
				{
                    MessageBox.Show("Chưa nhập đủ dữ liệu\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
				else
				{
                    DataProvider data = new DataProvider();
                    string query = "Update Diem set DiemCc = '" + textBox_diemcc.Text + "', DiemLan1 = '" + textBox_diemlan1.Text + "', DiemLan2 = '" + textBox_diemlan2.Text + "', DiemThi = '" + textBox_diemthi.Text + "', MaSV = '" + comboBox_masv.Text + "' where MaMH = '" + textBox_mamh.Text + "'";
                    data.ExecuteQuery(query);
                    clear_form();
                    LoadDiemSv();
                }*/
            }
			catch (Exception)
			{
                MessageBox.Show("Cập nhật thất bại\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = dtgvDiem.CurrentRow.Index;
            if (selected_row >= 0)
            {
                textBox_diemcc.Text = dtgvDiem.Rows[selected_row].Cells["DiemCc"].Value.ToString();
                textBox_diemlan1.Text = dtgvDiem.Rows[selected_row].Cells["DiemLan1"].Value.ToString();
                textBox_diemlan2.Text = dtgvDiem.Rows[selected_row].Cells["DiemLan2"].Value.ToString();
                textBox_diemthi.Text = dtgvDiem.Rows[selected_row].Cells["DiemThi"].Value.ToString();
                textBox_mamh.Text = dtgvDiem.Rows[selected_row].Cells["MaMH"].Value.ToString();
                comboBox_masv.SelectedValue = dtgvDiem.Rows[selected_row].Cells["MaSV"].Value;
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
			SqlConnection conn;
			conn = new SqlConnection (@"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True");
			conn.Open ();
			int dongchon = dtgvDiem.CurrentRow.Index;
			SqlCommand cmd = new SqlCommand("delete from Diem where MaSv=@MaSV and MaMH=@MaMH",conn);
			cmd.Parameters.AddWithValue("@MaSV", dtgvDiem.Rows[dongchon].Cells["MaSV"].Value.ToString());
            cmd.Parameters.AddWithValue("@MaMH", dtgvDiem.Rows[dongchon].Cells["MaMH"].Value.ToString());
			cmd.ExecuteNonQuery();
            conn.Close();
			LoadDiemSv();
			
        }

        private void button_export_Click(object sender, EventArgs e)
        {
			string export_time = DateTime.Now.ToString();
			Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
			if (excelApp == null)
			{
				MessageBox.Show("Không tìm thấy Excel trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			excelApp.Visible = true;
			Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
			Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
			for (int i = 0; i < dtgvDiem.Columns.Count; i++)
			{
				worksheet.Cells[2, i + 1] = dtgvDiem.Columns[i].HeaderText;
			}
			for (int i = 0; i < dtgvDiem.Rows.Count; i++)
			{
				for (int j = 0; j < dtgvDiem.Columns.Count; j++)
				{
					worksheet.Cells[i + 3, j + 1] = dtgvDiem.Rows[i].Cells[j].Value?.ToString() ?? "";
				}
			}
			int lastRow = worksheet.UsedRange.Rows.Count;
			int lastColumn = worksheet.UsedRange.Columns.Count;
			worksheet.Cells[1, 1] = "DANH SÁCH ĐIỂM";
			worksheet.Cells[lastRow + 3, lastColumn + 1] = "Thời gian xuất";
			worksheet.Cells[lastRow + 4, lastColumn + 1] = export_time;

			//Format the table
			worksheet.Columns.AutoFit();
			worksheet.Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
			worksheet.Range["a1", "f2"].Font.Bold = true;
			worksheet.Range["a1", "f1"].Merge();
			worksheet.Range["a1", "f1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
		}
    }
}
