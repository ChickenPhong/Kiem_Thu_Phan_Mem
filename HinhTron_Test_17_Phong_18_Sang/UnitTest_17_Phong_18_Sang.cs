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
        //public void TC01_Pass_ChuVi_BanKinh()
        //{
        //    double expected = 2 * Math.PI * 2;
        //    double actual = HinhTron.TinhChuVi_17_Phong_18_Sang(2);
        //    Assert.AreEqual(expected, actual, 0.001);
        //}

        //// TC02: Nhập đường kính = 3, kết quả mong muốn Chu vi = 9.424 (PASS)
        //[TestMethod]
        //public void TC02_Pass_ChuVi_DuongKinh()
        //{
        //    double expected = Math.PI * 3;
        //    double actual = HinhTron.TinhChuViTuDuongKinh_17_Phong_18_Sang(3);
        //    Assert.AreEqual(expected, actual, 0.001);
        //}

        //// TC03: Nhập bán kính = 1, kết quả mong muốn Diện tích = 3.142 (PASS)
        //[TestMethod]
        //public void TC03_Pass_DienTich_BanKinh()
        //{
        //    double expected = Math.PI;
        //    double actual = HinhTron.TinhDienTich_17_Phong_18_Sang(1);
        //    Assert.AreEqual(expected, actual, 0.001);
        //}

        //// TC04: Nhập đường kính = 4, kết quả mong muốn Diện tích = 12.566 (PASS)
        //[TestMethod]
        //public void TC04_Pass_DienTich_DuongKinh()
        //{
        //    // (d/2)^2 * π
        //    double expected = Math.PI * Math.Pow(4.0 / 2, 2);
        //    double actual = HinhTron.TinhDienTichTuDuongKinh_17_Phong_18_Sang(4);
        //    Assert.AreEqual(expected, actual, 0.001);
        //}

        //// TC05: Nhập bán kính = 2, kết quả mong muốn Chu vi = 12.566 (FAIL)
        //[TestMethod]
        //public void TC05_Fail_ChuVi_BanKinh()
        //{
        //    double expected = 10.0;
        //    double actual = HinhTron.TinhChuVi_17_Phong_18_Sang(2);
        //    Assert.AreEqual(expected, actual, 0.001);
        //}

        //// TC06: Nhập bán kính = 2, kết quả mong muốn Diện tích = 28.274 (FAIL)
        //[TestMethod]
        //public void TC06_Fail_DienTich_BanKinh()
        //{
        //    double expected = 10.0; // sai cố tình
        //    double actual = HinhTron.TinhDienTich_17_Phong_18_Sang(2);
        //    Assert.AreEqual(expected, actual, 0.001);
        //}

        public TestContext TestContext { get; set; }

        // Đọc file csv để test
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_17_Phong_18_Sang\TestData_17_Phong_18_Sang.csv", "TestData_17_Phong_18_Sang#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC07_TestWithDataSource_17_Phong_18_Sang()
        {
            // Lấy dữ liệu từ từng cột trong dòng
            int giatri = int.Parse(TestContext.DataRow[0].ToString());
            // loại: 'cv' hoặc 'dt'
            string loai = TestContext.DataRow[1].ToString();
            loai = loai.Substring(1);
            double expected = Math.Round(double.Parse(TestContext.DataRow[2].ToString()), 2);

            double actual;

            if (loai == "cv")
            {
                // làm tròn giống file
                actual = Math.Round(HinhTron.TinhChuVi_17_Phong_18_Sang(giatri), 2); 
            }
            else
            {
                actual = Math.Round(HinhTron.TinhDienTich_17_Phong_18_Sang(giatri), 2);
            }

            Assert.AreEqual(expected, actual, 0.01);
        }

        // đọc file xlsx để test
        [DataSource(
    "System.Data.OleDb",
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Data_17_Phong_18_Sang\\DataExcel_17_Phong_18_Sang.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'",
    "Sheet1$",DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC08_TestWithExcelDataSource_17_Phong_18_Sang()
        {
            int giatri = int.Parse(TestContext.DataRow["giatri"].ToString());
            string loai = TestContext.DataRow["loai"].ToString().Trim();
            double expected = Math.Round(double.Parse(TestContext.DataRow["expected"].ToString()), 2);

            double actual;
            if (loai == "cv")
            {
                actual = Math.Round(HinhTron.TinhChuVi_17_Phong_18_Sang(giatri), 2);
            }
            else 
            {

                actual = Math.Round(HinhTron.TinhDienTich_17_Phong_18_Sang(giatri), 2);
            }

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
