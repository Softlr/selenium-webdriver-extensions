﻿namespace Selenium.WebDriver.Extensions.JQuery
{
    using System;
    using System.CodeDom;
    using Selenium.WebDriver.Extensions.Shared;

    /// <summary>
    /// The web element extensions.
    /// </summary>
    public static class WebElementExtensions
    {
        /// <summary>
        /// Returns the jQuery helper, that can be used to access jQuery-specific functionalities.
        /// </summary>
        /// <param name="webElement">The web element to base the search on.</param>
        /// <returns>The jQuery helper.</returns>
        public static JQueryHelper JQuery(this WebElement webElement)
        {
            if (webElement == null)
            {
                throw new ArgumentNullException("webElement");
            }

            return new JQueryHelper(webElement.WrappedDriver, webElement);
        }
    }
}