using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System;
using System.Collections.Generic;

namespace WebTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VideoTest()
        {
            var browser = Application.Launch($"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            Thread.Sleep(500);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            if (browser == null)
            {
                throw new System.Exception("Chrome browser not opened");
            }

            var mainWindow = new UIA3Automation().GetDesktop(); 
            var chromeWindow = mainWindow.FindFirstChild(cf.ByClassName("Chrome_WidgetWin_1"));
            Thread.Sleep(300);
            chromeWindow.AsWindow().Click();

            var search = mainWindow.FindFirstDescendant(cf.ByName("Address and search bar")); 
            if(search.IsEnabled)
            {
                search.AsTextBox().Text = "https://bufferzonesecurity.com/";               
                Keyboard.Press(VirtualKeyShort.ENTER);
                Thread.Sleep(4000);
                var bufferzoneWeb = mainWindow.FindFirstDescendant(cf.ByName("Ransomware, Zero-days & Phishing Scams Protection - BUFFERZONE"));
                if (bufferzoneWeb == null)
                {
                    throw new System.Exception("Website loading did not succeed");
                }
                var watchVideolink = chromeWindow.FindFirstDescendant(cf.ByAutomationId("playVideo"));
                watchVideolink.Click();
                Thread.Sleep(1000);

                var videoWindow = chromeWindow.FindFirstDescendant(cf.ByName("Step into the BUFFERZONE from BUFFERZONE Security on Vimeo"));
                if(videoWindow == null)
                {
                    throw new System.Exception("Explanation video is not working");
                }
                var closeVideo = chromeWindow.FindFirstDescendant(cf.ByAutomationId("closeX"));
                closeVideo.Click();
            }
        }
        [TestMethod]
        public void DemoRequestTest()
        {
            var browser = Application.Launch($"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            Thread.Sleep(500);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            if (browser == null)
            {
                throw new System.Exception("Chrome browser not opened");
            }

            var mainWindow = new UIA3Automation().GetDesktop();
            var chromeWindow = mainWindow.FindFirstChild(cf.ByClassName("Chrome_WidgetWin_1"));
            Thread.Sleep(300);

            chromeWindow.AsWindow().Click();

            var search = mainWindow.FindFirstDescendant(cf.ByName("Address and search bar"));
            if (search.IsEnabled)
            {
                search.AsTextBox().Text = "https://bufferzonesecurity.com/";
                Keyboard.Press(VirtualKeyShort.ENTER);
                Thread.Sleep(4000);

                var bufferzoneWeb = mainWindow.FindFirstDescendant(cf.ByName("Ransomware, Zero-days & Phishing Scams Protection - BUFFERZONE"));
                if (bufferzoneWeb == null)
                {
                    throw new System.Exception("Website loading did not succeed");
                }

                var request = chromeWindow.FindFirstDescendant(cf.ByAutomationId("tryNow"));
                request.Click();
                var demoForm = chromeWindow.FindFirstDescendant(cf.ByAutomationId("demoForm"));
                if (demoForm == null)
                {
                    throw new System.Exception("Demo form is not opened");
                }
                else
                {
                    List<AutomationElement> fields = new List<AutomationElement>();
                    var firstName = demoForm.FindFirstChild(cf.ByName("First Name"));
                    fields.Add(firstName);
                    var lasttName = demoForm.FindFirstChild(cf.ByName("Last Name"));
                    fields.Add(lasttName);
                    var company = demoForm.FindFirstChild(cf.ByName("Company"));
                    fields.Add(company);
                    var companySize = demoForm.FindFirstDescendant(cf.ByName("Company Size"));
                    fields.Add(companySize);
                    var companyEmail = demoForm.FindFirstChild(cf.ByName("Company Email"));
                    fields.Add(companyEmail);
                    var phone = demoForm.FindFirstChild(cf.ByName("Phone"));
                    fields.Add(phone);
                    var comment = demoForm.FindFirstChild(cf.ByName("Comment"));
                    fields.Add(comment);
                    var sendForm = demoForm.FindFirstChild(cf.ByName("Send"));
                    fields.Add(sendForm);
                    foreach (var element in fields)
                    {
                        if (element == null)
                        {
                            throw new System.Exception("One of the fields need to be fixed");
                        }
                    }
                    Thread.Sleep(1000);
                    var close = chromeWindow.FindFirstDescendant(cf.ByAutomationId("closeX"));
                    close.Click();
                }
            }
        }
        [TestMethod]
        public void DownloadFile()
        {
            var browser = Application.Launch($"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            Thread.Sleep(500);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            if (browser == null)
            {
                throw new System.Exception("Chrome browser not opened");
            }

            var mainWindow = new UIA3Automation().GetDesktop();
            var chromeWindow = mainWindow.FindFirstChild(cf.ByClassName("Chrome_WidgetWin_1"));
            Thread.Sleep(300);

            chromeWindow.AsWindow().Click();

            var search = mainWindow.FindFirstDescendant(cf.ByName("Address and search bar"));
            if (search.IsEnabled)
            {
                search.AsTextBox().Text = "https://bufferzonesecurity.com/";
                Keyboard.Press(VirtualKeyShort.ENTER);
                Thread.Sleep(4000);

                var bufferzoneWeb = mainWindow.FindFirstDescendant(cf.ByName("Ransomware, Zero-days & Phishing Scams Protection - BUFFERZONE"));
                if (bufferzoneWeb == null)
                {
                    throw new System.Exception("Website loading did not succeed");
                }

                var product = chromeWindow.FindFirstDescendant(cf.ByName("PRODUCT"));

                if (product != null)
                {
                    product.Click();
                    Thread.Sleep(3000);
                }
                var currentPage = chromeWindow.FindFirstChild(cf.ByClassName("Chrome_RenderWidgetHostHWND"));
                var downloadFile = currentPage.FindFirstDescendant(cf.ByName("DOWNLOAD WHITE PAPER"));
                downloadFile.Click();
                Thread.Sleep(1000);

                var downloadPaper = chromeWindow.FindFirstDescendant(cf.ByName("Download Whitepaper"));


                var firstName = downloadPaper.FindFirstChild(cf.ByName("First Name"));
                Thread.Sleep(1000);
                firstName.AsTextBox().Enter("Israel");
                var lasttName = downloadPaper.FindFirstChild(cf.ByName("Last Name"));
                Thread.Sleep(1000);
                lasttName.AsTextBox().Enter("israeli");
                var company = downloadPaper.FindFirstChild(cf.ByName("Company"));
                Thread.Sleep(1000);
                company.AsTextBox().Enter("BufferZone");
                var companyEmail = downloadPaper.FindFirstChild(cf.ByName("Company Email"));
                Thread.Sleep(1000);
                companyEmail.AsTextBox().Enter("BufferZone@gmail.com");               
                var phone = downloadPaper.FindFirstChild(cf.ByName("Phone"));
                Thread.Sleep(1000);
                phone.AsTextBox().Enter("972 506035050");
                var comment = downloadPaper.FindFirstChild(cf.ByName("Comment"));
                Thread.Sleep(1000);
                comment.AsTextBox().Enter("Interesting product. I would appreciate it if you could contact me as soon as possible.");
                var country = downloadPaper.FindFirstDescendant(cf.ByName("Select Country"));
                country.Click();
                //-----fill country by hand-----//
                Thread.Sleep(5000);
                var sendBtn = downloadPaper.FindFirstChild(cf.ByName("Send"));
                sendBtn.Click();

                var thankYou = chromeWindow.FindFirstDescendant(cf.ByName("Thank You - BUFFERZONE"));
                if(thankYou == null)
                {
                    throw new System.Exception("Download bufferzone whitepaper did not succeed");
                }
            }
        }
    }
}
