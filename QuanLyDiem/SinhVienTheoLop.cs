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
	public partial class SinhVienTheoLop : Form
	{
		public SinhVienTheoLop()
		{
			InitializeComponent();
            LoadSvtheolop();
		}
        void LoadSvtheolop()
        {
            DataProvider data = new DataProvider();
            dataGridView1.DataSource = data.ExecuteQuery("Select *from SinhVien");
            cbbSvlop.DataSource = data.ExecuteQuery("Select *from Lop");
            cbbSvlop.DisplayMember = "TenLop";
            cbbSvlop.ValueMember = "MaLop";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbSvlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            dataGridView1.DataSource = data.ExecuteQuery("select * from SinhVien where SinhVien.MaLop = '" + cbbSvlop.SelectedValue + "'");
        }
    }
}
