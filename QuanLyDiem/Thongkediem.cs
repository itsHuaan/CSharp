using QuanLyDiem.DAO;
using System;
using System.Collections;
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
	public partial class Thongkediem : Form
	{
		public Thongkediem()
		{
			InitializeComponent();
			LoadThongke();
		}
		void LoadThongke()
		{
			DataProvider data = new DataProvider();
			string query = "select MaSV,TenSV from SinhVien";
			dtgvThongkeDiem.DataSource = data.ExecuteQuery(query);
			cbTklop.DataSource = data.ExecuteQuery("Select *from Lop");
			cbTklop.DisplayMember = "TenLop";
			cbTklop.ValueMember = "MaLop";

		}
		public void cbTklop_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataProvider data = new DataProvider();
			string query = "select Diem.DiemCc,Diem.DiemLan1,Diem.DiemLan2,Diem.DiemThi, Diem.MaMH, SinhVien.MaSV,SinhVien.TenSV From SinhVien,Diem where SinhVien.MaSV = Diem.MaSV and SinhVien.MaLop = '" + cbTklop.SelectedValue + "'";
			DataTable dt = data.ExecuteQuery(query);
			dtgvThongkeDiem.DataSource = dt;
		}


		private void Thongkediem_Load(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'qlDiemSvDataSet4.Diem' table. You can move, or remove it, as needed.
			//this.diemTableAdapter.Fill(this.qlDiemSvDataSet4.Diem);
			//// TODO: This line of code loads data into the 'qlDiemSvDataSet1.Diem' table. You can move, or remove it, as needed.
			//this.diemTableAdapter.Fill(this.qlDiemSvDataSet1.Diem);

		}


		public void btnXemDanhgia_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True");
			string Diemlan1, Diemlan2, Diemthi, Diemcc;
			double Diemhe10 = 0, Diemhe4 = 0, Diemthuongki = 0;
			string xeploai = "";
			int current_row = dtgvThongkeDiem.CurrentRow.Index;
			/*for (int i = 0; i < dtgvThongkeDiem.Rows.Count; i++)
            {
                Diemcc = dtgvThongkeDiem.CurrentRow.Cells["DiemCc"].Value.ToString();
                Diemlan1 = dtgvThongkeDiem.CurrentRow.Cells["DiemLan1"].Value.ToString();
                Diemlan2 = dtgvThongkeDiem.CurrentRow.Cells["DiemLan2"].Value.ToString();
                Diemthi = dtgvThongkeDiem.CurrentRow.Cells["DiemThi"].Value.ToString();
                Diemthuongki =(float.Parse(Diemlan1)+ float.Parse(Diemlan2))/3;
                Diemhe10 = (float.Parse(Diemcc) * 0.1) + (Diemthuongki * 0.3) + (double.Parse(Diemthi)*0.6);
                Diemhe4 = Diemhe10 * 0.4;
                if (Diemhe10 >= 8.5)
                {
                    xeploai = "Giỏi";
                }
                else if (Diemhe10 >= 7)
                {
                    xeploai = "Khá";
                }
                else if (Diemhe10 >= 5.5)
                {
                    xeploai = "Trung bình";
                }
                else if (Diemhe10 >= 4)
                {
                    xeploai = "Yếu";
                }
                else
                {
                    xeploai = "Kém";
                }
            }*/
			Diemcc = dtgvThongkeDiem.Rows[current_row].Cells["DiemCc"].Value.ToString();
			Diemlan1 = dtgvThongkeDiem.Rows[current_row].Cells["DiemLan1"].Value.ToString();
			Diemlan2 = dtgvThongkeDiem.Rows[current_row].Cells["DiemLan2"].Value.ToString();
			Diemthi = dtgvThongkeDiem.Rows[current_row].Cells["DiemThi"].Value.ToString();
			Diemthuongki = (float.Parse(Diemlan1) + (float.Parse(Diemlan2) * 2)) / 3;
			Diemhe10 = (float.Parse(Diemcc) * 0.1) + (Diemthuongki * 0.3) + (double.Parse(Diemthi) * 0.6);
			Diemhe4 = Diemhe10 * 0.4;
			if (Diemhe10 >= 8.5)
			{
				xeploai = "Giỏi";
			}
			else if (Diemhe10 >= 7)
			{
				xeploai = "Khá";
			}
			else if (Diemhe10 >= 5.5)
			{
				xeploai = "Trung bình";
			}
			else if (Diemhe10 >= 4)
			{
				xeploai = "Yếu";
			}
			else
			{
				xeploai = "Kém";
			}
			int selectedrowindex = dtgvThongkeDiem.CurrentRow.Index;
			if (selectedrowindex >= 0)
			{
				try
				{
					MessageBox.Show($"Điểm hệ 10 = {Diemhe10}\nĐiểm hệ 4 = {Diemhe4}\nXếp Loại = {xeploai}", "Đánh giá", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi" + ex.Message);
				}
				conn.Close();
			}
			//void getDiem()
			//{
			//    SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True");
			//    string diemlan1, diemlan2, diemthi, diemcc;
			//    float getdiemhe10 = 0, getdiemhe4 = 0;
			//    string xxeploai = "";
			//    for (int i = 0; i < dtgvThongkeDiem.Rows.Count; i++)
			//    {
			//        diemcc = dtgvThongkeDiem.Rows[0].Cells["DiemCc"].Value.ToString();
			//        diemlan1 = dtgvThongkeDiem.Rows[0].Cells["DiemLan1"].Value.ToString();
			//        diemlan2 = dtgvThongkeDiem.Rows[0].Cells["DiemLan2"].Value.ToString();
			//        diemthi = dtgvThongkeDiem.Rows[0].Cells["DiemThi"].Value.ToString();
			//        getdiemhe10 = (float.Parse(Diemcc) + float.Parse(Diemlan1) + float.Parse(Diemlan2) + float.Parse(Diemthi)) / 4;
			//        getdiemhe4 = (float.Parse(Diemcc) - float.Parse(Diemlan1) - float.Parse(Diemthi)) * 4;
			//        if (Diemhe10 >= 8.5)
			//        {
			//            xeploai = "Giỏi";
			//        }
			//        else if (Diemhe10 >= 7)
			//        {
			//            xeploai = "Khá";
			//        }
			//        else if (Diemhe10 >= 5.5)
			//        {
			//            xeploai = "Trung bình";
			//        }
			//        else if (Diemhe10 >= 4)
			//        {
			//            xeploai = "Yếu";
			//        }
			//        else
			//        {
			//            xeploai = "Kém";
			//        }
			//    }
			//}
		}
	}
}
