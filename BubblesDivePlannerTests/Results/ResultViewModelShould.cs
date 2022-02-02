using BubblesDivePlanner.DiveModels.DiveProfile;
using BubblesDivePlanner.DiveStep;
using BubblesDivePlanner.Results;
using Moq;
using Xunit;

namespace BubblesDivePlannerTests.Results
{
    public class ResultViewModelShould
    {
        private ResultViewModel _resultViewModel = new();

        [Fact]
        public void AllowModelToBeSet()
        {
            //Arrange
            Mock<IDiveStepModel> diveStepModelDummy = new();
            Mock<IDiveProfileModel> diveProfileModelDummy = new();

            //Act
           _resultViewModel.DiveProfileModel = diveProfileModelDummy.Object;
           _resultViewModel.DiveStepModel = diveStepModelDummy.Object;

            //Assert
            Assert.Equal(diveStepModelDummy.Object, _resultViewModel.DiveStepModel);
            Assert.Equal(diveProfileModelDummy.Object, _resultViewModel.DiveProfileModel);
        }
    }
}