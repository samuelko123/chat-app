using AngleSharp.Dom;
using ChatApp.Components.Pages;

namespace ChatApp.UnitTests;

public class HomePageTests : TestContext
{
	[Fact]
	public void HomePage_DisplaysHelloWorld()
	{
		// Arrange
		var page = RenderComponent<Home>();

		// Assert
		var element = page.Find("h1");
		Assert.Equal("Hello World", element.GetInnerText());
	}
}
