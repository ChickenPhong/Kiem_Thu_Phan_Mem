using System;
using HinhTron = HinhTron_17_Phong_18_Sang.HinhTron_17_Phong_18_Sang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HinhTron_Test_17_Phong_18_Sang
{
    [TestClass]
    public class UnitTest_17_Phong_18_Sang
    {
        // TC01: Nhập bán kính = 2, kết quả mong muốn Chu vi = 12.566 (PASS)
        [TestMethod]
        public void TC01_Pass_ChuVi_BanKinh()
        {
            double expected = 2 * Math.PI * 2;
            double actual = HinhTron.TinhChuVi_17_Phong_18_Sang(2);
            Assert.AreEqual(expected, actual, 0.001);
        }

        // TC02: Nhập đường kính = 3, kết quả mong muốn Chu vi = 9.424 (PASS)
        [TestMethod]
        public void TC02_Pass_ChuVi_DuongKinh()
        {
            double expected = Math.PI * 3;
            double actual = HinhTron.TinhChuViTuDuongKinh_17_Phong_18_Sang(3);
            Assert.AreEqual(expected, actual, 0.001);
        }

        // TC03: Nhập bán kính = 1, kết quả mong muốn Diện tích = 3.142 (PASS)
        [TestMethod]
        public void TC03_Pass_DienTich_BanKinh()
        {
            double expected = Math.PI;
            double actual = HinhTron.TinhDienTich_17_Phong_18_Sang(1);
            Assert.AreEqual(expected, actual, 0.001);
        }

        // TC04: Nhập đường kính = 4, kết quả mong muốn Diện tích = 12.566 (PASS)
        [TestMethod]
        public void TC04_Pass_DienTich_DuongKinh()
        {
            // (d/2)^2 * π
            double expected = Math.PI * Math.Pow(4.0 / 2, 2); 
            double actual = HinhTron.TinhDienTichTuDuongKinh_17_Phong_18_Sang(4);
            Assert.AreEqual(expected, actual, 0.001);
        }

        // TC05: Nhập bán kính = 2, kết quả mong muốn Chu vi = 12.566 (FAIL)
        [TestMethod]
        public void TC05_Fail_ChuVi_BanKinh()
        {
            double expected = 10.0; 
            double actual = HinhTron.TinhChuVi_17_Phong_18_Sang(2);
            Assert.AreEqual(expected, actual, 0.001);
        }

        // TC06: Nhập bán kính = 2, kết quả mong muốn Diện tích = 28.274 (FAIL)
        [TestMethod]
        public void TC06_Fail_DienTich_BanKinh()
        {
            double expected = 10.0; // sai cố tình
            double actual = HinhTron.TinhDienTich_17_Phong_18_Sang(2);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
