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
            Assert.NotNull(mainWindowViewModel.ClickMeViewModel);
        }

        [Fact]
        public void RaisePropertyChanged()
        {
            //Arrange
            Mock<IClickMeViewModel> diveInformationModelDummy = new();
            var viewModelEvents = new List<string>();
            mainWindowViewModel.PropertyChanged += (sender, e) => viewModelEvents.Add(e.PropertyName);

            //Act
            mainWindowViewModel.ClickMeViewModel = diveInformationModelDummy.Object;

            //Assert
            Assert.Contains(nameof(mainWindowViewModel.ClickMeViewModel), viewModelEvents);
        }
    }
}