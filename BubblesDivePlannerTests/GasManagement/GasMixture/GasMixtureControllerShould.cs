using BubblesDivePlanner.GasManagement.GasMixture;
using Xunit;

namespace BubblesDivePlannerTests.GasManagement.GasMixture
{
    public class GasMixtureControllerShould
    {
        private IGasMixtureController _gasMixtureController = new GasMixtureController();

        [Fact]
        public void CalculateNitrogenMixture()
        {
            //Arrange
            int oxygen = 21;
            int helium = 10;
            int expectedNitrogen = 69;

            //Act
            var actualNitrogen = _gasMixtureController.CalculateNitrogenMixture(oxygen, helium);

            //Assert
            Assert.Equal(expectedNitrogen, actualNitrogen);
        }
    }
}