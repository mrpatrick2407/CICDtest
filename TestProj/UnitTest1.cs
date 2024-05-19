//using Microsoft
using Microsoft.Playwright.MSTest;
namespace TestProj
{
	[TestClass]
	public class UnitTest1:PageTest
	{
		[TestMethod]
		public async Task TestMethod1()
		{
			await Page.GotoAsync("http://localhost:5093");
			await Page.Locator("input[name=email]").FillAsync("Theo");
			Assert.AreEqual("Theo",await Page.Locator("input[name=email]").InputValueAsync());
		}
	}
}