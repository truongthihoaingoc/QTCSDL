using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace Giaodienbanhang
{
    public partial class FrmKhachhang : Form
    {
        string sCon = "Data Source=tcp:mysqlservernhom5.database.windows.net,1433;Initial Catalog=BAOCAONHOM5;Persist Security Info=True;User ID=azureuser;Password=***********";
        public FrmKhachhang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmKhachhang_Load(object sender, EventArgs e)
        {
            txtMakh.Enabled = false;
            //coppy
           
            hienthikh();

        } //combobox
        


        public void hienthikh()

            {
            baocaonhom5.KhachHangDataTable khachhang = new baocaonhom5.KhachHangDataTable();
            baocaonhom5TableAdapters.KhachHangTableAdapter khachhang1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
            khachhang.Reset();
            khachhang1.Fill(khachhang);
            dataGridViewkh.DataSource = khachhang;

        }

        private void btLuu_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.KhachHangDataTable khachhang = new baocaonhom5.KhachHangDataTable();
                baocaonhom5TableAdapters.KhachHangTableAdapter khachhang1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
                khachhang.Reset();
                khachhang1.Themkh(khachhang,txtTenkh.Text, txtSdt.Text);
                hienthikh();
                txtMakh.Clear();
                txtTenkh.Clear();
                txtSdt.Clear();
                txtTenkh.Focus();

               
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.KhachHangDataTable khachhang = new baocaonhom5.KhachHangDataTable();
                baocaonhom5TableAdapters.KhachHangTableAdapter khachhang1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
                khachhang.Reset();
                string smakh = dataGridViewkh[0, dataGridViewkh.CurrentRow.Index].Value.ToString();
                khachhang1.Xoakh(khachhang, smakh);
                hienthikh();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void dataGridViewkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakh.Text = dataGridViewkh[0, dataGridViewkh.CurrentRow.Index].Value.ToString();
            txtTenkh.Text = dataGridViewkh[1, dataGridViewkh.CurrentRow.Index].Value.ToString();
            txtSdt.Text = dataGridViewkh[2, dataGridViewkh.CurrentRow.Index].Value.ToString();
          

        }
    }
}
