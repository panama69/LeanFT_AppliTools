namespace LeanFT_AppliTools
{
    using System;
    using System.Drawing;
    using HP.LFT.SDK.Web;
    using HP.LFT.SDK;
    using Applitools.LeanFT;

    public class HelloWorldTest
    {
        public static void Main(string[] args)
        {
            // Init the LeanFT SDK
            SDK.Init(new SdkConfiguration());

            // Open a Chrome browser
            IBrowser testBrowser = BrowserFactory.Launch(BrowserType.Chrome);

            // Initialize the eyes SDK and set your private API key.
            var eyes = new Eyes();
            eyes.ApiKey = "Z2Q1xi5kYILL8o6XavpjYnYtvCfV3111SSR2U102Rdfse1s110";

            try
            {
                // Start the test and set the browser's viewport size to 800x600
                eyes.Open(testBrowser, "Hello World!", "LeanFT/AppliTools Test", new Size(800, 600));

                // Navigate the browser to the "hello world!" web-site.
                testBrowser.Navigate("https://applitools.com/helloworld?diff2");

                // Visual checkpoint #1
                eyes.CheckWindow("Hello!");

                // Click the "Click me!" button
                IWebElement button = testBrowser.FindChildren<IWebElement>(new WebElementDescription { TagName = "button" })[0];
                button.Click();

                // Visual checkpoint #2
                eyes.CheckWindow("Click!");

                // End the test
                eyes.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                // Close the browser.
                testBrowser.Close();

                // If the test was aborted before eyes.Close was called, ends the test as aborted.
                eyes.AbortIfNotClosed();

                // Close the LeanFT SDK
                SDK.Cleanup();
            }
        }
    }
}
