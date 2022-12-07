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
using System.Threading;
using System.Drawing.Text;

namespace Giaodienbanhang
{
    public partial class FrmMain : Form
    {
       
    
        public FrmMain()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btkh_Click(object sender, EventArgs e)
        {
            FrmSanpham kh = new FrmSanpham();
            kh.Show();


        }

                
               
          
           


        

        private void btCongthuc_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btKh_Click_1(object sender, EventArgs e)
        {
         
           

        }

        private void btCt_Click(object sender, EventArgs e)
        {
           
          

        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {
          
           

        }

        private void btBh_Click(object sender, EventArgs e)
        {
          
            

        }

        private void btNhapnvl_Click(object sender, EventArgs e)
        {
           

        }
    }
}
