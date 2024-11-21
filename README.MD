
# Selenium C# Automation Practice Form Test
This project is a simple automation script using Selenium WebDriver in C# to interact with an online form. The main objective is to fill out the form with predefined data, and submit it to ensure that the fields are filled correctly. The form includes fields such as "First Name", "Mobile Number", "Country", and others. The script is designed to work even if the position or other properties of the HTML elements change.

## Prerequisites

Before running the project, ensure you have the following installed:

- **Visual Studio** or any C# development environment.
- **Selenium WebDriver** for C#.
- **ChromeDriver** compatible with your version of Google Chrome.
- **.NET SDK** (e.g., .NET 6 or later).

## Installation
1. Clone the repository:
bash
Copy code

git clone https://github.com/your-username/selenium-csharp-automation.git
cd selenium-csharp-automation 
2. Install the necessary NuGet packages:
To use Selenium in your C# project, install the following NuGet packages:

bash
Copy code
dotnet add package Selenium.WebDriver
dotnet add package Selenium.Support
dotnet add package Selenium.WebDriver.ChromeDriver
3. Add ChromeDriver:
Ensure that you have ChromeDriver installed and available in your system’s PATH or specify the path to chromedriver.exe in the code:

csharp
Copy code
IWebDriver driver = new ChromeDriver(@"path\to\chromedriver");
You can download ChromeDriver from the official website.

4. Build and Run:
Build and run the project in Visual Studio or by using the following command:

bash

dotnet run
## How the Script Works
Setup: The script initializes a ChromeDriver instance (optionally in headless mode) and opens the form on the website.

Element Interaction:

The script interacts with various form fields (First Name, Mobile Number, Country, etc.) using WebDriverWait to ensure elements are available before interacting with them.
Actions:

Fill out the fields with predefined data (First Name: "Raghav", Mobile Number: "9876543210", Country: "India").
Select checkboxes or radio buttons if they are not already selected.
Click the submit button to submit the form.
Handling Errors: The script is designed to handle errors like timeouts or missing elements by providing meaningful error messages in the console.

Termination: The browser closes after the script has finished executing.

# Example Output
After running the script, you should see the following output in the console if everything goes as planned:

css
Copy code
Form submitted successfully!
If any errors occur, the relevant error message will be shown.

Troubleshooting
WebDriver Timeout Errors: If you encounter timeouts, increase the waiting time in the WebDriverWait to allow for longer page load times.

Element Not Found: If the script cannot locate an element, verify the XPath or CSS selector used to locate the element is correct. Open Chrome Developer Tools and inspect the elements on the page to check the locators.

Chrome Version Mismatch: Ensure that the version of ChromeDriver matches the version of Google Chrome installed on your machine. You can download the correct version of ChromeDriver from here.

