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
    public partial class FrmCongthuc : Form
    {
        public FrmCongthuc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void FrmCongthuc_Load(object sender, EventArgs e)
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

        private void dataGridViewct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Lấy database khi bấm Sửa
            string sMact = txttkmct.Text;
            string sMasp = txtMasp.Text;
            string sManvl = txtManvl.Text;
            string sLuongnvl = label10.Text;
            string sDonvitinh = label11.Text;
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
      

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCongthuc_FormClosing(object sender, FormClosingEventArgs e)
        {

           
        }

        private void FrmCongthuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain Main = new FrmMain();
            Main.Show();
        }
    }
}
