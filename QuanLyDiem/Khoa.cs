using QuanLyDiem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
            LoadKhoaList();
        }

        public void clear_form()
        {
            txbMaKhoa.Clear();
            txbTenKhoa.Clear();
        }
        void LoadKhoaList()
        {
            string query = "Select *from Khoa";
            DataProvider provider = new DataProvider();
            dtgvKhoa.DataSource = provider.ExecuteQuery(query);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txbMaKhoa.Text) || string.IsNullOrEmpty(txbTenKhoa.Text))
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu\nVui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataProvider data = new DataProvider();
                    string query = "Insert into Khoa values('" + txbMaKhoa.Text + "',N'" + txbTenKhoa.Text + "')";
                    data.ExecuteQuery(query);
                    clear_form();
                    LoadKhoaList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại\nVui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            string query = "Update Khoa set TenKhoa = N'" + txbTenKhoa.Text + "' where MaKhoa = '" + txbMaKhoa.Text + "'";
            data.ExecuteQuery(query);
            LoadKhoaList();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = "Delete from Khoa where MaKhoa = '" + txbMaKhoa.Text + "'";
            provider.ExecuteQuery(query);
            LoadKhoaList();
        }

        private void dtgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = dtgvKhoa.CurrentRow.Index;
            if (selected_row >= 0)
            {
                txbMaKhoa.Text = dtgvKhoa.Rows[selected_row].Cells["MaKhoa"].Value.ToString();
                txbTenKhoa.Text = dtgvKhoa.Rows[selected_row].Cells["TenKhoa"].Value.ToString();
            }
        }
    }
}

