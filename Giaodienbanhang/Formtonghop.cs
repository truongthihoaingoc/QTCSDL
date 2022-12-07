using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Giaodienbanhang
{
    public partial class Formtonghop : Form
    {
        public Formtonghop()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //coppy
            hienthiluoi();
        }
        public void hienthiluoi()
        {
            baocaonhom5.CongThucDataTable CongThuc = new baocaonhom5.CongThucDataTable();
            baocaonhom5TableAdapters.CongThucTableAdapter CongThuc1 = new baocaonhom5TableAdapters.CongThucTableAdapter();
            CongThuc.Reset();
            CongThuc1.Fill(CongThuc);
            dataGridViewct.DataSource = CongThuc;

        }

        private void Formtonghop_Load(object sender, EventArgs e)
        {


            hienthiluoi();
            hienthinv();
            txtQlmakh.Enabled = false;


            hienthikh();

            hienthinvl();
            hienthinvlct();
            txtnvl.Enabled = false;

            hienthiqlnvl();
            //txtMasp.Enabled = false;

            hienthisanpham();
            //txtMasp.Enabled = false;

            txtMahd.Enabled = false;
            txtMahdct.Enabled = false;


            hienthihoadon();
            hienthidonhang();


            txtmnv.Enabled = false;
            hienthinv();
        }
        public void hienthinv()
        {
            baocaonhom5.NhanVienDataTable nhanvien = new baocaonhom5.NhanVienDataTable();
            baocaonhom5TableAdapters.NhanVienTableAdapter nhanvien1 = new baocaonhom5TableAdapters.NhanVienTableAdapter();
            nhanvien.Reset();
            nhanvien1.Fill(nhanvien);
            dataGridViewnv.DataSource = nhanvien;


        }
        public void hienthikh()

        {
            baocaonhom5.KhachHangDataTable khachhang = new baocaonhom5.KhachHangDataTable();
            baocaonhom5TableAdapters.KhachHangTableAdapter khachhang1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
            khachhang.Reset();
            khachhang1.Fill(khachhang);
            dataGridViewkh.DataSource = khachhang;

        }
        public void hienthinvl()
        {
            baocaonhom5.NhapNVLDataTable nvl = new baocaonhom5.NhapNVLDataTable();
            baocaonhom5TableAdapters.NhapNVLTableAdapter nvl1 = new baocaonhom5TableAdapters.NhapNVLTableAdapter();
            nvl.Reset();
            nvl1.Fill(nvl);
            dataGridViewnhapnvl.DataSource = nvl;
            txtMp.Enabled = false;



        }

        public void hienthinvlct()
        {
            baocaonhom5.ChiTietNhapNVLDataTable nvlct = new baocaonhom5.ChiTietNhapNVLDataTable();
            baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter nvlct1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
            nvlct.Reset();
            nvlct1.Fill(nvlct);
            dataGridViewnvlct.DataSource = nvlct;
        }
        public void hienthiqlnvl()
        {


            baocaonhom5.NguyenVatLieuDataTable nvl = new baocaonhom5.NguyenVatLieuDataTable();
            baocaonhom5TableAdapters.NguyenVatLieuTableAdapter nvl1 = new baocaonhom5TableAdapters.NguyenVatLieuTableAdapter();
            nvl.Reset();
            nvl1.Fill(nvl);
            dataGridViewnvl.DataSource = nvl;

        }
        public void hienthisanpham()
        {
            baocaonhom5.SanPhamDataTable sanpham = new baocaonhom5.SanPhamDataTable();
            baocaonhom5TableAdapters.SanPhamTableAdapter sanpham1 = new baocaonhom5TableAdapters.SanPhamTableAdapter();
            sanpham.Reset();
            sanpham1.Fill(sanpham);
            dataGridViewsp.DataSource = sanpham;
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




        private void tabControl7_Click(object sender, EventArgs e)
        {
        }

        private void tabControl6_Click(object sender, EventArgs e)
        {


        }





        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maphieu = dataGridViewnvlct[0, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
                baocaonhom5.ChiTietNhapNVLDataTable ctnnvl = new baocaonhom5.ChiTietNhapNVLDataTable();
                baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctnnvl1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                ctnnvl.Reset();
                ctnnvl1.Suactnnvl(ctnnvl, maphieu, txtTennvl.Text, Convert.ToInt32(txtslnvl.Text), Convert.ToInt32(txtdgnvl.Text), txtdvtnvl.Text, Convert.ToInt32(txtTtnvl.Text), Convert.ToInt32(txtck.Text), txtmanvlct.Text);
                hienthinvlct();
                MessageBox.Show("Bạn đã sửa thành công");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.ChiTietNhapNVLDataTable ctnnvl = new baocaonhom5.ChiTietNhapNVLDataTable();
                baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctnnvl1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                ctnnvl.Reset();
                string smaphieu = dataGridViewnvlct[0, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
                string smanvl = dataGridViewnvlct[7, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
                ctnnvl1.Xoactn(ctnnvl, smaphieu, smanvl);
                hienthinvl();
                hienthinvlct();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.ChiTietNhapNVLDataTable ctn = new baocaonhom5.ChiTietNhapNVLDataTable();
                baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctn1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                ctn.Reset();
                ctn1.Themctnnvl(ctn, txtmpnvl.Text, txtTennvl.Text, Convert.ToInt32(txtslnvl.Text), Convert.ToInt32(txtdgnvl.Text), txtdvtnvl.Text, Convert.ToInt32(txtTtnvl.Text), Convert.ToInt32(txtck.Text), txtmanvlct.Text);
                hienthinvlct();
                txtTennvl.Clear();
                txtslnvl.Clear();
                txtdgnvl.Clear();
                txtTtnvl.Clear();
                txtck.Clear();
                txtmanvlct.Clear();
                txtmanvlct.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                    "warning",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtmpnvl.Clear();
                txtTennvl.Clear();
                txtmanvlct.Clear();
                txtdvtnvl.Clear();
                txtslnvl.Clear();
                txtck.Clear();
                txttkmct.Clear();
                txtTtnvl.Clear();
                txtdgnvl.Clear();
               // txtdgnvl.Enabled = true;
                txtmpnvl.Focus();
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {





        }



        private void tabControl5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCtsp.Clear();
                txtMasp.Clear();
                txtManvl.Clear();
                txtLuongnvl.Clear();
                txtDonvitinh.Clear();

                txtCtsp.Enabled = true;
                txtCtsp.Focus();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.CongThucDataTable congthuc = new baocaonhom5.CongThucDataTable();
                baocaonhom5TableAdapters.CongThucTableAdapter congthuc1 = new baocaonhom5TableAdapters.CongThucTableAdapter();
                congthuc.Reset();
                congthuc1.Themct(congthuc, txtCtsp.Text, txtMasp.Text, txtManvl.Text, Convert.ToInt32(txtLuongnvl.Text), txtDonvitinh.Text);
                hienthiluoi();
                txtCtsp.Clear();
                txtMasp.Clear();
                txtManvl.Clear();
                txtLuongnvl.Clear();
                txtDonvitinh.Clear();
                txtMasp.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.CongThucDataTable congthuc = new baocaonhom5.CongThucDataTable();
                baocaonhom5TableAdapters.CongThucTableAdapter congthuc1 = new baocaonhom5TableAdapters.CongThucTableAdapter();
                congthuc.Reset();
                string smact = dataGridViewct[0, dataGridViewct.CurrentRow.Index].Value.ToString();
                congthuc1.Xoact(congthuc, smact);
                hienthiluoi();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void dataGridViewct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCtsp.Text = dataGridViewct[0, dataGridViewct.CurrentRow.Index].Value.ToString();
            txtMasp.Text = dataGridViewct[1, dataGridViewct.CurrentRow.Index].Value.ToString();
            txtManvl.Text = dataGridViewct[2, dataGridViewct.CurrentRow.Index].Value.ToString();
            txtLuongnvl.Text = dataGridViewct[3, dataGridViewct.CurrentRow.Index].Value.ToString();
            txtDonvitinh.Text = dataGridViewct[4, dataGridViewct.CurrentRow.Index].Value.ToString();
            txtCtsp.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mact = dataGridViewct[0, dataGridViewct.CurrentRow.Index].Value.ToString();
                baocaonhom5.CongThucDataTable congthuc = new baocaonhom5.CongThucDataTable();
                baocaonhom5TableAdapters.CongThucTableAdapter congthuc1 = new baocaonhom5TableAdapters.CongThucTableAdapter();
                congthuc.Reset();
                congthuc1.Suact(congthuc, mact, txtMasp.Text, txtManvl.Text, Convert.ToInt32(txtLuongnvl.Text), txtDonvitinh.Text);
                hienthiluoi();
                MessageBox.Show("Bạn đã sửa thành công");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtQlmakh.Clear();
                txtTenkh.Clear();
                txtSdt.Clear();
                txtQlmakh.Enabled = true;
                txtTenkh.Focus();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.KhachHangDataTable khachhang = new baocaonhom5.KhachHangDataTable();
                baocaonhom5TableAdapters.KhachHangTableAdapter khachhang1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
                khachhang.Reset();
                khachhang1.Themkh(khachhang, txtTenkh.Text, txtSdt.Text);
                hienthikh();
                txtQlmakh.Clear();
                txtTenkh.Clear();
                txtSdt.Clear();

                txtTenkh.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            baocaonhom5.CongThucDataTable congthuc = new baocaonhom5.CongThucDataTable();
            baocaonhom5TableAdapters.CongThucTableAdapter congthuc1 = new baocaonhom5TableAdapters.CongThucTableAdapter();
            congthuc.Reset();
            string mact = txttkmct.Text;
            dataGridViewct.DataSource = congthuc1.tkmct(congthuc, mact);
        }





        private void dataGridViewkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQlmakh.Text = dataGridViewkh[0, dataGridViewkh.CurrentRow.Index].Value.ToString();
            txtTenkh.Text = dataGridViewkh[1, dataGridViewkh.CurrentRow.Index].Value.ToString();
            txtSdt.Text = dataGridViewkh[2, dataGridViewkh.CurrentRow.Index].Value.ToString();
            txtQlmakh.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string makh = dataGridViewkh[0, dataGridViewkh.CurrentRow.Index].Value.ToString();
                baocaonhom5.KhachHangDataTable suakh = new baocaonhom5.KhachHangDataTable();
                baocaonhom5TableAdapters.KhachHangTableAdapter suakh1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
                suakh.Reset();
                suakh1.Suakh(suakh, txtQlmakh.Text, txtTenkh.Text, txtSdt.Text);
                hienthikh();
                MessageBox.Show("Bạn đã sửa thành công");
            }
        }

        private void bttkkh_Click(object sender, EventArgs e)
        {
            timkiemcongthuc();
        }
        public void timkiemcongthuc()
        {
            /*baocaonhom5.CongThucDataTable CongThuc = new baocaonhom5.CongThucDataTable();
            baocaonhom5TableAdapters.CongThucTableAdapter CongThuc1 = new baocaonhom5TableAdapters.CongThucTableAdapter();
            CongThuc.Reset();
            CongThuc1.Fill(CongThuc);
            dataGridViewct.DataSource = CongThuc("select * from congthuc where mact like '%" + txttkmct.Text + "%'");
            */
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.KhachHangDataTable xoakh = new baocaonhom5.KhachHangDataTable();
                baocaonhom5TableAdapters.KhachHangTableAdapter xoakh1 = new baocaonhom5TableAdapters.KhachHangTableAdapter();
                xoakh.Reset();
                string smakh = dataGridViewkh[0, dataGridViewkh.CurrentRow.Index].Value.ToString();
                xoakh1.Xoakh(xoakh, smakh);
                hienthikh();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtmnv.Clear();
                txtTennv.Clear();
                txtSdtnv.Clear();
                txtDiachi.Clear();
                txtmnv.Enabled = true;
                txtTennv.Focus();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NhanVienDataTable themnv = new baocaonhom5.NhanVienDataTable();
                baocaonhom5TableAdapters.NhanVienTableAdapter themnv1 = new baocaonhom5TableAdapters.NhanVienTableAdapter();
                themnv.Reset();
                themnv1.Themnv(themnv, txtTennv.Text, txtSdtnv.Text, txtDiachi.Text);
                hienthinv();
                txtmnv.Clear();
                txtTennv.Clear();
                txtSdtnv.Clear();
                txtDiachi.Clear();

                txtTenkh.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string manv = dataGridViewnv[0, dataGridViewnv.CurrentRow.Index].Value.ToString();
                baocaonhom5.NhanVienDataTable suanv = new baocaonhom5.NhanVienDataTable();
                baocaonhom5TableAdapters.NhanVienTableAdapter suanv1 = new baocaonhom5TableAdapters.NhanVienTableAdapter();
                suanv.Reset();
                suanv1.Suanv(suanv, txtmnv.Text, txtTennv.Text, txtSdtnv.Text, txtDiachi.Text);
                hienthinv();
                MessageBox.Show("Bạn đã sửa thành công");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NhanVienDataTable xoanv = new baocaonhom5.NhanVienDataTable();
                baocaonhom5TableAdapters.NhanVienTableAdapter xoanv1 = new baocaonhom5TableAdapters.NhanVienTableAdapter();
                xoanv.Reset();
                string smanv = dataGridViewnv[0, dataGridViewnv.CurrentRow.Index].Value.ToString();
                xoanv1.Xoanv(xoanv, smanv);
                hienthinv();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void dataGridViewnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmnv.Text = dataGridViewnv[0, dataGridViewnv.CurrentRow.Index].Value.ToString();
            txtTennv.Text = dataGridViewnv[1, dataGridViewnv.CurrentRow.Index].Value.ToString();
            txtSdtnv.Text = dataGridViewnv[2, dataGridViewnv.CurrentRow.Index].Value.ToString();
            txtDiachi.Text = dataGridViewnv[3, dataGridViewnv.CurrentRow.Index].Value.ToString();
            txtmnv.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtQlmnvl.Clear();
                txtQltennvl.Clear();
                txtQlsoluong.Clear();
                txtDonvi.Clear();
                txtQldvt.Clear();
                txtKhoiluongtinh.Clear();
                txtQlmnvl.Enabled = true;
                txtQltennvl.Focus();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                         "warning",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NguyenVatLieuDataTable themnvl = new baocaonhom5.NguyenVatLieuDataTable();
                baocaonhom5TableAdapters.NguyenVatLieuTableAdapter themnvl1 = new baocaonhom5TableAdapters.NguyenVatLieuTableAdapter();
                themnvl.Reset();
                themnvl1.Themnvl(themnvl, txtQltennvl.Text, Convert.ToInt32(txtQlsoluong.Text), txtDonvi.Text, Convert.ToInt32(txtKhoiluongtinh.Text), txtQldvt.Text);

                hienthiqlnvl();
                txtQlmnvl.Clear();
                txtQltennvl.Clear();
                txtDonvi.Clear();
                txtQldvt.Clear();
                txtKhoiluongtinh.Clear();


                txtQltennvl.Focus();
                MessageBox.Show("Bạn đã thêm thành công");

            }

        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string manvl = dataGridViewnvl[0, dataGridViewnvl.CurrentRow.Index].Value.ToString();
                baocaonhom5.NguyenVatLieuDataTable suanvl = new baocaonhom5.NguyenVatLieuDataTable();
                baocaonhom5TableAdapters.NguyenVatLieuTableAdapter suanvl1 = new baocaonhom5TableAdapters.NguyenVatLieuTableAdapter();
                suanvl.Reset();
                suanvl1.Suanvl(suanvl, manvl, txtQltennvl.Text, Convert.ToInt32(txtQlsoluong.Text), txtDonvi.Text, Convert.ToInt32(txtKhoiluongtinh.Text), txtQldvt.Text);
                hienthiqlnvl();
                MessageBox.Show("Bạn đã sửa thành công");
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                    "warning",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NguyenVatLieuDataTable xoanvl = new baocaonhom5.NguyenVatLieuDataTable();
                baocaonhom5TableAdapters.NguyenVatLieuTableAdapter xoanvl1 = new baocaonhom5TableAdapters.NguyenVatLieuTableAdapter();
                xoanvl.Reset();
                string smanvl = dataGridViewnvl[0, dataGridViewnvl.CurrentRow.Index].Value.ToString();
                xoanvl1.Xoanvl(xoanvl, smanvl);
                hienthiqlnvl();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void dataGridViewnvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQlmnvl.Text = dataGridViewnvl[0, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtQltennvl.Text = dataGridViewnvl[1, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtQlsoluong.Text = dataGridViewnvl[2, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtDonvi.Text = dataGridViewnvl[3, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtKhoiluongtinh.Text = dataGridViewnvl[4, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtQldvt.Text = dataGridViewnvl[5, dataGridViewnvl.CurrentRow.Index].Value.ToString();
            txtQlmnvl.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                    "warning",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtQlmsp.Clear();
                txtQltsp.Clear();
                txtQldg.Clear();

                txtQlmsp.Enabled = true;
                txtQltsp.Focus();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                        "warning",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.SanPhamDataTable themsp = new baocaonhom5.SanPhamDataTable();
                baocaonhom5TableAdapters.SanPhamTableAdapter themsp1 = new baocaonhom5TableAdapters.SanPhamTableAdapter();
                themsp.Reset();
                themsp1.Themsp(themsp, txtQltsp.Text, Convert.ToInt32(txtQldg.Text));

                hienthisanpham();
                txtQlmsp.Clear();
                txtQltsp.Clear();
                txtQldg.Clear();
                txtQltsp.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void btSuasp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string masp = dataGridViewsp[0, dataGridViewsp.CurrentRow.Index].Value.ToString();
                baocaonhom5.SanPhamDataTable suasp = new baocaonhom5.SanPhamDataTable();
                baocaonhom5TableAdapters.SanPhamTableAdapter suasp1 = new baocaonhom5TableAdapters.SanPhamTableAdapter();
                suasp.Reset();
                suasp1.Suasp(suasp, masp, txtQltsp.Text, Convert.ToInt32(txtQldg.Text));
                MessageBox.Show("Bạn đã sửa thành công");
                hienthisanpham();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                 "warning",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.SanPhamDataTable xoasp = new baocaonhom5.SanPhamDataTable();
                baocaonhom5TableAdapters.SanPhamTableAdapter xoasp1 = new baocaonhom5TableAdapters.SanPhamTableAdapter();
                xoasp.Reset();
                string smasp = dataGridViewsp[0, dataGridViewsp.CurrentRow.Index].Value.ToString();
                xoasp1.Xoasp(xoasp, smasp);
                hienthisanpham();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void dataGridViewsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQlmsp.Text = dataGridViewsp[0, dataGridViewsp.CurrentRow.Index].Value.ToString();
            txtQltsp.Text = dataGridViewsp[1, dataGridViewsp.CurrentRow.Index].Value.ToString();
            txtQldg.Text = dataGridViewsp[2, dataGridViewsp.CurrentRow.Index].Value.ToString();
            txtQlmsp.Enabled = false;
        }

        private void dataGridViewbh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahd.Text = dataGridViewbh[0, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtTensp.Text = dataGridViewbh[1, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtSoluong.Text = dataGridViewbh[2, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtDongia.Text = dataGridViewbh[3, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtThanhtien.Text = dataGridViewbh[4, dataGridViewbh.CurrentRow.Index].Value.ToString();
            txtMasphd.Text = dataGridViewbh[5, dataGridViewbh.CurrentRow.Index].Value.ToString();
        }

        private void dataGridViewhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahdct.Text = dataGridViewhd[0, dataGridViewhd.CurrentRow.Index].Value.ToString();
            dtNgayban.Text = dataGridViewhd[1, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtGhichu.Text = dataGridViewhd[2, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtTongtien.Text = dataGridViewhd[3, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtChietkhau.Text = dataGridViewhd[4, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtManv.Text = dataGridViewhd[5, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtMakh.Text = dataGridViewhd[6, dataGridViewhd.CurrentRow.Index].Value.ToString();
            txtMahdct.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string sSoluong = txtslnvl.Text;
            decimal dSoluong = Convert.ToDecimal(sSoluong);
            string sDongia = txtdgnvl.Text;
            decimal dDongia = Convert.ToDecimal(sDongia);
            decimal dThanhtien = dSoluong * dDongia;
            txtTtnvl.Text = dThanhtien.ToString();
        }

        private void dataGridViewnvlct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmpnvl.Text = dataGridViewnvlct[0, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtTennvl.Text = dataGridViewnvlct[1, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtslnvl.Text = dataGridViewnvlct[2, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtdgnvl.Text = dataGridViewnvlct[3, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtdvtnvl.Text = dataGridViewnvlct[4, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtTtnvl.Text = dataGridViewnvlct[5, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtck.Text = dataGridViewnvlct[6, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
            txtmanvlct.Text = dataGridViewnvlct[7, dataGridViewnvlct.CurrentRow.Index].Value.ToString();
        }

        private void dataGridViewnhapnvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMp.Text = dataGridViewnhapnvl[0, dataGridViewnhapnvl.CurrentRow.Index].Value.ToString();
            dtNgaynhap.Text = dataGridViewnhapnvl[1, dataGridViewnhapnvl.CurrentRow.Index].Value.ToString();

            textTongtien.Text = dataGridViewnhapnvl[2, dataGridViewnhapnvl.CurrentRow.Index].Value.ToString();
            txtTt.Text = dataGridViewnhapnvl[3, dataGridViewnhapnvl.CurrentRow.Index].Value.ToString();
            txtCongno.Text = dataGridViewnhapnvl[4, dataGridViewnhapnvl.CurrentRow.Index].Value.ToString();
            txtQlmanv.Text = dataGridViewnhapnvl[5, dataGridViewnhapnvl.CurrentRow.Index].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.HoaDonDataTable hd = new baocaonhom5.HoaDonDataTable();
                baocaonhom5TableAdapters.HoaDonTableAdapter hd1 = new baocaonhom5TableAdapters.HoaDonTableAdapter();
                hd.Reset();

                hd1.themhd(hd, dtNgayban.Value, txtGhichu.Text, Convert.ToInt32(txtTongtien.Text), Convert.ToInt32(txtChietkhau.Text), txtManv.Text, txtMakh.Text);
                hienthihoadon();

                txtMahdct.Clear();
                txtGhichu.Clear();
                txtChietkhau.Clear();
                txtManv.Clear();
                txtMakh.Clear();
                txtTongtien.Clear();
                MessageBox.Show("Bạn đã thêm thành công");
                    }
        
        }
        private void button35_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NhapNVLDataTable nhapnvl = new baocaonhom5.NhapNVLDataTable();
                baocaonhom5TableAdapters.NhapNVLTableAdapter nhapnvl1 = new baocaonhom5TableAdapters.NhapNVLTableAdapter();
                nhapnvl.Reset();
                string smaphieu = txtMp.Text;
                nhapnvl1.Xoannvl(nhapnvl, smaphieu);
                baocaonhom5.ChiTietNhapNVLDataTable ctnnvl = new baocaonhom5.ChiTietNhapNVLDataTable();
                baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctnnvl1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                ctnnvl.Reset();
                ctnnvl1.Xoactn_nvl(ctnnvl, smaphieu);
                hienthinvl();
                hienthinvlct();
                MessageBox.Show("Bạn đã xóa thành công");
            }

        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                          "warning",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.HoaDonDataTable hoadon = new baocaonhom5.HoaDonDataTable();
                baocaonhom5TableAdapters.HoaDonTableAdapter hoadon1 = new baocaonhom5TableAdapters.HoaDonTableAdapter();
                hoadon.Reset();
                string smahd = txtMahdct.Text;
                hoadon1.Xoahd(hoadon, smahd);
                baocaonhom5.ChiTietHoaDonDataTable cthd = new baocaonhom5.ChiTietHoaDonDataTable();
                baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter cthd1 = new baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter();
                cthd.Reset();
                cthd1.Xoacthd_hd(cthd, smahd);
                hienthihoadon();
                hienthidonhang();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.ChiTietHoaDonDataTable cthd = new baocaonhom5.ChiTietHoaDonDataTable();
                baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter cthd1 = new baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter();
                cthd.Reset();
                string smahd = dataGridViewbh[0, dataGridViewct.CurrentRow.Index].Value.ToString();
                string smasp = dataGridViewbh[5, dataGridViewct.CurrentRow.Index].Value.ToString();
                cthd1.Xoacthd(cthd, smahd, smasp);
                hienthidonhang();
                MessageBox.Show("Bạn đã xóa thành công");
            }
        }

        private void textTongtien_Click(object sender, EventArgs e)
        {
            baocaonhom5.ChiTietNhapNVLDataTable ctn = new baocaonhom5.ChiTietNhapNVLDataTable();
            baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctn1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
            ctn.Reset();
            string mp = txtmpnvl.Text;
            ctn1.tongtien(ctn, mp);
        }

        private void bt_Click(object sender, EventArgs e)
        {
            {
                baocaonhom5.ChiTietNhapNVLDataTable ctn = new baocaonhom5.ChiTietNhapNVLDataTable();
                baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter ctn1 = new baocaonhom5TableAdapters.ChiTietNhapNVLTableAdapter();
                ctn.Reset();
                string mp = txtmpnvl.Text;
                ctn1.tongtien(ctn, mp);

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.HoaDonDataTable hd = new baocaonhom5.HoaDonDataTable();
                baocaonhom5TableAdapters.HoaDonTableAdapter hd1 = new baocaonhom5TableAdapters.HoaDonTableAdapter();
                hd.Reset();

                hd1.suahd(hd, txtMahdct.Text, dtNgayban.Value, txtGhichu.Text, Convert.ToInt32(txtTongtien.Text), Convert.ToInt32(txtChietkhau.Text), txtManv.Text, txtMakh.Text);
                hienthihoadon();

                txtMahdct.Clear();
                txtGhichu.Clear();
                txtChietkhau.Clear();
                txtManv.Clear();
                txtMakh.Clear();
                txtTongtien.Clear();
                MessageBox.Show("Bạn đã sửa thành công");
            }
        }
        private void button32_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NhapNVLDataTable nhap = new baocaonhom5.NhapNVLDataTable();
                baocaonhom5TableAdapters.NhapNVLTableAdapter nhap1 = new baocaonhom5TableAdapters.NhapNVLTableAdapter();
                nhap.Reset();

                nhap1.themnnvl(nhap, dtNgaynhap.Value, Convert.ToInt32(textTongtien.Text), Convert.ToInt32(txtTt.Text), Convert.ToInt32(txtCongno.Text), txtQlmanv.Text);
                hienthinvl();
                txtMp.Clear();
                //Ngaynhap.Clear();
                textTongtien.Clear();
                txtTt.Clear();
                txtCongno.Clear();
                txtQlmanv.Clear();
                txtQlmanv.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.ChiTietHoaDonDataTable cthd = new baocaonhom5.ChiTietHoaDonDataTable();
                baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter cthd1 = new baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter();
                cthd.Reset();
                cthd1.Themcthd(cthd, txtMahd.Text, txtTensp.Text, Convert.ToInt32(txtSoluong.Text), Convert.ToInt32(txtDongia.Text), Convert.ToInt32(txtThanhtien.Text), txtMasphd.Text);
                hienthidonhang();
                txtMahd.Clear();
                txtTensp.Clear();
                txtSoluong.Clear();
                txtDongia.Clear();
                txtThanhtien.Clear();
                txtMasphd.Clear();
                txtMasphd.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                      "warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtMp.Clear();
                txtQlmanv.Clear();
                textTongtien.Clear();
                txtCongno.Clear();
                txtTt.Clear();
                txtMp.Enabled = true;
                txtQlmanv.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mahd = dataGridViewbh[0, dataGridViewbh.CurrentRow.Index].Value.ToString();
                baocaonhom5.ChiTietHoaDonDataTable cthd = new baocaonhom5.ChiTietHoaDonDataTable();
                baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter cthd1 = new baocaonhom5TableAdapters.ChiTietHoaDonTableAdapter();
                cthd.Reset();
                cthd1.Suacthd(cthd, mahd, txtTensp.Text, Convert.ToInt32(txtSoluong.Text), Convert.ToInt32(txtDongia.Text), Convert.ToInt32(txtThanhtien.Text), txtMasphd.Text);
                hienthidonhang();
                MessageBox.Show("Bạn đã sửa thành công");
            }
        }

        private void btThanhtiendh_Click(object sender, EventArgs e)
        {
            string sSoluong = txtSoluong.Text;
            decimal dSoluong = Convert.ToDecimal(sSoluong);
            string sDongia = txtDongia.Text;
            decimal dDongia = Convert.ToDecimal(sDongia);
            decimal dThanhtien = dSoluong * dDongia;
            txtThanhtien.Text = dThanhtien.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?",
                                                       "warning",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baocaonhom5.NhapNVLDataTable nhap = new baocaonhom5.NhapNVLDataTable();
                baocaonhom5TableAdapters.NhapNVLTableAdapter nhap1 = new baocaonhom5TableAdapters.NhapNVLTableAdapter();
                nhap.Reset();

                nhap1.suannvl(nhap, txtMp.Text, dtNgaynhap.Value, Convert.ToInt32(textTongtien.Text), Convert.ToInt32(txtTt.Text), Convert.ToInt32(txtCongno.Text), txtQlmanv.Text);
                hienthinvl();

                txtMp.Clear();

                textTongtien.Clear();
                txtTt.Clear();
                txtCongno.Clear();
                txtQlmanv.Clear();
                txtQlmanv.Focus();
                MessageBox.Show("Bạn đã thêm thành công");
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtMahdct.Clear();
 
                txtChietkhau.Clear();
                txtGhichu.Clear();
                txtMakh.Clear();
                txtManv.Clear();
                txtTongtien.Clear();
                txtMahdct.Enabled = true;
                txtTongtien.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không?",
                                                     "warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtMahd.Clear();
                txtTensp.Clear();
                txtSoluong.Clear();
                txtMasphd.Clear();
               
                txtDongia.Clear();
                txtThanhtien.Clear();
                txtMahdct.Enabled = true;
                txtTongtien.Focus();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}















