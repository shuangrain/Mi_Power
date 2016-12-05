using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
//設定IE版本用參考
using Microsoft.Win32;
using System.Diagnostics;

namespace U101B117HW1_Add_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //設定IE11用語法
            var appName = Process.GetCurrentProcess().MainModule.ModuleName;
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", appName, 11001, RegistryValueKind.DWord);

            InitializeComponent();
        }

        //====全域宣告====\\

        string temp = "";
        bool check_buy = false;
        //成功數量
        int Ok = 0;
        bool check = false;
        //====全域宣告====\\

        private void Form1_Load(object sender, EventArgs e)
        {
            status("初始化...");
            webBrowser1.Navigate("http://shuang.myftp.org/Mi/Mi_mobile.htm");
            status("載入登入頁面...");
            loading();
            status("載入完成！");
        }

        //利用listbox當狀態欄，隨時顯示目前狀況，並且維持在最下方，項目超過十五行清空
        public void status(string str)
        {
            listBox1.Items.Add(str);
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            if (listBox1.Items.Count > 15)
            {
                listBox1.Items.Clear();
            }
        }

        //等待網頁讀取完成
        public void loading()
        {
            while (!(webBrowser1.ReadyState == WebBrowserReadyState.Complete))
            {
                Application.DoEvents();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://shuang.myftp.org/Mi/Mi_mobile.htm");
            status("載入登入頁面...");
            loading();
            status("載入完成！");
            status("登入中...");
            HtmlElement auto_ID = webBrowser1.Document.All["username"];
            HtmlElement auto_Pwd = webBrowser1.Document.All["userPwd"];
            auto_ID.SetAttribute("value", textID.Text);
            auto_Pwd.SetAttribute("value", textPwd.Text);
            auto_Pwd.Focus();
            SendKeys.Send("{enter}");
            loading();
            status("登入成功！");
        }

        private void btnBuyPower_Click(object sender, EventArgs e)
        {
            try
            {
                check = true;
                //讀取驗證碼\\
                //讀取驗證碼\\
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://buy.mi.com/tw/misc/showCode");
                //设置cookie，一般情况下在获取验证码图片前都会先进行获取cookie，然后在这里设置，以保证cookie相同，请求相同。这样才能保证验证码是一致的
                request.CookieContainer = new CookieContainer();
                webBrowser1.Navigate("http://buy.mi.com/tw/misc/showCode");
                loading();
                status("請輸入驗證碼...");
                TimerCheck.Enabled = true;
            }
            catch (Exception ex)
            {
                status(ex.Message);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            Delay.Enabled = false;
            TimerCheck.Enabled = false;
            check = true;
            status("已停止！");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            check = false;
            while (check == false)
            {
                if (temp.Contains("小米帳號"))
                {
                    status("登入...");
                    webBrowser1.Navigate("http://buy.mi.com/tw/site/login");
                    loading();
                    status("重新載入...");
                    webBrowser1.Navigate("http://www.mi.com/tw/dianyuan10400/");
                    loading();
                }
                else if (temp.Contains("暫時缺貨"))
                {
                    status("沒有庫存...");
                    webBrowser1.Navigate("http://www.mi.com/tw/dianyuan10400/");
                    loading();
                    status("載入完成！");
                }
                else if (temp.Contains("立即購買"))
                {
                    check = true;
                    status("可購買...");
                    webBrowser1.Navigate("http://buy.mi.com/tw/cart/add/2130100011");
                    loading();
                    status("請輸入驗證碼...");
                    TimerCheck.Enabled = true;
                }
            }
        }

        //自動購買程序
        public void buy()
        {
            status("載入購物車中...");
            webBrowser1.Navigate("http://buy.mi.com/tw/buy/checkout");
            loading();
            status("載入完成！");
            if (temp.Contains("購物車不能為空"))
            {
                TimerCheck.Enabled = false;
                status("購物車不能為空...");
                btnCheck.PerformClick();
                status("載入完成！");
            }
            else
            {
                try
                {
                    HtmlElement web_textName = this.webBrowser1.Document.GetElementById("UserAddressName");
                    HtmlElement web_textAddressCity = this.webBrowser1.Document.All["UserAddressCity"];
                    HtmlElement web_textAddressDistrict = this.webBrowser1.Document.All["Checkout[district]"];
                    HtmlElement web_textAddressDetail = this.webBrowser1.Document.GetElementById("UserAddressDetail");
                    HtmlElement web_txtzipcode = this.webBrowser1.Document.GetElementById("zipcode");
                    HtmlElement web_textAddressTel = this.webBrowser1.Document.GetElementById("UserAddressTel");
                    HtmlElement web_btnSend = this.webBrowser1.Document.GetElementById("checkoutFormBtn");
                    web_textName.SetAttribute("value", textName.Text);
                    status("[名稱]輸入完成！");
                    web_textAddressDetail.SetAttribute("value", textAddress.Text);
                    status("[地址]輸入完成！");
                    web_txtzipcode.SetAttribute("value", textZip.Text);
                    status("[郵遞區號]輸入完成！");
                    web_textAddressTel.SetAttribute("value", textPhone.Text);
                    status("[聯絡電話]輸入完成！");
                    web_textAddressCity.Focus();
                    web_textAddressCity.SetAttribute("value", textCounty.Text);
                    status("[縣]選擇完成！");
                    web_textAddressDistrict.SetAttribute("value", textCity.Text);
                    web_btnSend.InvokeMember("click");
                    loading();
                    Delay.Enabled = true;
                }
                catch (Exception ex)
                {
                    status(ex.Message);
                }
            }
        }

        //選擇[市]
        public void checkEnd()
        {
            HtmlElement btnSend = this.webBrowser1.Document.GetElementById("checkoutFormBtn");
            btnSend.InvokeMember("click");
            loading();
            status("搜尋狀態...");
            Delay.Enabled = true;
        }

        //伺服器流量過大卡住時手動結帳按鈕
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            status("重新結帳...");
            btnCheck.Enabled = true;
            buy();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            txtDate.Text = Convert.ToString(DateTime.Now);
        }

        //當頁面重整時獲取頁面資料
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            temp = webBrowser1.DocumentText;
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            if (check_buy == false)
            {
                if (temp.Contains("請選擇正確的地址"))
                {
                    Delay.Enabled = false;
                    status("搜尋到關鍵字..");
                    HtmlElement textName = this.webBrowser1.Document.GetElementById("UserAddressName");
                    HtmlElement textAddressDistrict = this.webBrowser1.Document.All["Checkout[district]"];
                    textAddressDistrict.SetAttribute("value", textCity.Text);
                    status("[市]選擇完成！");
                    //防止在次購買時跳入此段程式
                    check_buy = true;
                    checkEnd();
                }
            }
            if (webBrowser1.DocumentTitle.Contains("選擇支付方式"))
            {
                check_buy = false;
                status("購買成功！");
                Ok++;
                txtOk.Text = "成功：" + Ok + " 個";
                btnCheck.Enabled = true;
                btnCheck.PerformClick();
                status("在次購買！");
            }
        }

        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            if (webBrowser1.Url.ToString() == "http://buy.mi.com/tw/cart")
            {
                TimerCheck.Enabled = false;
                status("購買成功！");
                //設定數量
                loading();
                HtmlElement web_number = this.webBrowser1.Document.GetElementById("Cart[2130100011_0_buy]");
                web_number.SetAttribute("value", "2");
                status("[數量]輸入完成！");
                buy();
            }
            else if (temp.Contains("超出購買限制"))
            {
                TimerCheck.Enabled = false;
                status("超出購買限制...");
                buy();
            }
            else if (temp.Contains("超過單品的最大購買數量"))
            {
                TimerCheck.Enabled = false;
                status("購物車已有...");
                buy();
            }
            else if (temp.Contains("商品沒有庫存了"))
            {
                status("重新載入...");
                btnSend.PerformClick();
                loading();
                status("載入完成！");
            }
            else if (temp.Contains("該商品已缺貨"))
            {
                status("重新載入...");
                btnSend.PerformClick();
                loading();
                status("載入完成！");
            }
            else if (temp.Contains("參數user_id不能為空"))
            {
                status("重新載入...");
                btnSend.PerformClick();
                loading();
                status("載入完成！");
            }
            else if (webBrowser1.Url.ToString() == "http://buy.mi.com/tw/misc/verifyCode/id/2130100011")
            {
                TimerCheck.Enabled = false;
                status("請您輸入驗證碼...");
                btnBuyPower.PerformClick();
                loading();
            }
            else if (temp.Contains("系统繁忙"))
            {
                status("重新載入...");
                btnSend.PerformClick();
                loading();
                status("載入完成！");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string Code = textCode.Text;
            string strUrl = @"http://course.hk.edu.tw/hktea/HK_Y01/Y01_Main_Stu.aspx";
            byte[] SomeBytes = null;
            string FormParams = "verifyCode=" + textCode.Text;
            SomeBytes = Encoding.UTF8.GetBytes(FormParams);
            string AdditionalHeaders = "Content-Type: application/x-www-form-urlencoded" + Environment.NewLine;
            webBrowser1.Navigate(strUrl, null, SomeBytes, AdditionalHeaders);
            loading();
            webBrowser1.Navigate("http://buy.mi.com/tw/cart/add/2130100011");
            loading();
        }

    }
}
