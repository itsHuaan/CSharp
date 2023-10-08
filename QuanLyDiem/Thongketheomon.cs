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
    public partial class Thongketheomon : Form
    {
        public Thongketheomon()
        {
            InitializeComponent();
            DataProvider data = new DataProvider();
            dtgvTktheoMh.DataSource = data.ExecuteQuery("Select * from Diem");
            cbbMonhoc.DataSource = data.ExecuteQuery("Select * from Diem");
            cbbMonhoc.DisplayMember = "MaMH";
            cbbMonhoc.ValueMember = "MaMH";
        }
        private void cbbMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider(); 
            dtgvTktheoMh.DataSource = data.ExecuteQuery("select * from Diem where Diem.MaMH='"+ cbbMonhoc.SelectedValue+ "'");
        }
    }
}
