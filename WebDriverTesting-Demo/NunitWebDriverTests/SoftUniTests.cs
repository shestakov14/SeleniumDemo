using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class SoftUniTests
    {

        private WebDriver driver;
        [OneTimeSetUp]
        public void OpenBroserAndNavigate()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://softuni.bg";
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }


        [Test]
        public void Test_Main_Page_Tittle()
        {

            //act
            driver.Url = "https://softuni.bg";
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";

            //assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));

            driver.FindElement(By.)

        }


        [Test]
        public void Test_Click_AboutUs()
        {

            //act
            var zaNasElement = driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(1) > a > span"));
            zaNasElement.Click();

            string expectedTitle = "За нас - Софтуерен университет";

            //assert
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));

        }

    }
}