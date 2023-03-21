using BubblesDivePlanner.Cylinders.CylinderSelector;
using BubblesDivePlanner.Cylinders.CylinderSetup;
using BubblesDivePlanner.DiveModels.Selector;
using BubblesDivePlanner.DiveStep;
using BubblesDivePlanner.ViewModels.Models;
using ReactiveUI;

namespace BubblesDivePlanner.DivePlanner
{
    public class DiveCalculationParametersViewModel : DivePlannerSelectorViewModel, IDiveCalculationParametersModel
    {
        private IDiveStepModel _diveStep = new DiveStepViewModel();
        public IDiveStepModel DiveStep
        {
            get => _diveStep;
            set => this.RaiseAndSetIfChanged(ref _diveStep, value);
        }

        public IDiveModel DiveModel => DiveModelSelector.SelectedDiveModel.DeepClone();

        public ICylinderSetupModel SelectedCylinder => new CylinderPrototype().DeepClone(CylinderSelector.SelectedCylinder);
    }
}