using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;
using System;

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

            WiniumDriver driver = new WiniumDriver(@"C:\Users\andrei.serban\Downloads\Winium.Desktop.Driver", options);

        }
    }
}
