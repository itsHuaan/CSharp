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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
            LoadMonHocList();
            clear_form();
        }
        void LoadMonHocList()
        {
            DataProvider data = new DataProvider();
            string query = "select * from MonHoc";
            dtgvMonHoc.DataSource = data.ExecuteQuery(query);
        }

        void clear_form()
        {
            txbMamh.Clear();
            txbTenmh.Clear();
            txbHocki.Clear();
            txbSotc.Clear();
            textBox_giangvien.Clear();
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txbHocki.Text) || string.IsNullOrEmpty(txbMamh.Text) || string.IsNullOrEmpty(txbSotc.Text) || string.IsNullOrEmpty(txbTenmh.Text) || string.IsNullOrEmpty(textBox_giangvien.Text))
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataProvider data = new DataProvider();
                    string query = "INSERT INTO MonHoc VALUES ('" + txbMamh.Text + "', N'" + txbTenmh.Text + "', N'" + txbHocki.Text + "', '" + txbSotc.Text + "', '" + textBox_giangvien.Text + "')";
                    data.ExecuteQuery(query);
                    clear_form();
                    LoadMonHocList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sinh viên thất bại\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_capnhat_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            string query = "UPDATE MonHoc SET TenMH = N'" + txbTenmh.Text + "', HocKi = N'" + txbHocki.Text + "', SoTC = '" + txbSotc.Text + "', MaGV = '" + textBox_giangvien.Text + "' WHERE MaMH = '" + txbMamh.Text + "'";
            data.ExecuteQuery(query);
            LoadMonHocList();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            string query = "DELETE FROM MonHoc WHERE MaMH = '" + txbMamh.Text + "'";
            data.ExecuteQuery(query);
            LoadMonHocList();
        }

        private void dtgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = dtgvMonHoc.CurrentRow.Index;
            if (selected_row >= 0)
            {
                txbMamh.Text = dtgvMonHoc.Rows[selected_row].Cells["MaMH"].Value.ToString();
                txbTenmh.Text = dtgvMonHoc.Rows[selected_row].Cells["TenMH"].Value.ToString();
                txbSotc.Text = dtgvMonHoc.Rows[selected_row].Cells["SoTc"].Value.ToString();
                txbHocki.Text = dtgvMonHoc.Rows[selected_row].Cells["Hocki"].Value.ToString();
                textBox_giangvien.Text = dtgvMonHoc.Rows[selected_row].Cells["MaGv"].Value.ToString();
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
			// Declare a string variable to store the current date and time
			string export_time = DateTime.Now.ToString();

			// Create a new Excel application object
			Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

			// Check if Excel is installed on the system
			if (excelApp == null)
			{
				// If not, show a message box and exit the method
				MessageBox.Show("Không tìm thấy Excel trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Make the Excel application visible
			excelApp.Visible = true;

			// Add a new workbook to the Excel application
			Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

			// Get the active worksheet from the workbook
			Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;

			// Loop through the columns of the dtgvMonHoc DataGridView control
			for (int i = 0; i < dtgvMonHoc.Columns.Count; i++)
			{
				// Write the column header text to the corresponding cell in the worksheet
				worksheet.Cells[2, i + 1] = dtgvMonHoc.Columns[i].HeaderText;
			}

			// Loop through the rows of the dtgvMonHoc DataGridView control
			for (int i = 0; i < dtgvMonHoc.Rows.Count; i++)
			{
				// Loop through the columns of the dtgvMonHoc DataGridView control
				for (int j = 0; j < dtgvMonHoc.Columns.Count; j++)
				{
					// Write the cell value to the corresponding cell in the worksheet, or an empty string if the value is null
					worksheet.Cells[i + 3, j + 1] = dtgvMonHoc.Rows[i].Cells[j].Value?.ToString() ?? "";
				}
			}

			// Get the last used row and column in the worksheet
			int lastRow = worksheet.UsedRange.Rows.Count;
			int lastColumn = worksheet.UsedRange.Columns.Count;

			// Write some text to the first cell in the worksheet
			worksheet.Cells[1, 1] = "DANH SÁCH MÔN HỌC";

			// Write some text to the bottom right cell in the worksheet
			worksheet.Cells[lastRow + 3, lastColumn + 1] = "Thời gian xuất";

			// Write the export time to the next cell in the worksheet
			worksheet.Cells[lastRow + 4, lastColumn + 1] = export_time;

			// Format the table
			worksheet.Columns.AutoFit(); // Adjust the column width to fit the content
			worksheet.Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; // Align the content to the left
			worksheet.Range["a1", "e2"].Font.Bold = true; // Make the font bold for cells A1 to E2
			worksheet.Range["a1", "e1"].Merge(); // Merge cells A1 to E1 into one cell
			worksheet.Range["a1", "e1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; // Align the content to the center for cells A1 to E1

		}
	}
}
