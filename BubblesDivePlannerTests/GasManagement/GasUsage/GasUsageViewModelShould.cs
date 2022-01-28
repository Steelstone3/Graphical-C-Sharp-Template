using System.Collections.Generic;
using Moq;
using Xunit;
using BubblesDivePlanner.GasManagement.GasUsage;

namespace BubblesDivePlannerTests.GasManagement.GasUsage
{
    public class GasUsageViewModelShould
    {
        private GasUsageViewModel _gasUsage = new();
        private int _initialPressurisedCylinderVolume = 2400;
        private int _gasRemaining = 1680;
        private int _gasUsed = 720;
        private int _surfaceAirConsumptionRate = 12;

        [Fact]
        public void AllowModelToBeSet()
        {
            //Act
            _gasUsage.InitialPressurisedCylinderVolume = _initialPressurisedCylinderVolume;
            _gasUsage.GasUsed = _gasUsed;
            _gasUsage.GasRemaining = _gasRemaining;
            _gasUsage.SurfaceAirConsumptionRate = _surfaceAirConsumptionRate;

            //Assert
            Assert.Equal(_initialPressurisedCylinderVolume, _gasUsage.InitialPressurisedCylinderVolume);
            Assert.Equal(_gasRemaining, _gasUsage.GasRemaining);
            Assert.Equal(_gasUsed, _gasUsage.GasUsed);
            Assert.Equal(_surfaceAirConsumptionRate, _gasUsage.SurfaceAirConsumptionRate);
        }

        [Fact]
        public void RaisePropertyChanged()
        {
            //Arrange
            var viewModelEvents = new List<string>();
            _gasUsage.PropertyChanged += (sender, e) => viewModelEvents.Add(e.PropertyName);

            //Act
            _gasUsage.InitialPressurisedCylinderVolume = _initialPressurisedCylinderVolume;
            _gasUsage.GasRemaining = _gasRemaining;
            _gasUsage.GasUsed = _gasUsed;
            _gasUsage.SurfaceAirConsumptionRate = _surfaceAirConsumptionRate;

            //Assert
            Assert.NotEmpty(viewModelEvents);
            Assert.Contains(nameof(_gasUsage.InitialPressurisedCylinderVolume), viewModelEvents);
            Assert.Contains(nameof(_gasUsage.GasRemaining), viewModelEvents);
            Assert.Contains(nameof(_gasUsage.GasUsed), viewModelEvents);
            Assert.Contains(nameof(_gasUsage.SurfaceAirConsumptionRate), viewModelEvents);
        }
    }
}