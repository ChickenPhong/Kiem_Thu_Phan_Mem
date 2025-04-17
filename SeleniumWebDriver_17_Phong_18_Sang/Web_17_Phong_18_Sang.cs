using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver_17_Phong_18_Sang
{
    public partial class Web_17_Phong_18_Sang: Form
    {
        public Web_17_Phong_18_Sang()
        {
            InitializeComponent();
        }

        private void btnDangNhap_17_Phong_18_Sang_Click(object sender, EventArgs e)
        {

            //Thử chức năng “Đăng nhập”
            ChromeDriverService chrome_17_Phong_18_Sang = ChromeDriverService.CreateDefaultService();
            chrome_17_Phong_18_Sang.HideCommandPromptWindow = true;

            IWebDriver driver_17_Phong_18_Sang = new ChromeDriver(chrome_17_Phong_18_Sang);
            driver_17_Phong_18_Sang.Navigate().GoToUrl("https://automationexercise.com/");

            IWebElement loginLink_17_Phong_18_sang = driver_17_Phong_18_Sang.FindElement(By.XPath("//a[@href='/login']"));
            loginLink_17_Phong_18_sang.Click();

            IWebElement e_Email_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.Name("email"));
            e_Email_17_Phong_18_Sang.SendKeys(txtEmail_17_Phong_18_Sang.Text);

            IWebElement e_Password_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.Name("password"));
            e_Password_17_Phong_18_Sang.SendKeys(txtPass_17_Phong_18_Sang.Text);

            IWebElement e_LoginButton_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.XPath("//button[@type='submit']"));
            e_LoginButton_17_Phong_18_Sang.Click();
        }

        private void btn_DangNhapCoSan_17_Phong_18_Sang_Click(object sender, EventArgs e)
        {
            // Thử chức năng “Đăng nhập” có sẵn
            string email_17_Phong_18_sang = "tqphong2004@gmail.com";
            string password_17_Phong_18_sang = "@Phong2k4@";

            ChromeDriverService chrome_17_Phong_18_Sang = ChromeDriverService.CreateDefaultService();
            chrome_17_Phong_18_Sang.HideCommandPromptWindow = true;

            IWebDriver driver_17_Phong_18_Sang = new ChromeDriver(chrome_17_Phong_18_Sang);
            driver_17_Phong_18_Sang.Navigate().GoToUrl("https://automationexercise.com/");

            IWebElement loginLink_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.XPath("//a[@href='/login']"));
            loginLink_17_Phong_18_Sang.Click();

            IWebElement e_Email_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.Name("email"));
            e_Email_17_Phong_18_Sang.SendKeys(email_17_Phong_18_sang);

            IWebElement e_Password_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.Name("password"));
            e_Password_17_Phong_18_Sang.SendKeys(password_17_Phong_18_sang);

            IWebElement e_LoginButton_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.XPath("//button[@type='submit']"));
            e_LoginButton_17_Phong_18_Sang.Click();
        }

        private void btnTimKiem_17_Phong_18_Sang_Click(object sender, EventArgs e)
        {
            //Thử chức năng "tìm kiếm sản phẩm" 
            ChromeDriverService chrome_17_Phong_18_Sang = ChromeDriverService.CreateDefaultService();
            chrome_17_Phong_18_Sang.HideCommandPromptWindow = true;

            IWebDriver driver_17_Phong_18_Sang = new ChromeDriver(chrome_17_Phong_18_Sang);
            driver_17_Phong_18_Sang.Navigate().GoToUrl("https://automationexercise.com/");

            IWebElement productsLink_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.XPath("//a[@href='/products']"));
            productsLink_17_Phong_18_Sang.Click();

            IWebElement searchBox_17_Phong_18_sang = driver_17_Phong_18_Sang.FindElement(By.Id("search_product"));
            searchBox_17_Phong_18_sang.SendKeys(txtTimKiem_17_Phong_18_Sang.Text);

            IWebElement searchButton_17_Phong_18_Sang = driver_17_Phong_18_Sang.FindElement(By.Id("submit_search"));
            searchButton_17_Phong_18_Sang.Click();

        }
    }
}
