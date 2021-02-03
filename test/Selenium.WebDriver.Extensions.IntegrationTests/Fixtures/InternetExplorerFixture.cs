namespace Selenium.WebDriver.Extensions.IntegrationTests.Fixtures
{
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using JetBrains.Annotations;
    using OpenQA.Selenium.IE;

    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    public class InternetExplorerFixture : FixtureBase
    {
        public InternetExplorerFixture() =>
            Browser = new InternetExplorerDriver(
                Path.GetDirectoryName(typeof(InternetExplorerFixture).Assembly.Location));
    }
}