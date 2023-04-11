using System.Collections.Generic;
using Example.ViewModels;
using Example.ViewModels.Models;
using Moq;
using Xunit;

namespace BubblesDivePlannerTests.ViewModels
{
    public class MainWindowViewModelShould
    {
        private readonly MainWindowViewModel mainWindowViewModel = new();

        [Fact]
        public void AllowModelToBeSet()
        {
            //Assert
            Assert.NotNull(mainWindowViewModel.ClickMe);
        }

        [Fact]
        public void RaisePropertyChanged()
        {
            //Arrange
            Mock<IClickMeModel> clickMeModel = new();
            var viewModelEvents = new List<string>();
            mainWindowViewModel.PropertyChanged += (sender, e) => viewModelEvents.Add(e.PropertyName);

            //Act
            mainWindowViewModel.ClickMe = clickMeModel.Object;
            mainWindowViewModel.ClickMeResult = clickMeModel.Object;

            //Assert
            Assert.Contains(nameof(mainWindowViewModel.ClickMe), viewModelEvents);
            Assert.Contains(nameof(mainWindowViewModel.ClickMeResult), viewModelEvents);
        }
    }
}