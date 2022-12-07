using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodienbanhang
{
    public partial class FrmSanpham : Form
    {
        public FrmSanpham()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sMasp = txtMasp.Text;
            string sTensp = txtTensp.Text;
            string sDongia = txtDongia.Text;
        }

        private void FrmSanpham_Load(object sender, EventArgs e)
        {
            txtMasp.Enabled = false;
            //coppy
           
            hienthisanpham();
        }
            
           
            public void hienthisanpham()
            {
                baocaonhom5.SanPhamDataTable sanpham = new baocaonhom5.SanPhamDataTable();
                baocaonhom5TableAdapters.SanPhamTableAdapter sanpham1 = new baocaonhom5TableAdapters.SanPhamTableAdapter();
                sanpham.Reset();
                sanpham1.Fill(sanpham);
                dataGridViewsp.DataSource = sanpham;
            }
        

        private void btThoat_Click(object sender, EventArgs e)
        {
            FrmMain Main = new FrmMain();
            Main.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            string sMasp = txtMasp.Text;
            string sTensp = txtTensp.Text;
            string sDongia = txtDongia.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.SanPhamDataTable sanpham = new baocaonhom5.SanPhamDataTable();
                baocaonhom5TableAdapters.SanPhamTableAdapter sanpham1 = new baocaonhom5TableAdapters.SanPhamTableAdapter();
                sanpham.Reset();
                string smasp = dataGridViewsp[0, dataGridViewsp.CurrentRow.Index].Value.ToString();
                sanpham1.Xoasp(sanpham, smasp);
                hienthisanpham();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void dataGridViewsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.Text = dataGridViewsp[0, dataGridViewsp.CurrentRow.Index].Value.ToString();
            txtTensp.Text = dataGridViewsp[1, dataGridViewsp.CurrentRow.Index].Value.ToString();
            txtDongia.Text = dataGridViewsp[2, dataGridViewsp.CurrentRow.Index].Value.ToString();
           
        }
    }
}
