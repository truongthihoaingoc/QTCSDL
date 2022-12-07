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
    public partial class FrmBanhang : Form
    {
        public FrmBanhang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sMahd = txtMahd.Text;
            string sMakh = txtMakh.Text;
            string sNgayban = dtNgayban.Text;
            string sManv = txtManv.Text;
            string sChietkhau = txtChietkhau.Text;
            string sGhichu = txtGhichu.Text;
            string sTongtien = txtTongtien.Text;
            string sThanhtoan = btThanhtoan.Text;
            string sMasp = txtMasp.Text;
            string sTensp = txtTensp.Text;
            string sSoluong = txtSoluong.Text;
            string sDongia = txtDongia.Text;
            string sThanhtien = txtThanhtien.Text;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            FrmMain Main = new FrmMain();
            Main.Show();
        }

        private void FrmBanhang_Load(object sender, EventArgs e)
        {
            txtMahd.Enabled = false;

            //fill dữ liệu vào lưới
            hienthihoadon();
            hienthidonhang();

            }
            public void hienthihoadon()
            {
                baocaonhom5.HoaDonDataTable donhang = new baocaonhom5.HoaDonDataTable();
                baocaonhom5TableAdapters.HoaDonTableAdapter donhang1 = new baocaonhom5TableAdapters.HoaDonTableAdapter();
                donhang.Reset();
                donhang1.Fill(donhang);
                dataGridViewhd.DataSource = donhang;


            }
        public void hienthidonhang()
        {
            baocaonhom5.ChiTietHoaDonDataTable Hoadon = new baocaonhom5.ChiTietHoaDonDataTable();
            baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter Hoadon1 = new baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter();
            Hoadon.Reset();
            Hoadon1.Fill(Hoadon);
            dataGridViewbh.DataSource = Hoadon;


        }

        private void dataGridViewbh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMahdct.Text = dataGridViewbh[0, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtTensp.Text = dataGridViewbh[1, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtSoluong.Text = dataGridViewbh[2, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtDongia.Text = dataGridViewbh[3, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtThanhtien.Text = dataGridViewbh[4, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtMasp.Text = dataGridViewbh[5, dataGridViewbh.CurrentRow.Index].Value.ToString();
            
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sMahd = txtMahd.Text;
            string sMakh = txtMakh.Text;
            string sNgayban = dtNgayban.Text;
            string sManv = txtManv.Text;
            string sChietkhau = txtChietkhau.Text;
            string sGhichu = txtGhichu.Text;
            string sTongtien = txtTongtien.Text;
            string sThanhtoan = btThanhtoan.Text;
            string sMasp = txtMasp.Text;
            string sTensp = txtTensp.Text;
            string sSoluong = txtSoluong.Text;
            string sDongia = txtDongia.Text;
            string sThanhtien = txtThanhtien.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
             
                baocaonhom5.ChiTietHoaDonDataTable cthd = new baocaonhom5.ChiTietHoaDonDataTable();
                baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter cthd1 = new baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter();
                cthd.Reset();
                string smahd = dataGridViewbh[0, dataGridViewbh.CurrentRow.Index].Value.ToString();
                string smasp = dataGridViewbh[5, dataGridViewbh.CurrentRow.Index].Value.ToString();
                cthd1.Xoacthd(cthd, smahd, smasp);
                hienthidonhang();
                MessageBox.Show("Bạn đã xóa thành công","Thông bá0");



            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahd.Text = dataGridViewhd[0, dataGridViewhd.CurrentRow.Index].Value.ToString();
            dtNgayban.Text = dataGridViewhd[1, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtGhichu.Text = dataGridViewhd[2, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtTongtien.Text = dataGridViewhd[3, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtChietkhau.Text = dataGridViewhd[4, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtManv.Text = dataGridViewhd[5, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtMakh.Text = dataGridViewhd[6, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtMahd.Enabled = false;
        }
    }
    }

