using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;
using System;
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
    }
}
