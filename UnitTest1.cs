using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace myVCA_Automation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AppiumOptions caps = new AppiumOptions();

            //**********On Simulator*********************
            caps.AddAdditionalCapability("deviceName", "Pixel XL API 30");
            caps.AddAdditionalCapability("udid", "emulator-5554");
            caps.AddAdditionalCapability("platformVersion", "8.1");
            caps.AddAdditionalCapability("platformName", "Android");
            caps.AddAdditionalCapability("fullReset", "true");
            caps.AddAdditionalCapability("appActivity", "vcacareclub.views.pages.root.RootPage");
            caps.AddAdditionalCapability("appPackage", "com.vca.careclub");
            caps.AddAdditionalCapability("app", AppDomain.CurrentDomain.BaseDirectory + "\\APKFiles\\com.vca.careclub-anycpu.apk");
            caps.AddAdditionalCapability("androidInstallTimeout", "1200000000");
            caps.AddAdditionalCapability("automationName", "UiAutomator2");


            //********On Real device ** Samsung S21 5G*****************************
           /*caps.AddAdditionalCapability("deviceName", "Android");
            caps.AddAdditionalCapability("udid", "R5CR70Z8SJJ");
            caps.AddAdditionalCapability("platformVersion", "11");
            caps.AddAdditionalCapability("platformName", "Android");
            caps.AddAdditionalCapability("fullReset", "true");
            //caps.AddAdditionalCapability("appActivity", "vcacareclub.views.pages.root.RootPage");
            //caps.AddAdditionalCapability("appPackage", "com.vca.careclub");
            caps.AddAdditionalCapability("app", AppDomain.CurrentDomain.BaseDirectory + "\\APKFiles\\com.vca.careclub-anycpu.apk");
            caps.AddAdditionalCapability("uiautomator2ServerInstallTimeout", "1200000000");
            caps.AddAdditionalCapability("automationName", "UiAutomator2");*/

            AppiumDriver<AppiumWebElement> driver1 = new AndroidDriver<AppiumWebElement>(
                new Uri("http://127.0.0.1:4723/wd/hub"),
                caps,
                TimeSpan.FromMinutes(Convert.ToInt32("3"))
                );

            System.Threading.Thread.Sleep(2000);
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Already have an account?, Log In']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]").Click();
            System.Threading.Thread.Sleep(10000);


            //*************************************************Login with email*************************************
            driver1.FindElementByXPath("//android.view.ViewGroup[contains(@content-desc,'Email Address')]//android.widget.EditText").SendKeys("testl.gaur@vca.com");
            driver1.FindElementByXPath("//android.view.ViewGroup[contains(@content-desc,'Password')]//android.widget.EditText").SendKeys("Test1234");
            System.Threading.Thread.Sleep(2000);
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Log In']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            System.Threading.Thread.Sleep(10000);

            //*********************************Login with Facebook****************************
            /*driver1.FindElementByXPath("(//android.view.ViewGroup[@content-desc='Log In with Facebook'])[2]").Click();
            System.Threading.Thread.Sleep(10000);
            driver1.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.widget.FrameLayout[2]/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.widget.Button").Click();
            System.Threading.Thread.Sleep(10000);*/

            //*********************************Login with Google****************************
            /*driver1.FindElementByXPath("(//android.view.ViewGroup[@content-desc='Log In with Google'])[2]").Click();
            System.Threading.Thread.Sleep(10000);
            driver1.FindElementByXPath("//android.view.View[@content-desc='Barbara Briggs vcamobile.bb@gmail.com']").Click();
            System.Threading.Thread.Sleep(10000);*/
            
            //********************************First time login Onboarding info*****************************************
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Next']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Next']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Next']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Close']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();

           
            //*******************************Check the four tiles are present on dashboard***************************************
            System.Threading.Thread.Sleep(10000);
            IWebElement preventiveCare = driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Preventive Care']/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]");
            IWebElement prefills = driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Refills']/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]");
            IWebElement dosingReminders = driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Dosing Reminders']/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]");
            IWebElement appointements = driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Appointments']/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[2]");
            
            Assert.IsTrue(preventiveCare.Displayed);
            Assert.IsTrue(prefills.Displayed);
            Assert.IsTrue(dosingReminders.Displayed);
            Assert.IsTrue(appointements.Displayed);
            Console.WriteLine("All the tabs displayed correctly");


            //*********************************************Log out process*******************************
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Menu']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            System.Threading.Thread.Sleep(10000);
            driver1.FindElementByXPath("(//android.view.ViewGroup[@content-desc='Settings'])[2]").Click();
            System.Threading.Thread.Sleep(10000);
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Appointments']/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup").Click();
            System.Threading.Thread.Sleep(10000);


            //*********************************************Second time Log In**********************************
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Log In']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            System.Threading.Thread.Sleep(10000);
            //driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='testl.gaur@vca.com']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.EditText").SendKeys("");
            //System.Threading.Thread.Sleep(2000);
            driver1.FindElementByXPath("//android.view.ViewGroup[contains(@content-desc,'Password')]//android.widget.EditText").SendKeys("Test1234");
            System.Threading.Thread.Sleep(2000);
            driver1.FindElementByXPath("//android.view.ViewGroup[@content-desc='Log In']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();
            System.Threading.Thread.Sleep(10000);

        }
    }
}
