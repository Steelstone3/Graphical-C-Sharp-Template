using BubblesDivePlanner.Controllers;
using BubblesDivePlanner.Controllers.Interfaces;
using Example.ViewModels.Models;
using Moq;
using Xunit;

namespace ExampleTests.Controllers
{
    public class ClickMeControllerShould
    {
        private readonly Mock<IClickMeModel> clickMeModelStub = new();
        private readonly IClickMeController clickMeController = new ClickMeController();

        [Fact]
        public void GetSomeText()
        {
            // Arrange
            const string text = "Some Text";
            clickMeModelStub.Setup(cmm => cmm.SomeText).Returns(text);

            // Act
            string someText = clickMeController.GetSomeText(clickMeModelStub.Object);

            // Assert
            Assert.Equal(text, someText);
        }
    }
}