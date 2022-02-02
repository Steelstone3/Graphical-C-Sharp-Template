﻿using ReactiveUI;
using BubblesDivePlanner.DiveStep;
using BubblesDivePlanner.DiveModels.Selector;
using BubblesDivePlanner.Cylinders.CylinderSelector;
using System;
using System.Reactive;
using BubblesDivePlanner.Visibility;

namespace BubblesDivePlanner.ApplicationEntry
{
    public class MainWindowViewModel : ReactiveObject, IMainWindowModel
    {
        public MainWindowViewModel()
        {
           CalculateDiveStepCommand = ReactiveCommand.Create(CalculateDiveStep);
        }

        private IDiveModelSelectorModel _diveModelSelector = new DiveModelSelectorViewModel();
        public IDiveModelSelectorModel DiveModelSelector
        {
            get => _diveModelSelector;
            set => this.RaiseAndSetIfChanged(ref _diveModelSelector, value);
        }

        private IDiveStepModel _diveStep = new DiveStepViewModel();
        public IDiveStepModel DiveStep
        {
            get => _diveStep;
            set => this.RaiseAndSetIfChanged(ref _diveStep, value);
        }

        private ICylinderSelectorModel _cylinderSelector = new CylinderSelectorViewModel();
        public ICylinderSelectorModel CylinderSelector
        {
            get => _cylinderSelector;
            set => this.RaiseAndSetIfChanged(ref _cylinderSelector, value);
        }

        public ReactiveCommand<Unit, Unit> CalculateDiveStepCommand { get; }

        // public IObservable<bool> CanExecuteDiveStep
        // {
        //     get => this.WhenAnyValue(vm => vm.DiveModelSelector.SelectedDiveModel,
        //         vm => vm.CylinderSelector.SelectedCylinder,
        //         vm => vm.DiveStep.Depth,
        //         vm => vm.DiveStep.Time,
        //         (selectorDiveModel, selectorCylinder, depth, time) =>
        //             DiveModelSelector.ValidateSelectedDiveModel(selectorDiveModel)
        //             && CylinderSelector.ValidateSelectedCylinder(selectorCylinder)
        //             && DiveStep.ValidateDiveStep(depth, time));
        // }

        private void CalculateDiveStep()
        {
            new VisibilityController().Hide(this);
            //TODO AH Put in here the calculation new DiveStageCommandFactory (withing) → DiveStageRunner.RunDiveStages
            //Then return the result into a result view model (which will need better naming than the original)
        }
    }
}
