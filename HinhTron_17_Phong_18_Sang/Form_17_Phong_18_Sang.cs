using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HinhTron_17_Phong_18_Sang
{
    public partial class Form_17_Phong_18_Sang: Form
    {
        public Form_17_Phong_18_Sang()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            // Kiểm tra ô nhập có trống không
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double input_17_Phong_18_Sang;
            // Kiểm tra xem có phải số không
            if (!double.TryParse(txtInput.Text, out input_17_Phong_18_Sang) || input_17_Phong_18_Sang <= 0)
            {
                MessageBox.Show("Giá trị phải là một số dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra người dùng đã chọn đầy đủ chưa
            if (!rdChuVi.Checked && !rdDienTich.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại cần tính (Chu vi hoặc Diện tích)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdBanKinh.Checked && !rdDuongKinh.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại giá trị nhập (Bán kính hoặc Đường kính)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bắt đầu tính
            double res_17_Phong_18_Sang = 0;

            // Nếu chọn tính chu vi
            if (rdChuVi.Checked)
            {
                // bán kính
                if (rdBanKinh.Checked)
                {
                    res_17_Phong_18_Sang = HinhTron_17_Phong_18_Sang.TinhChuVi_17_Phong_18_Sang(input_17_Phong_18_Sang);
                }
                // đường kính
                else
                {
                    res_17_Phong_18_Sang = HinhTron_17_Phong_18_Sang.TinhChuViTuDuongKinh_17_Phong_18_Sang(input_17_Phong_18_Sang);
                }
            }
            // Tính diện tích
            if (rdDienTich.Checked)
            {
                // bán kính
                if (rdBanKinh.Checked)
                {
                    res_17_Phong_18_Sang = HinhTron_17_Phong_18_Sang.TinhDienTich_17_Phong_18_Sang(input_17_Phong_18_Sang);
                }
                // đường kính
                else
                {
                    res_17_Phong_18_Sang = HinhTron_17_Phong_18_Sang.TinhDienTichTuDuongKinh_17_Phong_18_Sang(input_17_Phong_18_Sang);
                }
            }
            // làm tròn hiển thị đẹp hơn
            txtKetQua.Text = res_17_Phong_18_Sang.ToString("0.00");
        }
    }
}
