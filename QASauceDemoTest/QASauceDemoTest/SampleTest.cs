using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V119.Page;
using System;

namespace QASauceDemoTest
{
    [TestClass]
    public class SampleTest
    {


        [TestMethod]
        public void testmethod()
        {

            // Console.WriteLine("welcome to selenium c#");
            //Navigate to the URL in incognito mode
            IWebDriver driver = new ChromeDriver("incognito");
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Find and input username and password
            driver.FindElement(By.Id("username")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");

            // Click the login button
            driver.FindElement(By.Id("login-button")).Click();

            // Verify the user is redirected to the products page
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/inventory.html"));

            // Select a T-shirt by clicking on its image or name
            driver.FindElement(By.Id(".inventory_item_name")).Click();

            // Verify the T-shirt details page is displayed 
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/inventory-item.html?id=1"));

            // Click the "Add to Cart" button 
            driver.FindElement(By.Id(".add-to-cart-sauce-labs-bolt-t-shirt")).Click();

            // Verify the T-shirt is added to the cart 
            Assert.IsTrue(driver.FindElement(By.Id(".shopping_cart_container")).Text.Equals("1"));

            // Click the cart icon to navigate to the cart 
            driver.FindElement(By.Id(".shopping_cart_link")).Click();

            // Verify the cart page is displayed 
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/cart.html"));

            // . Review the items in the cart and ensure that the T-shirt is listed with the correct details 

            Assert.IsTrue(driver.FindElement(By.Id(".inventory_item_name")).Text.Contains("sauce labs Bolt T-Shirt"));
            Assert.IsTrue(driver.FindElement(By.Id(".inventory_item_price")).Text.Contains("$15.99"));


            // Click the "Checkout" button 
            driver.FindElement(By.CssSelector(".checkout")).Click();

            // Verify the checkout information page is displayed 
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/checkout-step-one.html"));

            // Enter checkout information 
            driver.FindElement(By.Id("first-name")).SendKeys("Dominica");
            driver.FindElement(By.Id("last-name")).SendKeys("Izunobi");
            driver.FindElement(By.Id("postal-code")).SendKeys("900001");

            // Click the "Continue" button
            driver.FindElement(By.Id(".continue")).Click();

            // Verify the order summary page is displayed 
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/checkout-step-two.html"));

            // Click the "Finish" button 
            driver.FindElement(By.Id(".finish")).Click();

            // Verify the order confirmation page is displayed 
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/checkout-complete.html"));

            // Click the logout button 
            driver.FindElement(By.Id(".logout_sidebar_link")).Click();

            // Verify the user is redirected to the login page 
            Assert.IsTrue(driver.Url.Contains("https://www.saucedemo.com/"));





















        }
    }
}
