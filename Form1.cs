using aes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnMahoa_Click(object sender, EventArgs e)
        {
            long millisecondsStart = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            String key = txtKey.Text;
            if (key.Length != 16)
            {
                MessageBox.Show("phai nhap key = 16 ky tu");
                return;
            }
            Aes128Ctr aes = new Aes128Ctr(key,128);
            String ketqua = aes.Encrypt(txtPlainText.Text);
            long millisecondsEnd = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            MessageBox.Show($"Mã hóa thành công, thời gian mã hóa: {millisecondsEnd - millisecondsStart}(ms)");
            txtcypher.Text = ketqua;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                long millisecondsStart = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                String key = txtKey.Text;
                if (key.Length != 16 || txtcypher.Text.Length == 0)
                {
                    MessageBox.Show("phai nhap key = 16 ky tu");
                    return;
                }
                Aes128Ctr aes = new Aes128Ctr(key, 128);
                String ketqua = aes.Decrypt(txtcypher.Text);
                long millisecondsEnd = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                MessageBox.Show($"Kết quả giải mã: {ketqua}, thời gian giải mã: {millisecondsEnd-millisecondsStart}(ms)");
            }
            catch (Exception err)
            {

                MessageBox.Show("Giải Mã Thất Bại Vui lòng Xem lại dữ liệu đầu vào");
            }
            
          
        }

        private void txtcypher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
