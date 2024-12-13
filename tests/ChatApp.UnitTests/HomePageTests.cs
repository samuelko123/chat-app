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
		page.MarkupMatches("<h1>Hello World</h1>");
	}
}
