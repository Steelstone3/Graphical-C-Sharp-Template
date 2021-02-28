﻿using System;
using System.Collections.Generic;
using ReactiveUI;

namespace DivePlannerMk3.ViewModels.DiveInfo
{
    public class DiveInfoViewModel : ViewModelBase
    {
        public DiveInfoViewModel()
        {
        }

        private InfoDecompressionProfileViewModel _decompressionProfile = new InfoDecompressionProfileViewModel();
        public InfoDecompressionProfileViewModel DecompressionProfile
        {
            get => _decompressionProfile;
            set => this.RaiseAndSetIfChanged(ref _decompressionProfile, value);
        }

        private DiveCeilingViewModel _diveCeilingViewModel = new DiveCeilingViewModel();
        public DiveCeilingViewModel DiveCeilingViewModel
        {
            get => _diveCeilingViewModel;
            set => this.RaiseAndSetIfChanged(ref _diveCeilingViewModel, value);
        }

        private CnsToxicityViewModel _cnsToxicityViewModel = new CnsToxicityViewModel();
        public CnsToxicityViewModel CnsToxicityViewModel
        {
            get => _cnsToxicityViewModel;
            set => this.RaiseAndSetIfChanged(ref _cnsToxicityViewModel, value);
        }

        private InfoDiveModelSelectedReadOnlyViewModel _infoDiveModelSelectedReadOnly = new InfoDiveModelSelectedReadOnlyViewModel();
        public InfoDiveModelSelectedReadOnlyViewModel InfoDiveModelSelectedReadOnly
        {
            get => _infoDiveModelSelectedReadOnly;
            set => this.RaiseAndSetIfChanged(ref _infoDiveModelSelectedReadOnly, value);
        }

        public void CalculateDiveStep(IEnumerable<double> toleratedAmbientPressures)
        {
            UpdateUiVisibility();
            DiveCeilingViewModel.CalculateDiveCeiling(toleratedAmbientPressures);
        }

        private void UpdateUiVisibility()
        {
            InfoDiveModelSelectedReadOnly.IsUiVisible = true;
            DiveCeilingViewModel.IsUiVisible = true;
            CnsToxicityViewModel.IsUiVisible = true;

            //TODO AH complexity to be added later true when user needs to decompress
            DecompressionProfile.IsUiVisible = true;
        }
    }
}
