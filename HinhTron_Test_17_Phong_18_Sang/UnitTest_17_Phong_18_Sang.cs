using System;
using HinhTron = HinhTron_17_Phong_18_Sang.HinhTron_17_Phong_18_Sang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HinhTron_Test_17_Phong_18_Sang
{
    [TestClass]
    public class UnitTest_17_Phong_18_Sang
    {
        ////4 Pass 2 Fail
        //// TC01: Nhập bán kính = 2, kết quả mong muốn Chu vi = 12.566 (PASS)
        //[TestMethod]
        //public void TC01_Pass_ChuVi_BanKinh_17_Phong_18_Sang()
        //{
        //    double ketQuaMongDoi_17_Phong_18_Sang = 12.566;
        //    double ketQuaThucTe_17_Phong_18_Sang = HinhTron.TinhChuVi_17_Phong_18_Sang(2);
        //    Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.001);
        //}

        //// TC02: Nhập đường kính = 3, kết quả mong muốn Chu vi = 9.424 (PASS)
        //[TestMethod]
        //public void TC02_Pass_ChuVi_DuongKinh_17_Phong_18_Sang()
        //{
        //    double ketQuaMongDoi_17_Phong_18_Sang = 9.424;
        //    double ketQuaThucTe_17_Phong_18_Sang = HinhTron.TinhChuViTuDuongKinh_17_Phong_18_Sang(3);
        //    Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.001);
        //}

        //// TC03: Nhập bán kính = 1, kết quả mong muốn Diện tích = 3.142 (PASS)
        //[TestMethod]
        //public void TC03_Pass_DienTich_BanKinh_17_Phong_18_Sang()
        //{
        //    double ketQuaMongDoi_17_Phong_18_Sang = 3.142;
        //    double ketQuaThucTe_17_Phong_18_Sang = HinhTron.TinhDienTich_17_Phong_18_Sang(1);
        //    Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.001);
        //}

        //// TC04: Nhập đường kính = 4, kết quả mong muốn Diện tích = 12.566 (PASS)
        //[TestMethod]
        //public void TC04_Pass_DienTich_DuongKinh_17_Phong_18_Sang()
        //{
        //    // (d/2)^2 * π
        //    double ketQuaMongDoi_17_Phong_18_Sang = 12.566;
        //    double ketQuaThucTe_17_Phong_18_Sang = HinhTron.TinhDienTichTuDuongKinh_17_Phong_18_Sang(4);
        //    Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.001);
        //}

        //// TC05: Nhập bán kính = 2, kết quả mong muốn Chu vi = 10.000 (FAIL)
        //[TestMethod]
        //public void TC05_Fail_ChuVi_BanKinh_17_Phong_18_Sang()
        //{
        //    double ketQuaMongDoi_17_Phong_18_Sang = 10.000;
        //    double ketQuaThucTe_17_Phong_18_Sang = HinhTron.TinhChuVi_17_Phong_18_Sang(2);
        //    Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.001);
        //}

        //// TC06: Nhập bán kính = 2, kết quả mong muốn Diện tích = 10.000 (FAIL)
        //[TestMethod]
        //public void TC06_Fail_DienTich_BanKinh_17_Phong_18_Sang()
        //{
        //    double ketQuaMongDoi_17_Phong_18_Sang = 10.000;
        //    double ketQuaThucTe_17_Phong_18_Sang = HinhTron.TinhDienTich_17_Phong_18_Sang(2);
        //    Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.001);
        //}

        public TestContext TestContext { get; set; }

        // Đọc file csv để test
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_17_Phong_18_Sang\TestData_17_Phong_18_Sang.csv", "TestData_17_Phong_18_Sang#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC07_TestWithDataSource_17_Phong_18_Sang()
        {

            string loai_17_Phong_18_Sang = TestContext.DataRow[0].ToString().Trim('\''); // 'bk' hoặc 'dk'
            int giaTri_17_Phong_18_sang = int.Parse(TestContext.DataRow[1].ToString());
            string tinh_17_Phong_18_Sang = TestContext.DataRow[2].ToString().Trim('\''); // 'cv' hoặc 'dt'
            double ketQuaMongDoi_17_Phong_18_Sang = Math.Round(double.Parse(TestContext.DataRow[3].ToString()), 2);

            double ketQuaThucTe_17_Phong_18_Sang = 0;

            // Xác định cách tính theo loại giá trị
            if (loai_17_Phong_18_Sang == "bk")
            {
                if (tinh_17_Phong_18_Sang == "cv")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhChuVi_17_Phong_18_Sang(giaTri_17_Phong_18_sang), 2);
                else if (tinh_17_Phong_18_Sang == "dt")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhDienTich_17_Phong_18_Sang(giaTri_17_Phong_18_sang), 2);
            }
            else if (loai_17_Phong_18_Sang == "dk")
            {
                if (tinh_17_Phong_18_Sang == "cv")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhChuViTuDuongKinh_17_Phong_18_Sang(giaTri_17_Phong_18_sang), 2);
                else if (tinh_17_Phong_18_Sang == "dt")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhDienTichTuDuongKinh_17_Phong_18_Sang(giaTri_17_Phong_18_sang), 2);
            }
            // So sánh kết quả thực tế với mong đợi, sai số cho phép là 0.01
            Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.01);
        }

        // đọc file xlsx để test
        [DataSource(
        "System.Data.OleDb",
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Data_17_Phong_18_Sang\\DataExcel_17_Phong_18_Sang.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'",
        "KiemTraHinhTron$", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC08_TestWithExcelDataSource_17_Phong_18_Sang()
        {
            // Lấy dữ liệu từ từng cột trong Excel
            string loai_17_Phong_18_Sang = TestContext.DataRow["loai_17_Phong_18_Sang"].ToString().Trim();
            int giaTri_17_Phong_18_Sang = int.Parse(TestContext.DataRow["giaTri_17_Phong_18_Sang"].ToString());
            string tinh_17_Phong_18_Sang = TestContext.DataRow["tinh_17_Phong_18_Sang"].ToString().Trim();
            double ketQuaMongDoi_17_Phong_18_Sang = Math.Round(double.Parse(TestContext.DataRow["ketQuaMongDoi_17_Phong_18_Sang"].ToString()), 2);

            double ketQuaThucTe_17_Phong_18_Sang = 0;

            if (loai_17_Phong_18_Sang == "bk")
            {
                if (tinh_17_Phong_18_Sang == "cv")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhChuVi_17_Phong_18_Sang(giaTri_17_Phong_18_Sang), 2);
                else if (tinh_17_Phong_18_Sang == "dt")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhDienTich_17_Phong_18_Sang(giaTri_17_Phong_18_Sang), 2);
            }
            else if (loai_17_Phong_18_Sang == "dk")
            {
                if (tinh_17_Phong_18_Sang == "cv")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhChuViTuDuongKinh_17_Phong_18_Sang(giaTri_17_Phong_18_Sang), 2);
                else if (tinh_17_Phong_18_Sang == "dt")
                    ketQuaThucTe_17_Phong_18_Sang = Math.Round(HinhTron.TinhDienTichTuDuongKinh_17_Phong_18_Sang(giaTri_17_Phong_18_Sang), 2);
            }
            // Kiểm tra kết quả thực tế có khớp với mong đợi không (sai số cho phép 0.01)
            Assert.AreEqual(ketQuaMongDoi_17_Phong_18_Sang, ketQuaThucTe_17_Phong_18_Sang, 0.01);
        }
    }
}
