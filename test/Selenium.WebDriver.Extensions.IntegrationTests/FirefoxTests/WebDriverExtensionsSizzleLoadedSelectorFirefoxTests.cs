namespace Selenium.WebDriver.Extensions.IntegrationTests.FirefoxTests
{
    using System.Diagnostics.CodeAnalysis;
    using Selenium.WebDriver.Extensions.IntegrationTests.Fixtures;
    using Selenium.WebDriver.Extensions.IntegrationTests.Tests;
    using Selenium.WebDriver.Extensions.Tests;
    using Xunit;
    using static Extensions.Tests.Trait.Browser;
    using static Extensions.Tests.Trait.Category;
    using static Extensions.Tests.Trait.Name;

    [Trait(CATEGORY, INTEGRATION)]
    [Trait(BROWSER, FIREFOX)]
    [ExcludeFromCodeCoverage]
    [Collection(INTEGRATION)]
    public class WebDriverExtensionsSizzleLoadedSelectorFirefoxTests :
        WebDriverExtensionsSizzleSelectorTests, IClassFixture<FirefoxFixture>
    {
        [SuppressMessage("ReSharper", "SuggestBaseTypeForParameter")]
        public WebDriverExtensionsSizzleLoadedSelectorFirefoxTests(FirefoxFixture fixture)
            : base(fixture.Browser, true)
        {
        }
    }
}