using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DataDrivenTestingCalculator
{
    public class Calculator_Tests
    {
        private ChromeDriver driver;
        [SetUp]
        public void Setup()
        {
             this.driver = new ChromeDriver();
            driver.Url = "https://number-calculator.nakov.repl.co/";
        }

        [Test]
        public void Test_Calculator()
        {
            //arrange
            var field1 = driver.FindElement(By.Id("number1"));
            var field2 = driver.FindElement(By.Id("number2"));
            var operation = driver.FindElement(By.Id("operation"));
            var calculate = driver.FindElement(By.Id("calcButton"));
            var result = driver.FindElement(By.Id("result"));
            var clearField = driver.FindElement(By.Id("resetButton"));

            //act
            field1.SendKeys("5");
            operation.SendKeys("+");
            field2.SendKeys("6");
            calculate.Click();

            string expected = "Result: 11";
            Assert.That(expected, Is.EqualTo(result.Text));


        }
    }
}