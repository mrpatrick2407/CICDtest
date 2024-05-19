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
			//add
			await Page.GotoAsync("https://localhost:7257");
			await Page.Locator("input[name=email]").FillAsync("Theo");
			Assert.AreEqual("Theo",await Page.Locator("input[name=email]").InputValueAsync());
		}
	}
}