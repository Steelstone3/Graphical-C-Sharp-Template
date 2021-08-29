using BubblesDivePlanner.Contracts.Models.DiveModels;

namespace BubblesDivePlanner.Commands.DiveStages
{
    public class DiveStageMaximumSurfacePressure : DiveStage
    {
        private int _compartmentCount;
        private IDiveProfile _diveProfile;

        public DiveStageMaximumSurfacePressure(int compartmentCount, IDiveProfile diveProfile)
        {
            _compartmentCount = compartmentCount;
            _diveProfile = diveProfile;
        }

        public override void RunStage()
        {
            CalculateMaximumSurfacePressure();
            CompartmentCountCheck(_compartmentCount - 1);
        }

        private void CalculateMaximumSurfacePressure()
        {
            _diveProfile.MaxSurfacePressures[Compartment] = (1.0f / _diveProfile.BValues[Compartment]) + _diveProfile.AValues[Compartment];
        }
    }
}