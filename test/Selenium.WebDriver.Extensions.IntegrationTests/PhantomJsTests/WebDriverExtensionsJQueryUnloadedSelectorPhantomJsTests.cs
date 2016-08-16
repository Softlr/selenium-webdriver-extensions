﻿namespace Selenium.WebDriver.Extensions.IntegrationTests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Xunit;

    [Trait("Category", "Integration")]
    [Trait("Browser", "PhantomJs")]
    [ExcludeFromCodeCoverage]
    [Collection("Integration")]
    public class WebDriverExtensionsJQueryUnloadedSelectorPhantomJsTests :
        WebDriverExtensionsJQuerySelectorTests, IClassFixture<PhantomJsFixture>
    {
        public WebDriverExtensionsJQueryUnloadedSelectorPhantomJsTests(PhantomJsFixture fixture)
        {
            this.Browser = fixture.Browser;
            this.Browser.Navigate().GoToUrl(new Uri($"{this.ServerUrl}/JQueryUnloaded"));
        }
    }
}
