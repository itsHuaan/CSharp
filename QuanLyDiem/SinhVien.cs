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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyDiem
{
    public partial class SinhVien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True");
        SqlCommand cmd;
        string gender;
        public SinhVien()
        {
            InitializeComponent();
            LoadSinhvienList();
            clear_form();
        }
        void LoadSinhvienList()
        {
            string query = "Select *from SinhVien";
            DataProvider provider = new DataProvider();
            dtgvSinhVien.DataSource = provider.ExecuteQuery(query);
            cbblop.DataSource = provider.ExecuteQuery("Select *from Lop");
            cbblop.DisplayMember = "TenLop";
            cbblop.ValueMember = "MaLop";

        }

        public void clear_form()
        {
            txbQuequan.Clear();
            textBox_hoten.Clear();
            textBox_masv.Clear();
            radioButton_nam.Checked = false;
            radioButton_nu.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            cbblop.SelectedIndex = -1;
            dtgvSinhVien.ClearSelection();
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_masv.Text) || string.IsNullOrEmpty(textBox_hoten.Text) || string.IsNullOrEmpty(txbQuequan.Text) || (!radioButton_nam.Checked && !radioButton_nu.Checked) || cbblop.SelectedIndex < 0)
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (DateTime.Now.Year - dateTimePicker1.Value.Year < 18 || DateTime.Now.Year - dateTimePicker1.Value.Year > 100)
                    {
                        MessageBox.Show("Tuổi không hợp lệ\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        gender = radioButton_nam.Checked ? radioButton_nam.Text : radioButton_nu.Text;
                        cmd = new SqlCommand("insert into SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop)" + "values ('" + textBox_masv.Text + "', '" + textBox_hoten.Text + "', '" + gender + "', '" + dateTimePicker1.Value + "', '" + txbQuequan.Text + "', '" + cbblop.SelectedValue + "')", conn);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSinhvienList();
                        }
                        else
                        {
                            MessageBox.Show("Thêm sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_capnhat_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvSinhVien.CurrentRow.Index;
            if (selectedrowindex >= 0)
            {
                try
                {
                    gender = radioButton_nam.Checked ? radioButton_nam.Text : radioButton_nu.Text;
                    cmd = new SqlCommand("update SinhVien set TenSV=@TenSV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, QueQuan=@QueQuan, MaLop=@MaLop where MaSV=@MaSV", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@MaSV", textBox_masv.Text);
                    cmd.Parameters.AddWithValue("@TenSV", textBox_hoten.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", gender);
                    cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@QueQuan", txbQuequan.Text);
                    cmd.Parameters.AddWithValue("@MaLop", cbblop.SelectedValue.ToString());

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSinhvienList();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            int selectedrowindex = dtgvSinhVien.CurrentRow.Index;
            if (selectedrowindex >= 0)
            {
                string query = "delete from SinhVien where MaSV = '" + textBox_masv.Text + "'";
                data.ExecuteQuery(query);
                LoadSinhvienList();
            }
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            clear_form();
        }

        private void SinhVien_Closed(object sender, FormClosedEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        private void dtgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = dtgvSinhVien.CurrentRow.Index;
            try
            {
                if (selected_row >= 0)
                {
                    textBox_masv.Text = dtgvSinhVien.Rows[selected_row].Cells["MaSV"].Value.ToString();
                    textBox_hoten.Text = dtgvSinhVien.Rows[selected_row].Cells["TenSV"].Value.ToString();
                    txbQuequan.Text = dtgvSinhVien.Rows[selected_row].Cells["QueQuan"].Value.ToString();
                    if (dtgvSinhVien.Rows[selected_row].Cells["GioiTinh"].Value.ToString().Equals("nam", StringComparison.CurrentCultureIgnoreCase))
                        radioButton_nam.Checked = true;
                    else
                        radioButton_nu.Checked = true;
                    dateTimePicker1.Value = Convert.ToDateTime(dtgvSinhVien.Rows[selected_row].Cells["NgaySinh"].Value);
                    cbblop.SelectedValue = dtgvSinhVien.Rows[selected_row].Cells["MaLop"].Value;
                }
            }
            catch (Exception)
            {
                clear_form();
            }
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
			for (int i = 0; i < dtgvSinhVien.Columns.Count; i++)
			{
				worksheet.Cells[2, i + 1] = dtgvSinhVien.Columns[i].HeaderText;
			}
			for (int i = 0; i < dtgvSinhVien.Rows.Count; i++)
			{
				for (int j = 0; j < dtgvSinhVien.Columns.Count; j++)
				{
					worksheet.Cells[i + 3, j + 1] = dtgvSinhVien.Rows[i].Cells[j].Value?.ToString() ?? "";
				}
			}
			int lastRow = worksheet.UsedRange.Rows.Count;
			int lastColumn = worksheet.UsedRange.Columns.Count;
			worksheet.Cells[1, 1] = "DANH SÁCH SINH VIÊN";
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
