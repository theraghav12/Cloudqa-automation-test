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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Using reliable selectors (e.g., based on unique attributes or hierarchical paths)
            IWebElement firstNameField = wait.Until(d => d.FindElement(By.CssSelector("input[name='First Name']")));
            firstNameField.Clear();
            firstNameField.SendKeys("Raghav");

            IWebElement secondNameField = wait.Until(d => d.FindElement(By.CssSelector("input[name='Last Name']")));
            secondNameField.Clear();
            secondNameField.SendKeys("Khurana");

            IWebElement mobileField = wait.Until(d => d.FindElement(By.CssSelector("input[placeholder='Mobile Number']")));
            mobileField.Clear();
            mobileField.SendKeys("9876543210");

            IWebElement countryField = wait.Until(d => d.FindElement(By.CssSelector("input[placeholder='Country']")));
            countryField.Clear();
            countryField.SendKeys("India");

            // Ensure checkbox selection is resilient
            IWebElement danceCheckbox = wait.Until(d => d.FindElement(By.XPath("//label[text()='Dance']/preceding-sibling::input[@type='checkbox']")));
            if (!danceCheckbox.Selected)
            {
                danceCheckbox.Click();
            }

            // Ensure radio button selection is resilient
            IWebElement maleRadioButton = wait.Until(d => d.FindElement(By.XPath("//label[text()='Male']/preceding-sibling::input[@type='radio']")));
            if (!maleRadioButton.Selected)
            {
                maleRadioButton.Click();
            }

            // Using a more generic selector for the submit button
            IWebElement submitButton = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(), 'Submit')]")));
            submitButton.Click();

            Console.WriteLine("Form submitted successfully.");
        }
        catch (WebDriverTimeoutException ex)
        {
            Console.WriteLine("Element could not be found in time: " + ex.Message);
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine("An error occurred while locating an element: " + ex.Message);
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
