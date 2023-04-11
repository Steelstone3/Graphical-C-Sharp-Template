using BubblesDivePlanner.Controllers;
using BubblesDivePlanner.Controllers.Interfaces;
using Xunit;

namespace ExampleTests.Controllers
{
    public class ClickMeControllerShould
    {
        private readonly IClickMeController clickMeController = new ClickMeController();

        [Fact]
        public void GetSomeText()
        {
            // Act
            string someText = clickMeController.GetSomeText();

            // Assert
            Assert.Equal("Some Text", someText);
        }
    }
}