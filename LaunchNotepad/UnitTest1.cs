using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;
using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace LaunchNotepad
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LaunchNotepadAndWriteSomething()
        {

            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = "C:\\Windows\\System32\\notepad.exe";

            String path = AppDomain.CurrentDomain.BaseDirectory;

            WiniumDriver driver = new WiniumDriver(path, options);

            driver.FindElementByClassName("Edit").SendKeys("Hello World");


        }

        [TestMethod]
        public void Test()
        {
            DesktopOptions options = new DesktopOptions();


            String path = AppDomain.CurrentDomain.BaseDirectory;

            WiniumDriver driver = new WiniumDriver(path, options);

            driver.FindElementByClassName("Edit").SendKeys("Hello World");


            options.ApplicationPath = "C:\\Program Files\\Internet Explorer\\iexplore.exe";

            WiniumDriver windriver = new WiniumDriver(path, options, TimeSpan.FromSeconds(60));
            windriver.FindElementByName("Tools").Click();
            Thread.Sleep(5000);
            windriver.FindElementByName("Internet options").Click();
            Thread.Sleep(5000);
            windriver.FindElementByName("Advanced").Click();
            Thread.Sleep(7000);
            windriver.FindElementByName("Reset...").Click();
            Thread.Sleep(7000);
            windriver.FindElementByName("Close").Click();
        }
    }
}
