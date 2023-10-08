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
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();
			this.ActiveControl = textBox_taikhoan;
			textBox_taikhoan.Focus();
		}

		private void button_thoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button_dangnhap_Click(object sender, EventArgs e)
		{
            using (var connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True"))
            {
                try
                {

                    connection.Open();


                    var command = new SqlCommand("SELECT * FROM Account WHERE Username = @username AND Password = @password", connection);

                    command.Parameters.AddWithValue("@username", textBox_taikhoan.Text);
                    command.Parameters.AddWithValue("@password", textBox_matkhau.Text);

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Menu f = new Menu();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
	}
}
