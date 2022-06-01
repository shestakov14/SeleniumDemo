using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

// create new chrome browser
var driver = new ChromeDriver();

//navigate to wiki
driver.Url = "https://wikipedia.org";

Console.WriteLine("Current title: " + driver.Title);

//locate serach field by id
var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();

searchField.SendKeys("QA" + Keys.Enter);

Console.WriteLine("title after search: " + driver.Title);

//close browser
driver.Quit();