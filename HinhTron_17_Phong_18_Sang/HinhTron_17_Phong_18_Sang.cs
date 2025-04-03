using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron_17_Phong_18_Sang
{
    public class HinhTron_17_Phong_18_Sang
    {
        public static double TinhChuVi_17_Phong_18_Sang(double banKinh_17_Phong_18_Sang)
        {
            return 2 * Math.PI * banKinh_17_Phong_18_Sang;
        }

        public static double TinhChuViTuDuongKinh_17_Phong_18_Sang(double duongKinh_17_Phong_18_Sang)
        {
            return Math.PI * duongKinh_17_Phong_18_Sang;
        }

        public static double TinhDienTich_17_Phong_18_Sang(double banKinh_17_Phong_18_Sang)
        {
            return Math.PI * banKinh_17_Phong_18_Sang * banKinh_17_Phong_18_Sang;
        }

        public static double TinhDienTichTuDuongKinh_17_Phong_18_Sang(double duongKinh_17_Phong_18_Sang)
        {
            return Math.PI * Math.Pow(duongKinh_17_Phong_18_Sang / 2, 2);
        }
    }
}
