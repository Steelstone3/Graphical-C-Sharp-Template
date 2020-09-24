﻿using DivePlannerMk3.Contracts;
using ReactiveUI;

namespace DivePlannerMk3.ViewModels.DivePlan
{
    public class DivePlanViewModel : ViewModelBase
    {
        private IDiveProfileService _diveProfileController;

        private PlanAddGasMixtureViewModel _addGasMixture = new PlanAddGasMixtureViewModel();
        public PlanAddGasMixtureViewModel AddGasMixture
        {
            get => _addGasMixture;
            set => this.RaiseAndSetIfChanged(ref _addGasMixture, value);
        }

        private PlanGasMixtureViewModel _gasMixture = new PlanGasMixtureViewModel();
        public PlanGasMixtureViewModel GasMixture
        {
            get => _gasMixture;
            set => this.RaiseAndSetIfChanged(ref _gasMixture, value);
        }

        private PlanDiveModelSelectorViewModel _diveModelSelector;
        public PlanDiveModelSelectorViewModel DiveModelSelector
        {
            get => _diveModelSelector;
            set => this.RaiseAndSetIfChanged(ref _diveModelSelector, value);
        }

        private PlanDiveStepViewModel _diveStep = new PlanDiveStepViewModel();

        public PlanDiveStepViewModel DiveStep
        {
            get => _diveStep;
            set => this.RaiseAndSetIfChanged(ref _diveStep, value);
        }

        private PlanGasManagementViewModel _gasManagement = new PlanGasManagementViewModel();

        public PlanGasManagementViewModel GasManagement
        {
            get => _gasManagement;
            set => this.RaiseAndSetIfChanged(ref _gasManagement, value);
        }

        public DivePlanViewModel(IDiveProfileService diveProfileController)
        {
            _diveProfileController = diveProfileController;
            _diveModelSelector = new PlanDiveModelSelectorViewModel(_diveProfileController);
        }
    }
}
