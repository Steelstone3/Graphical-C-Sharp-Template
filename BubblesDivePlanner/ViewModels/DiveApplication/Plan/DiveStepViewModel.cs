using BubblesDivePlanner.Contracts.Models.Plan;
using BubblesDivePlanner.Contracts.ViewModels.DiveApplication.Plan;
using BubblesDivePlanner.Models.Plan;
using ReactiveUI;

namespace BubblesDivePlanner.ViewModels.DiveApplication.Plan
{
    public class DiveStepViewModel : ViewModelBase, IDiveStepViewModel
    {
        private int _depth;
        public int Depth
        {
            get => _depth;
            set => this.RaiseAndSetIfChanged(ref _depth, value);
        }

        private int _time;
        public int Time
        {
            get => _time;
            set => this.RaiseAndSetIfChanged(ref _time, value);
        }

        public bool ValidateDiveStep(int depth, int time, double maximumOperatingDepth)
        {
            return time >= 1 && time <= 100 &&
            depth >= 0 && depth <= 100 &&
            (double)depth <= maximumOperatingDepth;
        }
    }
}