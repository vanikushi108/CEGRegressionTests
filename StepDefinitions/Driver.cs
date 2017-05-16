using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace CEGRegressionTests
{
    public class Driver
    {
        public static IWebDriver driver { get; set; }
        public class MySingleton
        {
            private static object myLock = new object();
            private static MySingleton mySingleton = null;

            private MySingleton()
            { }

            public static MySingleton GetInstance()
            {
                if (mySingleton == null)    // check
                {
                    lock (myLock)
                    {
                        if (mySingleton == null)    // double check
                        {
                            MySingleton newSingleton = new MySingleton();
                            System.Threading.Thread.MemoryBarrier();
                            mySingleton = newSingleton;
                        }
                    }
                }

                return mySingleton;
            }
        }
        public static string BaseAddress
        {
            get { return "https://cegtest.ceg.global/main.aspx"; }
        }

        public static void Initialize()
        {
            var chromeService = ChromeDriverService.CreateDefaultService(@"C:\Users\vkasala\Desktop\vanitha\ceg\Unitproj2\chromedriver_newVersion\chromedriver_win32");
            var options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArgument("test-type");
            driver = new ChromeDriver(chromeService, options);
            driver.Manage().Window.Maximize();
        }

        public static void Navigate()
        {
            driver.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close()
        {
            driver.Close();
        }

        public static string CurrentWindowHandle { get; set; }

        public static object WindowHandles { get; set; }

        internal void SwitchTo()
        {
            throw new NotImplementedException();
        }
     }
}