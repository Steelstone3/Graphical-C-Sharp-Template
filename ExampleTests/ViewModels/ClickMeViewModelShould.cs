using System.Collections.Generic;
using Example.ViewModels;
using Xunit;

namespace BubblesDivePlannerTests.ViewModels
{
    public class ClickMeViewModelShould
    {
        private readonly ClickMeViewModel clickMeViewModel = new();

        [Fact]
        public void AllowModelToBeSet()
        {
            // Arrange
            const string someText = "I am some text";

            // Act
            clickMeViewModel.SomeText = someText;

            // Assert
            Assert.Equal(someText, clickMeViewModel.SomeText);
        }

        [Fact]
        public void RaisePropertyChanged()
        {
            //Arrange
            const string someText = "A Text String";
            var viewModelEvents = new List<string>();
            clickMeViewModel.PropertyChanged += (sender, e) => viewModelEvents.Add(e.PropertyName);

            //Act
            clickMeViewModel.SomeText = someText;

            //Assert
            Assert.Contains(nameof(clickMeViewModel.SomeText), viewModelEvents);
        }
    }
}