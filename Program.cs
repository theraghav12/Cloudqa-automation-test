using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

class AutomationPracticeTest
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        driver.Manage().Window.Maximize();

        try
        {
        
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            
            IWebElement firstNameField = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='First Name']")));
            firstNameField.Clear();
            firstNameField.SendKeys("Raghav");

          
            IWebElement mobileField = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Mobile Number']")));
            mobileField.Clear();
            mobileField.SendKeys("9876543210");

            IWebElement countryField = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Country']")));
            countryField.Clear();
            countryField.SendKeys("India");

          
            IWebElement danceCheckbox = wait.Until(d => d.FindElement(By.Id("Dance")));
            if (!danceCheckbox.Selected)
            {
                danceCheckbox.Click();
            }

         
            IWebElement maleRadioButton = wait.Until(d => d.FindElement(By.XPath("//input[@value='Male']")));
            if (!maleRadioButton.Selected)
            {
                maleRadioButton.Click();
            }

          
            IWebElement submitButton = wait.Until(d => d.FindElement(By.CssSelector("button[type='submit']")));
            submitButton.Click();

            Console.WriteLine("Form submitted successfully!");
        }
        catch (WebDriverTimeoutException ex)
        {
            Console.WriteLine("An element was not found within the timeout: " + ex.Message);
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine("Element not found: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            driver.Quit();
        }
    }
}
