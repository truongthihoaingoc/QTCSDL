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
    public partial class FrmNguyenvatlieu : Form
    {
        public FrmNguyenvatlieu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            FrmMain Main = new FrmMain();
            Main.Show();
        }

        private void FrmNguyenvatlieu_Load(object sender, EventArgs e)
        {
            txtManvl.Enabled = false;
            //coppy
            hienthinvl();

        } //combobox
        
        public void hienthinvl()
        {


            baocaonhom5.NguyenVatLieuDataTable nvl = new baocaonhom5.NguyenVatLieuDataTable();
            baocaonhom5TableAdapters.NguyenVatLieuTableAdapter nvl1 = new baocaonhom5TableAdapters.NguyenVatLieuTableAdapter();
            nvl.Reset();
            nvl1.Fill(nvl);
            dataGridViewnvl.DataSource = nvl;

        }

        private void btThem_Click(object sender, EventArgs e)
        {

            string sManvl = txtManvl.Text;
            string sTennvl = txtTennvl.Text;
            string sSoluong = txtSoluong.Text;
            string sDonvi = txtDonvi.Text;
            string sKhoiluongtinh = txtKhoiluongtinh.Text;
            string sDonvitinh = txtDonvitinh.Text;
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            string sManvl = txtManvl.Text;
            string sTennvl = txtTennvl.Text;
            string sSoluong = txtSoluong.Text;
            string sDonvi = txtDonvi.Text;
            string sKhoiluongtinh = txtKhoiluongtinh.Text;
            string sDonvitinh = txtDonvitinh.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NguyenVatLieuDataTable nvl = new baocaonhom5.NguyenVatLieuDataTable();
                baocaonhom5TableAdapters.NguyenVatLieuTableAdapter nvl1 = new baocaonhom5TableAdapters.NguyenVatLieuTableAdapter();
                nvl.Reset();
                string smanvl = dataGridViewnvl[0, dataGridViewnvl.CurrentRow.Index].Value.ToString();
                nvl1.Xoanvl(nvl, smanvl);
                hienthinvl();
                MessageBox.Show("Bạn đã xóa thành công");
            }



        }

        private void dataGridViewnvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManvl.Text = dataGridViewnvl[0, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtTennvl.Text = dataGridViewnvl[1, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtSoluong.Text = dataGridViewnvl[2, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtDonvi.Text = dataGridViewnvl[3, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtKhoiluongtinh.Text = dataGridViewnvl[4, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtDonvitinh.Text = dataGridViewnvl[3, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            
        }
    }
}
    