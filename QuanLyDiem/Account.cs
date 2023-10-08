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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            DataProvider data = new DataProvider();
            string query = "Select *from Account";
            dtgvAccount.DataSource = data.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            string query = "Insert into Account values('" + txbUsername.Text + "','" + txbPassword.Text + "','" + txbType.Text + "')";
            data.ExecuteQuery(query);
            LoadAccountList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            string query = "Update Account set Password = '" + txbPassword.Text + "', Type = '" + txbType.Text + "' where Username = '" + txbUsername.Text + "'";
            data.ExecuteQuery(query);
            LoadAccountList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataProvider data =new DataProvider();
            string query = "Delete from Account where Username = '" + txbUsername.Text + "'";
            data.ExecuteQuery(query);
            LoadAccountList();
        }
    }
}
