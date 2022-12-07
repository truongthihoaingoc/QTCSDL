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
    public partial class FrmNhapNVL : Form
    {
        public FrmNhapNVL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            FrmMain Main = new FrmMain();
            Main.Show();
        }

        private void FrmNhapNVL_Load(object sender, EventArgs e)
        {
            //coppy
            txtMaphieu.Enabled = false;
            hienthinnvl();

        }
                
                public void hienthinnvl()
                {
                    baocaonhom5.ChiTietNhapNVLDataTable nvl1 = new baocaonhom5.ChiTietNhapNVLDataTable();
                    baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter nvl2 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                    nvl1.Reset();
                    nvl2.Fill(nvl1);
                    dataGridViewnnvl.DataSource = nvl1;
                }

        private void dataGridViewnvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaphieu.Text = dataGridViewnnvl[0, dataGridViewnnvl.CurrentRow.Index].Value.ToString(); 
            txtTennvl.Text = dataGridViewnnvl[1, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            txtSoluong.Text = dataGridViewnnvl[2, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            txtDongia.Text = dataGridViewnnvl[3, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            txtDonvitinh.Text = dataGridViewnnvl[4, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            txtThanhtien.Text = dataGridViewnnvl[5, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            txtChietkhau.Text = dataGridViewnnvl[6, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            txtManvl.Text = dataGridViewnnvl[7, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
            
        }

        private void txtChieukhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sMaphieu= txtMaphieu.Text;
            string sNgaynhap= dtNgayban.Text;
            string sCongno= txtCongno.Text;
            string sTongtien= txtTongtien.Text;
            string sManv = txtChietkhau.Text;
            string sManvl= txtManvl.Text;
            string sTennvl = txtTennvl.Text;
            string sDonvitinh = txtDonvitinh.Text;
            string sSoluong = txtSoluong.Text;
            string sDongia= txtDongia.Text;
            string sChietkhau = txtChietkhau.Text;
            string sThanhtien = txtThanhtien.Text;
            string sThanhtoan = btThanhtoan.Text;

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sMaphieu = txtMaphieu.Text;
            string sNgaynhap = dtNgayban.Text;
            string sCongno = txtCongno.Text;
            string sTongtien = txtTongtien.Text;
            string sManv = txtChietkhau.Text;
            string sManvl = txtManvl.Text;
            string sTennvl = txtTennvl.Text;
            string sDonvitinh = txtDonvitinh.Text;
            string sSoluong = txtSoluong.Text;
            string sDongia = txtDongia.Text;
            string sChietkhau = txtChietkhau.Text;
            string sThanhtien = txtThanhtien.Text;
            string sThanhtoan = btThanhtoan.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NhapNVLDataTable nnvl = new baocaonhom5.NhapNVLDataTable();
                baocaonhom5TableAdapters.NhapNVLTableAdapter nnvl1 = new baocaonhom5TableAdapters.NhapNVLTableAdapter();
                nnvl.Reset();
                string smaphieu = txtMaphieu.Text;
                //string smaphieu = dataGridViewnnvl[0, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
                //string smanvl = dataGridViewnnvl[5, dataGridViewnnvl.CurrentRow.Index].Value.ToString();
                //nnvl1.Xoannvl(nnvl, smaphieu, smanvl);
                nnvl1.Xoannvl(nnvl, smaphieu);
                baocaonhom5.ChiTietNhapNVLDataTable ctnnvl = new baocaonhom5.ChiTietNhapNVLDataTable();
                baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctnnvl1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                ctnnvl.Reset();
                string sctmaphieu = ("Select MaPhieu from ChiTietNhapNVL where MaPhieu = smaphieu");
                
                nnvl1.Xoannvl(nnvl, sctmaphieu);
                hienthinnvl();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sSoluong = txtSoluong.Text;
            decimal dSoluong = Convert.ToDecimal(sSoluong);
            string sDongia = txtDongia.Text;
            decimal dDongia = Convert.ToDecimal(sDongia);
            decimal dThanhtien = dSoluong * dDongia;
            txtThanhtien.Text = dThanhtien.ToString();
        }
    }
    }

